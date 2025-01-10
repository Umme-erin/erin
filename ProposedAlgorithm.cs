using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSteganographySusmita
{
    public class ProposedAlgorithm:IDisposable
    {
       
        public string messageBinary = "";
        public char[] messageLengthBinaryChar;
        public char[] secretMesssgaeBinary;
        public ProposedAlgorithm()
        {

        }
        public void Dispose()
        {
            secretRealMessage.Clear();
            GC.SuppressFinalize(this);
        }
        public string HideMessage(string message, string stego_file_name, string cover_file_name, List<Tuple<int, int>> filtered_pixels)
        {
            try
            {
                messageLengthBinaryChar = messageLengthBinaryFormat(message.Length);
                secretMesssgaeBinary = messageBinaryFormat(message);

                //we have to hide the length to 1st 10 pixel
                int bitno = 0;
                int bitnoS = 0;
                Bitmap coverimage = new Bitmap(cover_file_name);

                int iteration = 0;
                foreach (var position in filtered_pixels)
                {
                    int x = position.Item1; int y = position.Item2;
                    Color pixel = coverimage.GetPixel(x, y);
                    string red = Convert.ToString(pixel.R, 2).PadLeft(8, '0');
                    string green = Convert.ToString(pixel.G, 2).PadLeft(8, '0');
                    string blue = Convert.ToString(pixel.B, 2).PadLeft(8, '0');
                    if (iteration < 10)
                    {
                        bitno = hideMessageLengthInfo(bitno, coverimage, x, y, pixel, red, green, blue);
                    }
                    else
                    {
                        if (bitnoS < secretMesssgaeBinary.Length)
                        {
                            bitnoS = hideSecretMessageInfo(bitnoS, coverimage, x, y, pixel, red, green, blue);
                        }
                    }
                    iteration++;
                }
                coverimage.Save(stego_file_name, ImageFormat.Png);

                return "Success";
            }
            catch (Exception ex)
            {
                return "Fail";
            }
        }

        private int hideSecretMessageInfo(int bitnoS, Bitmap coverimage, int x, int y, Color pixel, string red, string green, string blue)
        {
            //here we are replacing the secrect message bit into the last position in red and converted to integer
            int newred = Convert.ToInt32((new StringBuilder(red) { [7] = secretMesssgaeBinary[bitnoS] }.ToString()), 2);
            int newgreen = Convert.ToInt32((new StringBuilder(green) { [7] = secretMesssgaeBinary[bitnoS + 1] }.ToString()), 2);
            int newblue = Convert.ToInt32((new StringBuilder(blue) { [7] = secretMesssgaeBinary[bitnoS + 2] }.ToString()), 2);

            bitnoS = bitnoS + 3;

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(pixel.A, newred, newgreen, newblue);
            coverimage.SetPixel(x, y, myRgbColor);
            return bitnoS;
        }

        private int hideMessageLengthInfo(int bitno, Bitmap coverimage, int x, int y, Color pixel, string red, string green, string blue)
        {
            //here we are replacing the secrect message bit into the last position in red and converted to integer
            int newred = Convert.ToInt32((new StringBuilder(red) { [7] = messageLengthBinaryChar[bitno] }.ToString()), 2);
            int newgreen = Convert.ToInt32((new StringBuilder(green) { [7] = messageLengthBinaryChar[bitno + 1] }.ToString()), 2);
            int newblue = Convert.ToInt32((new StringBuilder(blue) { [7] = messageLengthBinaryChar[bitno + 2] }.ToString()), 2);

            bitno = bitno + 3;

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(pixel.A, newred, newgreen, newblue);
            coverimage.SetPixel(x, y, myRgbColor);
            return bitno;
        }

        public StringBuilder secretRealMessage = new StringBuilder();
        public string ExtractSecretMessage(string stego_file_name, List<Tuple<int, int>> filtered_pixels)
        {
            try
            {
                string frameNoBinary = "";
                StringBuilder secretMessage = new StringBuilder();


                Bitmap coverimage = new Bitmap(stego_file_name);
                int frameN = 0, lengthOfMsgBit = 0;
                int onlyOne = 0;

                int iteration = 0;
                foreach (var position in filtered_pixels)
                {
                    int x = position.Item1; int y = position.Item2;
                    if (iteration < 10)
                    {
                        string s = secretBitMetaData(coverimage, x, y);
                        frameNoBinary += s;
                    }
                    else
                    {
                        if (onlyOne == 0)
                            retriveSecretMessage(frameNoBinary, out frameN, out lengthOfMsgBit, out onlyOne);
                        if (secretMessage.Length <= (lengthOfMsgBit))
                            secretMessage.Append(secretBitMetaData(coverimage, x, y));
                        else
                            break;
                    }
                    iteration++;
                }
                secretBitToBytes(secretMessage);
                return secretRealMessage.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Failed : " + ex.Message + secretRealMessage.ToString();
            }
        }

        private void secretBitToBytes(StringBuilder secretMessage)
        {
            char[] secretMessageBinary = secretMessage.Remove(secretMessage.Length - 4, 3).ToString().ToCharArray();
            string bit8 = "";
            int aa = 0;
            for (int i = 0; i < secretMessageBinary.Length; i++)
            {
                if (aa != 8)
                {
                    bit8 = bit8 + secretMessageBinary[i].ToString();

                    aa++;
                }
                if (aa == 8)
                {
                    int acii = 32;
                    try
                    {
                        secretRealMessage.Append(Char.ConvertFromUtf32(Convert.ToInt32(bit8, 2)));
                    }
                    catch (Exception exxx)
                    {
                        secretRealMessage.Append(Char.ConvertFromUtf32(32));
                    }
                    bit8 = "";
                    aa = 0;
                }
            }
        }

        private void retriveSecretMessage(string frameNoBinary, out int frameN, out int lengthOfMsgBit, out int onlyOne)
        {
            frameN = Convert.ToInt32(frameNoBinary, 2);
            lengthOfMsgBit = 0;
            if (((frameN * 8) % 3) == 2)
            {
                lengthOfMsgBit += 1;
            }
            else if (((frameN * 8) % 3) == 1)
            {
                lengthOfMsgBit += 2;
            }

            lengthOfMsgBit += (frameN * 8);
            onlyOne = 1;
        }

        private string secretBitMetaData(Bitmap img, int x, int y)
        {
            Color pixel = img.GetPixel(x, y);
            string red = Convert.ToString(pixel.R, 2).PadLeft(8, '0');
            string green = Convert.ToString(pixel.G, 2).PadLeft(8, '0');
            string blue = Convert.ToString(pixel.B, 2).PadLeft(8, '0');
            string s = (red.Last().ToString() + green.Last().ToString() + blue.Last().ToString());
            return s;
        }

        private char[] messageBinaryFormat(string message)
        {
            /*
            * Here we are creating messages bit to binary form
            */
            //message is converted to 8bit binary
            StringBuilder sb = new StringBuilder();
            foreach (char c in message.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            messageBinary = sb.ToString();

            //to maintain error from pass length we have to add (extra 0 or 00)
            if (((messageBinary.Length) % 3) == 2)
            {
                messageBinary += "0";
            }
            else if (((messageBinary.Length) % 3) == 1)
            {
                messageBinary += "00";
            }

            return messageBinary.ToCharArray(); //all binary bit has been converted into array.
        }

        private char[] messageLengthBinaryFormat(int number)
        {
            string binary = Convert.ToString(number, 2).PadLeft(30, '0');
            return binary.ToCharArray();
        }

        public Tuple<double, double, double> CheckValidation(string coverFile, string stegoFile)
        {
            try
            {
                double mseGray = 0.0, mse = 0.0, rmse = 0.0, psnr = 0.0;
                Bitmap bmp1 = new Bitmap(coverFile);
                Bitmap bmp2 = new Bitmap(stegoFile);

                for (int i = 0; i < bmp1.Width; i++)
                {
                    for (int j = 0; j < bmp1.Height; j++)
                    {
                        int gray1 = bmp1.GetPixel(i, j).R;
                        int gray2 = bmp2.GetPixel(i, j).R;
                        double sum = Math.Pow(gray1 - gray2, 2);
                        mseGray += sum;
                    }
                }
                mse = (mseGray) / (bmp1.Width * bmp1.Height) * 3;
                psnr = 10 * Math.Log10((255 * 255) / mse);
                rmse = Math.Sqrt(mse);
                return new Tuple<double, double, double>(psnr, mse, rmse);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
