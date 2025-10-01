namespace ImageProcessor
{
    partial class Form1
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGreyscale = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnImageSubtraction = new System.Windows.Forms.Button();
            this.chkUseConvolution = new System.Windows.Forms.CheckBox();
            this.cmbConvolutionType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(9, 10);
            this.pictureBoxOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(300, 325);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(316, 10);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 325);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(630, 10);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 24);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(630, 42);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 24);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGreyscale
            // 
            this.btnGreyscale.Location = new System.Drawing.Point(630, 75);
            this.btnGreyscale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGreyscale.Name = "btnGreyscale";
            this.btnGreyscale.Size = new System.Drawing.Size(75, 24);
            this.btnGreyscale.TabIndex = 4;
            this.btnGreyscale.Text = "Greyscale";
            this.btnGreyscale.UseVisualStyleBackColor = true;
            this.btnGreyscale.Click += new System.EventHandler(this.btnGreyscale_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(630, 107);
            this.btnInvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(75, 24);
            this.btnInvert.TabIndex = 5;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(630, 140);
            this.btnHistogram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(75, 24);
            this.btnHistogram.TabIndex = 6;
            this.btnHistogram.Text = "Histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.Location = new System.Drawing.Point(630, 172);
            this.btnSepia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(75, 24);
            this.btnSepia.TabIndex = 7;
            this.btnSepia.Text = "Sepia";
            this.btnSepia.UseVisualStyleBackColor = true;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(630, 205);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImageSubtraction
            // 
            this.btnImageSubtraction.Location = new System.Drawing.Point(630, 237);
            this.btnImageSubtraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImageSubtraction.Name = "btnImageSubtraction";
            this.btnImageSubtraction.Size = new System.Drawing.Size(90, 24);
            this.btnImageSubtraction.TabIndex = 9;
            this.btnImageSubtraction.Text = "Image Subtraction";
            this.btnImageSubtraction.UseVisualStyleBackColor = true;
            this.btnImageSubtraction.Click += new System.EventHandler(this.btnImageSubtraction_Click);
            // 
            // chkUseConvolution
            // 
            this.chkUseConvolution.AutoSize = true;
            this.chkUseConvolution.Location = new System.Drawing.Point(620, 278);
            this.chkUseConvolution.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkUseConvolution.Name = "chkUseConvolution";
            this.chkUseConvolution.Size = new System.Drawing.Size(135, 17);
            this.chkUseConvolution.TabIndex = 10;
            this.chkUseConvolution.Text = "Use Convolution Matrix";
            this.chkUseConvolution.UseVisualStyleBackColor = true;
            // 
            // cmbConvolutionType
            // 
            this.cmbConvolutionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvolutionType.FormattingEnabled = true;
            this.cmbConvolutionType.Items.AddRange(new object[] {
            "None",
            "Smooth",
            "Gaussian Blur",
            "Sharpen",
            "Edge Detect"});
            this.cmbConvolutionType.Location = new System.Drawing.Point(628, 299);
            this.cmbConvolutionType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbConvolutionType.Name = "cmbConvolutionType";
            this.cmbConvolutionType.Size = new System.Drawing.Size(92, 21);
            this.cmbConvolutionType.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 351);
            this.Controls.Add(this.cmbConvolutionType);
            this.Controls.Add(this.chkUseConvolution);
            this.Controls.Add(this.btnImageSubtraction);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSepia);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnGreyscale);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Digital Image Processor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGreyscale;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Button btnSepia;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnImageSubtraction;
        private System.Windows.Forms.CheckBox chkUseConvolution;
        private System.Windows.Forms.ComboBox cmbConvolutionType;
    }
}

