using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageProcessor
{
    public class ConvMatrix
    {
        public int TopLeft = 0, TopMid = 0, TopRight = 0;
        public int MidLeft = 0, Pixel = 1, MidRight = 0;
        public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
        public int Factor = 1;
        public int Offset = 0;

        public void SetAll(int nVal)
        {
            TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = 
                    BottomLeft = BottomMid = BottomRight = nVal;
        }

        public static bool Conv3x3(Bitmap b, ConvMatrix m)
        {
            if (0 == m.Factor) return false;

            Bitmap bSrc = (Bitmap)b.Clone();
            
            // Skip the border pixels
            for (int y = 1; y < b.Height - 1; y++)
            {
                for (int x = 1; x < b.Width - 1; x++)
                {
                    Color c00 = bSrc.GetPixel(x - 1, y - 1);
                    Color c01 = bSrc.GetPixel(x, y - 1);
                    Color c02 = bSrc.GetPixel(x + 1, y - 1);
                    Color c10 = bSrc.GetPixel(x - 1, y);
                    Color c11 = bSrc.GetPixel(x, y);
                    Color c12 = bSrc.GetPixel(x + 1, y);
                    Color c20 = bSrc.GetPixel(x - 1, y + 1);
                    Color c21 = bSrc.GetPixel(x, y + 1);
                    Color c22 = bSrc.GetPixel(x + 1, y + 1);

                    int r = (c00.R * m.TopLeft + c01.R * m.TopMid + c02.R * m.TopRight +
                            c10.R * m.MidLeft + c11.R * m.Pixel + c12.R * m.MidRight +
                            c20.R * m.BottomLeft + c21.R * m.BottomMid + c22.R * m.BottomRight) / m.Factor + m.Offset;

                    int g = (c00.G * m.TopLeft + c01.G * m.TopMid + c02.G * m.TopRight +
                            c10.G * m.MidLeft + c11.G * m.Pixel + c12.G * m.MidRight +
                            c20.G * m.BottomLeft + c21.G * m.BottomMid + c22.G * m.BottomRight) / m.Factor + m.Offset;

                    int b2 = (c00.B * m.TopLeft + c01.B * m.TopMid + c02.B * m.TopRight +
                             c10.B * m.MidLeft + c11.B * m.Pixel + c12.B * m.MidRight +
                             c20.B * m.BottomLeft + c21.B * m.BottomMid + c22.B * m.BottomRight) / m.Factor + m.Offset;

                    r = Math.Max(0, Math.Min(255, r));
                    g = Math.Max(0, Math.Min(255, g));
                    b2 = Math.Max(0, Math.Min(255, b2));

                    b.SetPixel(x, y, Color.FromArgb(r, g, b2));
                }
            }

            return true;
        }

        // Common filter matrices
        public static ConvMatrix Smooth(int weight = 1)
        {
            var m = new ConvMatrix();
            m.SetAll(1);
            m.Pixel = weight;
            m.Factor = weight + 8;
            return m;
        }

        public static ConvMatrix GaussianBlur()
        {
            var m = new ConvMatrix
            {
                TopLeft = 1, TopMid = 2, TopRight = 1,
                MidLeft = 2, Pixel = 4, MidRight = 2,
                BottomLeft = 1, BottomMid = 2, BottomRight = 1,
                Factor = 16
            };
            return m;
        }

        public static ConvMatrix Sharpen()
        {
            var m = new ConvMatrix
            {
                TopMid = -2,
                MidLeft = -2, Pixel = 11, MidRight = -2,
                BottomMid = -2,
                Factor = 3
            };
            return m;
        }

        public static ConvMatrix EdgeDetect()
        {
            var m = new ConvMatrix
            {
                TopLeft = -1, TopMid = -1, TopRight = -1,
                MidLeft = -1, Pixel = 8, MidRight = -1,
                BottomLeft = -1, BottomMid = -1, BottomRight = -1,
                Factor = 1
            };
            return m;
        }
    }
}