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
                graphics.FillRectangle(ReturnNewBrush(String.IsNullOrEmpty(_r) ? colorGradientColor : int.Parse(_r), String.IsNullOrEmpty(_g) ? colorGradientColor : int.Parse(_g), String.IsNullOrEmpty(_b) ? colorGradientColor : int.Parse(_b)), pixelLinePosition, 0, 85, 100);
                pixelLinePosition += 85;
                colorGradientColor += 60;
            }
            return bitmap;
        }


/*
            if (String.IsNullOrEmpty(_r))
            {
                if (String.IsNullOrEmpty(_r) & String.IsNullOrEmpty(_g) & String.IsNullOrEmpty(_b))
                {
                    // do black to white
                    while (pixelLinePosition <= 510)
                    {
                        graphics.FillRectangle(ReturnNewBrush(colorGradientColor, colorGradientColor, colorGradientColor), pixelLinePosition, 0, 85, 100);
                        pixelLinePosition += 85;
                        colorGradientColor += 60;
                    }
                }
                else if (String.IsNullOrEmpty(_g))
                {
                    // do red green stuff
                    while (pixelLinePosition <= 510)
                    {
                        graphics.FillRectangle(ReturnNewBrush(colorGradientColor, colorGradientColor, int.Parse(_b)), pixelLinePosition, 0, 85, 100);
                        pixelLinePosition += 85;
                        colorGradientColor += 60;
                    }
                }
                else if (String.IsNullOrEmpty(_b))
                {
                    // do red blue stuff
                    while (pixelLinePosition <= 510)
                    {
                        graphics.FillRectangle(ReturnNewBrush(colorGradientColor, int.Parse(_g), colorGradientColor), pixelLinePosition, 0, 85, 100);
                        pixelLinePosition += 85;
                        colorGradientColor += 60;
                    }
                }                          
                    // do red stuff
                while (pixelLinePosition <= 510)
                {
                    graphics.FillRectangle(ReturnNewBrush(colorGradientColor, int.Parse(_g), int.Parse(_b)), pixelLinePosition, 0, 85, 100);
                    pixelLinePosition += 85;
                    colorGradientColor += 60;
                }
            } else if (String.IsNullOrEmpty(_g))
            {
                if (String.IsNullOrEmpty(_b))
                {
                    // do green blue
                    while (pixelLinePosition <= 510)
                    {
                        graphics.FillRectangle(ReturnNewBrush(int.Parse(_r), colorGradientColor, colorGradientColor), pixelLinePosition, 0, 85, 100);
                        pixelLinePosition += 85;
                        colorGradientColor += 60;
                    }
                }
                // do green stuff
                while (pixelLinePosition <= 510)
                {
                    graphics.FillRectangle(ReturnNewBrush(int.Parse(_r), colorGradientColor, int.Parse(_b)), pixelLinePosition, 0, 85, 100);
                    pixelLinePosition += 85;
                    colorGradientColor += 60;
                }
            }
            else if (String.IsNullOrEmpty(_b))
            {
                // do blue stuff
                while (pixelLinePosition <= 510)
                {
                    graphics.FillRectangle(ReturnNewBrush(int.Parse(_r), int.Parse(_g), colorGradientColor), pixelLinePosition, 0, 85, 100);
                    pixelLinePosition += 85;
                    colorGradientColor += 60;
                }

            }
            // do whatever color they input
            while (pixelLinePosition <= 510)
            {
                graphics.FillRectangle(ReturnNewBrush(int.Parse(_r), int.Parse(_g), int.Parse(_b)), pixelLinePosition, 0, 85, 100);
                pixelLinePosition += 85;
                colorGradientColor += 60;
            }
            return bitmap;
        }
        
        private Graphics DrawBitmapGradient(Graphics graphics, int r, int g, int b)
        {
            var pixelLinePosition = 0;
            var colorGradientColor = 0;
            while (pixelLinePosition <= 510)
            {
                graphics.FillRectangle(ReturnNewBrush(r, g, b), pixelLinePosition, 0, 10, 100);
                pixelLinePosition += 10;
                colorGradientColor += 5;
            }
            return graphics;
        }
        */
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
