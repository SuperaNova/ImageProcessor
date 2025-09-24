namespace ImageProcessor
{
    partial class ImageSubtractionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxFirst;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button btnLoadFirst;
        private System.Windows.Forms.Button btnLoadBackground;
        private System.Windows.Forms.Button btnWebcamFirst;
        private System.Windows.Forms.Button btnWebcamBackground;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxFirst = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.btnLoadFirst = new System.Windows.Forms.Button();
            this.btnLoadBackground = new System.Windows.Forms.Button();
            this.btnWebcamFirst = new System.Windows.Forms.Button();
            this.btnWebcamBackground = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFirst
            // 
            this.pictureBoxFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFirst.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFirst.Name = "pictureBoxFirst";
            this.pictureBoxFirst.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFirst.TabIndex = 0;
            this.pictureBoxFirst.TabStop = false;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBackground.Location = new System.Drawing.Point(328, 12);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackground.TabIndex = 1;
            this.pictureBoxBackground.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(644, 12);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResult.TabIndex = 2;
            this.pictureBoxResult.TabStop = false;
            // 
            // btnLoadFirst
            // 
            this.btnLoadFirst.Location = new System.Drawing.Point(12, 320);
            this.btnLoadFirst.Name = "btnLoadFirst";
            this.btnLoadFirst.Size = new System.Drawing.Size(140, 30);
            this.btnLoadFirst.TabIndex = 3;
            this.btnLoadFirst.Text = "Load Image";
            this.btnLoadFirst.Click += new System.EventHandler(this.btnLoadFirst_Click);
            // 
            // btnLoadBackground
            // 
            this.btnLoadBackground.Location = new System.Drawing.Point(328, 320);
            this.btnLoadBackground.Name = "btnLoadBackground";
            this.btnLoadBackground.Size = new System.Drawing.Size(140, 30);
            this.btnLoadBackground.TabIndex = 5;
            this.btnLoadBackground.Text = "Load Background";
            this.btnLoadBackground.Click += new System.EventHandler(this.btnLoadBackground_Click);
            // 
            // btnWebcamFirst
            // 
            this.btnWebcamFirst.Location = new System.Drawing.Point(172, 320);
            this.btnWebcamFirst.Name = "btnWebcamFirst";
            this.btnWebcamFirst.Size = new System.Drawing.Size(140, 30);
            this.btnWebcamFirst.TabIndex = 4;
            this.btnWebcamFirst.Text = "Webcam First Image";
            this.btnWebcamFirst.Click += new System.EventHandler(this.btnWebcamFirst_Click);
            // 
            // btnWebcamBackground
            // 
            this.btnWebcamBackground.Location = new System.Drawing.Point(488, 320);
            this.btnWebcamBackground.Name = "btnWebcamBackground";
            this.btnWebcamBackground.Size = new System.Drawing.Size(140, 30);
            this.btnWebcamBackground.TabIndex = 6;
            this.btnWebcamBackground.Text = "Webcam Background";
            this.btnWebcamBackground.Click += new System.EventHandler(this.btnWebcamBackground_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(644, 320);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(140, 30);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(804, 320);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(140, 30);
            this.btnSaveResult.TabIndex = 8;
            this.btnSaveResult.Text = "Save Result";
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // ImageSubtractionForm
            // 
            this.ClientSize = new System.Drawing.Size(960, 370);
            this.Controls.Add(this.pictureBoxFirst);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.btnLoadFirst);
            this.Controls.Add(this.btnWebcamFirst);
            this.Controls.Add(this.btnLoadBackground);
            this.Controls.Add(this.btnWebcamBackground);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnSaveResult);
            this.Name = "ImageSubtractionForm";
            this.Text = "Image Subtraction";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
