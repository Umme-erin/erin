namespace ImageSteganographySusmita
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkedListBoxEmbed = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmbed = new MetroFramework.Controls.MetroButton();
            this.txtEmbed = new MetroFramework.Controls.MetroTextBox();
            this.btnLoadCover = new MetroFramework.Controls.MetroButton();
            this.pictureBoxSetgo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.checkedListBoxExtract = new System.Windows.Forms.CheckedListBox();
            this.btnExtract = new MetroFramework.Controls.MetroButton();
            this.txtExtract = new MetroFramework.Controls.MetroTextBox();
            this.btnLoadStego = new MetroFramework.Controls.MetroButton();
            this.pictureBoxStegoExtract = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewImageQualityMatrics = new System.Windows.Forms.DataGridView();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStegoExtract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImageQualityMatrics)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1159, 562);
            this.splitContainer1.SplitterDistance = 585;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer2.Panel1.Controls.Add(this.checkedListBoxEmbed);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btnEmbed);
            this.splitContainer2.Panel1.Controls.Add(this.txtEmbed);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoadCover);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBoxSetgo);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBoxCover);
            this.splitContainer2.Panel1.Controls.Add(this.metroLabel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer2.Panel2.Controls.Add(this.checkedListBoxExtract);
            this.splitContainer2.Panel2.Controls.Add(this.btnExtract);
            this.splitContainer2.Panel2.Controls.Add(this.txtExtract);
            this.splitContainer2.Panel2.Controls.Add(this.btnLoadStego);
            this.splitContainer2.Panel2.Controls.Add(this.pictureBoxStegoExtract);
            this.splitContainer2.Panel2.Controls.Add(this.metroLabel2);
            this.splitContainer2.Size = new System.Drawing.Size(585, 562);
            this.splitContainer2.SplitterDistance = 272;
            this.splitContainer2.TabIndex = 0;
            // 
            // checkedListBoxEmbed
            // 
            this.checkedListBoxEmbed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxEmbed.CheckOnClick = true;
            this.checkedListBoxEmbed.FormattingEnabled = true;
            this.checkedListBoxEmbed.Items.AddRange(new object[] {
            "Proposed Model",
            "8 Directional Model",
            "XOR Sub Model"});
            this.checkedListBoxEmbed.Location = new System.Drawing.Point(447, 22);
            this.checkedListBoxEmbed.Name = "checkedListBoxEmbed";
            this.checkedListBoxEmbed.Size = new System.Drawing.Size(135, 227);
            this.checkedListBoxEmbed.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(106, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Letter Count";
            // 
            // btnEmbed
            // 
            this.btnEmbed.Location = new System.Drawing.Point(315, 221);
            this.btnEmbed.Name = "btnEmbed";
            this.btnEmbed.Size = new System.Drawing.Size(97, 36);
            this.btnEmbed.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnEmbed.TabIndex = 5;
            this.btnEmbed.Text = "Embed";
            this.btnEmbed.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEmbed.Click += new System.EventHandler(this.btnEmbed_Click);
            // 
            // txtEmbed
            // 
            this.txtEmbed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmbed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmbed.Location = new System.Drawing.Point(106, 22);
            this.txtEmbed.Multiline = true;
            this.txtEmbed.Name = "txtEmbed";
            this.txtEmbed.Size = new System.Drawing.Size(306, 193);
            this.txtEmbed.TabIndex = 4;
            this.txtEmbed.TextChanged += new System.EventHandler(this.txtEmbed_TextChanged);
            // 
            // btnLoadCover
            // 
            this.btnLoadCover.Location = new System.Drawing.Point(3, 118);
            this.btnLoadCover.Name = "btnLoadCover";
            this.btnLoadCover.Size = new System.Drawing.Size(97, 36);
            this.btnLoadCover.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLoadCover.TabIndex = 3;
            this.btnLoadCover.Text = "Load Cover Img";
            this.btnLoadCover.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLoadCover.Click += new System.EventHandler(this.btnLoadCover_Click);
            // 
            // pictureBoxSetgo
            // 
            this.pictureBoxSetgo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxSetgo.Location = new System.Drawing.Point(3, 165);
            this.pictureBoxSetgo.Name = "pictureBoxSetgo";
            this.pictureBoxSetgo.Size = new System.Drawing.Size(97, 104);
            this.pictureBoxSetgo.TabIndex = 2;
            this.pictureBoxSetgo.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxCover.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(97, 104);
            this.pictureBoxCover.TabIndex = 1;
            this.pictureBoxCover.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel1.Location = new System.Drawing.Point(220, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Embedding Panel";
            // 
            // checkedListBoxExtract
            // 
            this.checkedListBoxExtract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxExtract.CheckOnClick = true;
            this.checkedListBoxExtract.FormattingEnabled = true;
            this.checkedListBoxExtract.Items.AddRange(new object[] {
            "Proposed Model",
            "8 Directional Model",
            "XOR Sub Model"});
            this.checkedListBoxExtract.Location = new System.Drawing.Point(447, 22);
            this.checkedListBoxExtract.Name = "checkedListBoxExtract";
            this.checkedListBoxExtract.Size = new System.Drawing.Size(135, 227);
            this.checkedListBoxExtract.TabIndex = 12;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(315, 221);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(97, 36);
            this.btnExtract.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnExtract.TabIndex = 11;
            this.btnExtract.Text = "Extract";
            this.btnExtract.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtExtract
            // 
            this.txtExtract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtExtract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtExtract.Location = new System.Drawing.Point(109, 22);
            this.txtExtract.Multiline = true;
            this.txtExtract.Name = "txtExtract";
            this.txtExtract.Size = new System.Drawing.Size(306, 193);
            this.txtExtract.TabIndex = 10;
            // 
            // btnLoadStego
            // 
            this.btnLoadStego.Location = new System.Drawing.Point(4, 110);
            this.btnLoadStego.Name = "btnLoadStego";
            this.btnLoadStego.Size = new System.Drawing.Size(97, 36);
            this.btnLoadStego.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLoadStego.TabIndex = 9;
            this.btnLoadStego.Text = "Load Stego Img";
            this.btnLoadStego.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLoadStego.Click += new System.EventHandler(this.btnLoadStego_Click);
            // 
            // pictureBoxStegoExtract
            // 
            this.pictureBoxStegoExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxStegoExtract.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxStegoExtract.Name = "pictureBoxStegoExtract";
            this.pictureBoxStegoExtract.Size = new System.Drawing.Size(97, 104);
            this.pictureBoxStegoExtract.TabIndex = 8;
            this.pictureBoxStegoExtract.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel2.Location = new System.Drawing.Point(220, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Extracting Panel";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer3.Panel2.Controls.Add(this.metroLabel4);
            this.splitContainer3.Size = new System.Drawing.Size(570, 562);
            this.splitContainer3.SplitterDistance = 273;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.metroLabel3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridViewImageQualityMatrics);
            this.splitContainer4.Size = new System.Drawing.Size(570, 273);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel3.Location = new System.Drawing.Point(214, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Image Quality Matrics";
            // 
            // dataGridViewImageQualityMatrics
            // 
            this.dataGridViewImageQualityMatrics.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewImageQualityMatrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImageQualityMatrics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.Payload,
            this.ImageSize,
            this.PSNR,
            this.MSE,
            this.RMSE});
            this.dataGridViewImageQualityMatrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImageQualityMatrics.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewImageQualityMatrics.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewImageQualityMatrics.Name = "dataGridViewImageQualityMatrics";
            this.dataGridViewImageQualityMatrics.Size = new System.Drawing.Size(570, 244);
            this.dataGridViewImageQualityMatrics.TabIndex = 5;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Payload
            // 
            this.Payload.HeaderText = "Payload";
            this.Payload.Name = "Payload";
            // 
            // ImageSize
            // 
            this.ImageSize.HeaderText = "ImageSize";
            this.ImageSize.Name = "ImageSize";
            // 
            // PSNR
            // 
            this.PSNR.HeaderText = "PSNR";
            this.PSNR.Name = "PSNR";
            // 
            // MSE
            // 
            this.MSE.HeaderText = "MSE";
            this.MSE.Name = "MSE";
            // 
            // RMSE
            // 
            this.RMSE.HeaderText = "RMSE";
            this.RMSE.Name = "RMSE";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel4.Location = new System.Drawing.Point(271, -1);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Notice";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1199, 642);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStegoExtract)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImageQualityMatrics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBoxSetgo;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private MetroFramework.Controls.MetroButton btnLoadCover;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnEmbed;
        private MetroFramework.Controls.MetroTextBox txtEmbed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxEmbed;
        private System.Windows.Forms.CheckedListBox checkedListBoxExtract;
        private MetroFramework.Controls.MetroButton btnExtract;
        private MetroFramework.Controls.MetroTextBox txtExtract;
        private MetroFramework.Controls.MetroButton btnLoadStego;
        private System.Windows.Forms.PictureBox pictureBoxStegoExtract;
        private System.Windows.Forms.DataGridView dataGridViewImageQualityMatrics;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payload;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSNR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMSE;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

