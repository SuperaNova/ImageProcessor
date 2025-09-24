using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                processedImage = (Bitmap)originalImage.Clone();
                pictureBoxOriginal.Image = originalImage;
                pictureBox.Image = processedImage;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                processedImage = (Bitmap)originalImage.Clone();
                pictureBox.Image = processedImage;
            }
        }

        private void btnGreyscale_Click(object sender, EventArgs e)
        {
            if (processedImage != null)
            {
                Bitmap bmp = (Bitmap)processedImage.Clone();
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);
                        int gray = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                        bmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }
                }
                processedImage = bmp;
                pictureBox.Image = processedImage;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (processedImage != null)
            {
                Bitmap bmp = (Bitmap)processedImage.Clone();
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);
                        bmp.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                    }
                }
                processedImage = bmp;
                pictureBox.Image = processedImage;
            }
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (processedImage != null)
            {
                int[] hist = new int[256];
                Bitmap bmp = (Bitmap)processedImage.Clone();
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);
                        int gray = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                        hist[gray]++;
                    }
                }
                Bitmap histImage = new Bitmap(256, 100);
                int max = hist.Max();
                for (int x = 0; x < 256; x++)
                {
                    int height = (int)(hist[x] * 100.0 / max);
                    for (int y = 99; y >= 100 - height; y--)
                    {
                        histImage.SetPixel(x, y, Color.Black);
                    }
                }
                pictureBox.Image = histImage;
            }
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            if (processedImage != null)
            {
                Bitmap bmp = (Bitmap)processedImage.Clone();
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);
                        int tr = (int)(0.393 * c.R + 0.769 * c.G + 0.189 * c.B);
                        int tg = (int)(0.349 * c.R + 0.686 * c.G + 0.168 * c.B);
                        int tb = (int)(0.272 * c.R + 0.534 * c.G + 0.131 * c.B);
                        tr = Math.Min(255, tr);
                        tg = Math.Min(255, tg);
                        tb = Math.Min(255, tb);
                        bmp.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                    }
                }
                processedImage = bmp;
                pictureBox.Image = processedImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (processedImage != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    processedImage.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnImageSubtraction_Click(object sender, EventArgs e)
        {
            var form = new ImageSubtractionForm();
            form.ShowDialog();
        }
    }
}
