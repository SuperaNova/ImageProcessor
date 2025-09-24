using System;
using System.Drawing;
using System.Windows.Forms;
using WebCamLib;

namespace ImageProcessor
{
    public partial class ImageSubtractionForm : Form
    {
        private Bitmap firstImage;
        private Bitmap backgroundImage;
        private Bitmap resultImage;
        private Device webcamDevice;
        private int webcamTarget = 0; // 0: none, 1: first, 2: background

        public ImageSubtractionForm()
        {
            InitializeComponent();
        }

        private void btnLoadFirst_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                firstImage = new Bitmap(openFileDialog.FileName);
                pictureBoxFirst.Image = firstImage;
            }
        }

        private void btnLoadBackground_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundImage = new Bitmap(openFileDialog.FileName);
                pictureBoxBackground.Image = backgroundImage;
            }
        }

        private void btnWebcamFirst_Click(object sender, EventArgs e)
        {
            webcamTarget = 1;
            StartWebcamPreview(pictureBoxFirst);
        }

        private void btnWebcamBackground_Click(object sender, EventArgs e)
        {
            webcamTarget = 2;
            StartWebcamPreview(pictureBoxBackground);
        }

        private void StartWebcamPreview(PictureBox targetPictureBox)
        {
            var devices = DeviceManager.GetAllDevices();
            if (devices.Length > 0)
            {
                webcamDevice = devices[0]; // Use first available device
                webcamDevice.ShowWindow(targetPictureBox);
                // Add a button or double-click event to capture image from preview
                targetPictureBox.DoubleClick += (s, e) => CaptureWebcamImage(targetPictureBox);
            }
            else
            {
                MessageBox.Show("No webcam devices found.");
            }
        }

        private void CaptureWebcamImage(PictureBox targetPictureBox)
        {
            if (webcamDevice != null)
            {
                webcamDevice.Sendmessage(); // Copy frame to clipboard
                if (Clipboard.ContainsImage())
                {
                    Bitmap bmp = new Bitmap(Clipboard.GetImage());
                    if (webcamTarget == 1)
                    {
                        firstImage = bmp;
                        pictureBoxFirst.Image = firstImage;
                    }
                    else if (webcamTarget == 2)
                    {
                        backgroundImage = bmp;
                        pictureBoxBackground.Image = backgroundImage;
                    }
                    webcamDevice.Stop();
                }
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (firstImage != null && backgroundImage != null)
            {
                int width = Math.Min(firstImage.Width, backgroundImage.Width);
                int height = Math.Min(firstImage.Height, backgroundImage.Height);
                Color mygreen = Color.FromArgb(0, 255, 0);
                int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
                int threshold = 20;
                Bitmap result = new Bitmap(width, height);
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color c1 = firstImage.GetPixel(x, y);
                        Color c2 = backgroundImage.GetPixel(x, y);
                        int grey = (c1.R + c1.G + c1.B) / 3;
                        int sub = Math.Abs(grey - greygreen);
                        if (sub > threshold)
                        {
                            result.SetPixel(x, y, c1);
                        }
                        else
                        {
                            result.SetPixel(x, y, c2);
                        }
                    }
                }
                resultImage = result;
                pictureBoxResult.Image = resultImage;
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            if (resultImage != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    resultImage.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
