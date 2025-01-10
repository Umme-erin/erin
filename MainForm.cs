using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSteganographySusmita
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string selectCoverImagePathForEmbed { get; set; }
        public string selectStegoImagePathForEmbedModelP { get; set; }
        public string selectStegoImagePathForEmbedModel_8 { get; set; }
        public string selectStegoImagePathForEmbedModelXor { get; set; }
        public string selectStegoImagePathForExtract { get; set; }
        private void btnLoadCover_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Browse PNG File";
                openFileDialog.Filter = "Image file (*.png)|*.png";
                openFileDialog.Multiselect = false;
                string fileWav = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileWav = openFileDialog.FileName;
                }
                if (String.IsNullOrEmpty(fileWav))
                    throw new Exception("Please select a png file....");

                if (File.Exists(fileWav))
                {
                    Bitmap bitmap = new Bitmap(fileWav);
                    pictureBoxCover.Image = bitmap;
                    pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                    selectCoverImagePathForEmbed = fileWav;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmbed_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txtEmbed.Text.Trim().Count().ToString();
        }

        private void btnEmbed_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to hide message into selected cover image?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (selectCoverImagePathForEmbed == null && checkedListBoxEmbed.CheckedItems.Count < 1 && txtEmbed.Text.Trim() == null)
                    {
                        MessageBox.Show("Select Cover Image First", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    foreach (var item in checkedListBoxEmbed.CheckedItems)
                    {
                        if (item.ToString().Contains("Proposed Model"))
                        {
                            string stegoFileAddress = SelectDestinationToSaveStegoImageFile("Proposed Model");
                            selectStegoImagePathForEmbedModelP = stegoFileAddress;
                            Bitmap inputCoverImg = new Bitmap(selectCoverImagePathForEmbed);
                            List<Tuple<int, int>> coveredFiltered_pixels = inputCoverImg != null ? EdgeDetection(inputCoverImg) : null;
                            ProposedAlgorithm proposedAlgorithm = new ProposedAlgorithm();
                            string proposedModelHidingStatus = proposedAlgorithm.HideMessage(txtEmbed.Text.Trim(), selectStegoImagePathForEmbedModelP, selectCoverImagePathForEmbed, coveredFiltered_pixels);
                            var proposedModelImageQualityMatrics = proposedAlgorithm.CheckValidation(selectCoverImagePathForEmbed, selectStegoImagePathForEmbedModelP);
                            if (proposedModelHidingStatus.Contains("Success"))
                            {
                                Bitmap bitmap = new Bitmap(selectStegoImagePathForEmbedModelP);
                                pictureBoxCover.Image = bitmap;
                                pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                            this.dataGridViewImageQualityMatrics.Rows.Add("Proposed Model", label1.Text.Trim(), $"{inputCoverImg.Width}X{inputCoverImg.Height}", proposedModelImageQualityMatrics.Item1, proposedModelImageQualityMatrics.Item2, proposedModelImageQualityMatrics.Item3);
                        }
                        if (item.ToString().Contains("8 Directional Model"))
                        {
                            string stegoFileAddress = SelectDestinationToSaveStegoImageFile("8 Directional Model");
                            selectStegoImagePathForEmbedModel_8 = stegoFileAddress;
                            _8DirBasedAlgorithm _8DirBasedAlgorithm = new _8DirBasedAlgorithm();
                            _8DirBasedAlgorithm.HideMessage(txtEmbed.Text.Trim(), selectStegoImagePathForEmbedModel_8, selectCoverImagePathForEmbed);
                            var proposedModelImageQualityMatrics = _8DirBasedAlgorithm.CheckValidation(selectCoverImagePathForEmbed, selectStegoImagePathForEmbedModel_8);

                            Bitmap bitmap = new Bitmap(selectStegoImagePathForEmbedModel_8);
                            pictureBoxCover.Image = bitmap;
                            pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                            this.dataGridViewImageQualityMatrics.Rows.Add("8 Directional Model", label1.Text.Trim(), $"{bitmap.Width}X{bitmap.Height}", proposedModelImageQualityMatrics.Item1, proposedModelImageQualityMatrics.Item2, proposedModelImageQualityMatrics.Item3);
                        }
                        if (item.ToString().Contains("XOR Sub Model"))
                        {
                            string stegoFileAddress = SelectDestinationToSaveStegoImageFile("XOR Sub Model");
                            selectStegoImagePathForEmbedModel_8 = stegoFileAddress;
                            XORBasedTechnique XORBasedTechnique = new XORBasedTechnique();
                            XORBasedTechnique.HideMessage(txtEmbed.Text.Trim(), selectStegoImagePathForEmbedModel_8, selectCoverImagePathForEmbed);
                            var proposedModelImageQualityMatrics = XORBasedTechnique.CheckValidation(selectCoverImagePathForEmbed, selectStegoImagePathForEmbedModel_8);

                            Bitmap bitmap = new Bitmap(selectStegoImagePathForEmbedModel_8);
                            pictureBoxCover.Image = bitmap;
                            pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                            this.dataGridViewImageQualityMatrics.Rows.Add("XOR Sub Model", label1.Text.Trim(), $"{bitmap.Width}X{bitmap.Height}", proposedModelImageQualityMatrics.Item1, proposedModelImageQualityMatrics.Item2, proposedModelImageQualityMatrics.Item3);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SelectDestinationToSaveStegoImageFile(string model)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = $"Where you going to save your stego image file for ({model})?",
                Filter = "Image file (*.png)|*.png",
                FileName = $"{model}Stego{ Path.GetFileName(selectCoverImagePathForEmbed) }"
            };
            string stegoFileAddress = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                stegoFileAddress = saveFileDialog.FileName;

            if (String.IsNullOrEmpty(stegoFileAddress))
                throw new Exception("Save file is not be empty. Try again later!");
            return stegoFileAddress;
        }

        public List<Tuple<int, int>> EdgeDetection(Bitmap inputCoverImg)
        {
            List<Tuple<int, int>> selected_pixels = new List<Tuple<int, int>>();
            SobelEdgeDetectorHelper _Detect = new SobelEdgeDetectorHelper(SobelEdgeDetectorHelper.FilterType.NoEdgeDetection, inputCoverImg);
            _Detect.ConvertToGrayScale();
            Bitmap gray_image = _Detect.Bmp;
            //important param: Thresold(range:1-100), lowthresold(range:1-100), sigma (range: 0.1-2.7)
            _Detect = new SobelEdgeDetectorHelper(SobelEdgeDetectorHelper.FilterType.SobelFilter, gray_image);
            _Detect.Threshold = 100;
            _Detect.ApplyFilter();
            var bmp = _Detect.Bmp;
            Binarilization(selected_pixels, bmp);
            return selected_pixels;
        }

        private void Binarilization(List<Tuple<int, int>> selected_pixels, Bitmap bmp)
        {
            //Binarilization
            int black_pixel = 0, white_pixel = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    int r, g, b;
                    if (color.R >= 127)
                        r = 255;
                    else
                        r = 0;
                    if (color.G >= 127)
                        g = 255;
                    else
                        g = 0;
                    if (color.B >= 127)
                        b = 255;
                    else
                        b = 0;
                    bmp.SetPixel(i, j, Color.FromArgb(r, g, b));

                    if (bmp.GetPixel(i, j) == Color.FromArgb(0, 0, 0))
                    {
                        selected_pixels.Add(new Tuple<int, int>(i, j));
                        black_pixel++;
                    }
                    else
                        white_pixel++;
                }
            }
        }

        private void btnLoadStego_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Browse PNG File";
                openFileDialog.Filter = "Image file (*.png)|*.png";
                openFileDialog.Multiselect = false;
                string fileWav = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileWav = openFileDialog.FileName;
                }
                if (String.IsNullOrEmpty(fileWav))
                    throw new Exception("Please select a png file....");

                if (File.Exists(fileWav))
                {
                    Bitmap bitmap = new Bitmap(fileWav);
                    pictureBoxStegoExtract.Image = bitmap;
                    pictureBoxStegoExtract.SizeMode = PictureBoxSizeMode.StretchImage;
                    selectStegoImagePathForExtract = fileWav;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to extract message from selected stego image?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (checkedListBoxExtract.Items.Count > 1 && selectStegoImagePathForExtract == null)
                    {
                        MessageBox.Show("Select cover image and Select only one technique","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                       
                    foreach (var item in checkedListBoxExtract.CheckedItems)
                    {
                        if (item.ToString().Contains("Proposed Model"))
                        {
                            Bitmap inputCoverImg = new Bitmap(selectStegoImagePathForExtract);
                            List<Tuple<int, int>> coveredFiltered_pixels = inputCoverImg != null ? EdgeDetection(inputCoverImg) : null;
                            ProposedAlgorithm proposedAlgorithm = new ProposedAlgorithm();
                            string secretMessage = proposedAlgorithm.ExtractSecretMessage(selectStegoImagePathForExtract, coveredFiltered_pixels);
                            txtExtract.Text = secretMessage;
                        }
                        if (item.ToString().Contains("8 Directional Model"))
                        {
                            _8DirBasedAlgorithm _8DirBasedAlgorithm = new _8DirBasedAlgorithm();
                            string secretMessage = _8DirBasedAlgorithm.ExtractSecretMessage(selectStegoImagePathForExtract);
                            txtExtract.Text = secretMessage;
                        }
                        if (item.ToString().Contains("XOR Sub Model"))
                        {
                            XORBasedTechnique XORBasedTechnique = new XORBasedTechnique();
                            string secretMessage = XORBasedTechnique.ExtractSecretMessage(selectStegoImagePathForExtract);
                            txtExtract.Text = secretMessage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
