using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorThemePreviewer
{
    class BitmapParser
    {
        private readonly string _r, _g, _b;

        public BitmapParser(string r, string g, string b)
        {
            _r = r;
            _g = g;
            _b = b;
        }

        public Bitmap CreateColorGradientBitmap()
        {
            var bitmap = new Bitmap(510, 100);
            var graphics = Graphics.FromImage(bitmap);
            var pixelLinePosition = 0;
            var colorGradientColor = 0;

            while (pixelLinePosition <= 510)
            {
                graphics.FillRectangle(ReturnNewBrush(String.IsNullOrEmpty(_r) ? colorGradientColor : int.Parse(_r), 
                    String.IsNullOrEmpty(_g) ? colorGradientColor : int.Parse(_g), 
                    String.IsNullOrEmpty(_b) ? colorGradientColor : int.Parse(_b)), pixelLinePosition, 0, 85, 100);
                pixelLinePosition += 85;
                colorGradientColor += 60;
            }
            return bitmap;
        }

        public void DisplayColorGradient(PictureBox pb)
        {
            pb.Image = CreateColorGradientBitmap();
        }


        private static SolidBrush ReturnNewBrush(int r, int g, int b)
        {
            var temp = new SolidBrush(Color.FromArgb(255, Math.Min(r, 255), Math.Min(g, 255), Math.Min(b, 255)));
            return temp;
        }
    }
}
