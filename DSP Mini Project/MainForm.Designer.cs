namespace DSP_Mini_Project
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WavConverterPage = new System.Windows.Forms.TabPage();
            this.AnalyzePage = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenMP3Button = new System.Windows.Forms.Button();
            this.MP3FilePathLabel = new System.Windows.Forms.Label();
            this.SaveWAVButton = new System.Windows.Forms.Button();
            this.WAVFilePathLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.WavConverterPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.WavConverterPage);
            this.tabControl1.Controls.Add(this.AnalyzePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // WavConverterPage
            // 
            this.WavConverterPage.BackColor = System.Drawing.Color.White;
            this.WavConverterPage.Controls.Add(this.WAVFilePathLabel);
            this.WavConverterPage.Controls.Add(this.SaveWAVButton);
            this.WavConverterPage.Controls.Add(this.MP3FilePathLabel);
            this.WavConverterPage.Controls.Add(this.OpenMP3Button);
            this.WavConverterPage.Location = new System.Drawing.Point(4, 22);
            this.WavConverterPage.Name = "WavConverterPage";
            this.WavConverterPage.Padding = new System.Windows.Forms.Padding(3);
            this.WavConverterPage.Size = new System.Drawing.Size(776, 535);
            this.WavConverterPage.TabIndex = 0;
            this.WavConverterPage.Text = "Convert to WAV";
            // 
            // AnalyzePage
            // 
            this.AnalyzePage.BackColor = System.Drawing.Color.White;
            this.AnalyzePage.Location = new System.Drawing.Point(4, 22);
            this.AnalyzePage.Name = "AnalyzePage";
            this.AnalyzePage.Padding = new System.Windows.Forms.Padding(3);
            this.AnalyzePage.Size = new System.Drawing.Size(776, 535);
            this.AnalyzePage.TabIndex = 1;
            this.AnalyzePage.Text = "Analyze";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenMP3Button
            // 
            this.OpenMP3Button.BackColor = System.Drawing.Color.White;
            this.OpenMP3Button.Location = new System.Drawing.Point(149, 85);
            this.OpenMP3Button.Name = "OpenMP3Button";
            this.OpenMP3Button.Size = new System.Drawing.Size(95, 39);
            this.OpenMP3Button.TabIndex = 0;
            this.OpenMP3Button.Text = "Open MP3";
            this.OpenMP3Button.UseVisualStyleBackColor = false;
            this.OpenMP3Button.Click += new System.EventHandler(this.OpenMP3Button_Click);
            // 
            // MP3FilePathLabel
            // 
            this.MP3FilePathLabel.AutoSize = true;
            this.MP3FilePathLabel.Location = new System.Drawing.Point(276, 97);
            this.MP3FilePathLabel.Name = "MP3FilePathLabel";
            this.MP3FilePathLabel.Size = new System.Drawing.Size(0, 13);
            this.MP3FilePathLabel.TabIndex = 1;
            // 
            // SaveWAVButton
            // 
            this.SaveWAVButton.BackColor = System.Drawing.Color.White;
            this.SaveWAVButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveWAVButton.Location = new System.Drawing.Point(149, 156);
            this.SaveWAVButton.Name = "SaveWAVButton";
            this.SaveWAVButton.Size = new System.Drawing.Size(95, 38);
            this.SaveWAVButton.TabIndex = 2;
            this.SaveWAVButton.Text = "Save WAV";
            this.SaveWAVButton.UseVisualStyleBackColor = false;
            this.SaveWAVButton.Click += new System.EventHandler(this.SaveWAVButton_Click);
            // 
            // WAVFilePathLabel
            // 
            this.WAVFilePathLabel.AutoSize = true;
            this.WAVFilePathLabel.Location = new System.Drawing.Point(276, 169);
            this.WAVFilePathLabel.Name = "WAVFilePathLabel";
            this.WAVFilePathLabel.Size = new System.Drawing.Size(0, 13);
            this.WAVFilePathLabel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Cocktail Party Problem";
            this.tabControl1.ResumeLayout(false);
            this.WavConverterPage.ResumeLayout(false);
            this.WavConverterPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage WavConverterPage;
        private System.Windows.Forms.TabPage AnalyzePage;
        private System.Windows.Forms.Button OpenMP3Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label MP3FilePathLabel;
        private System.Windows.Forms.Button SaveWAVButton;
        private System.Windows.Forms.Label WAVFilePathLabel;
    }
}

