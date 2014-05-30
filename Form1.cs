using System;
using System.Windows.Forms;

namespace ColorThemePreviewer
{
    public partial class ColorThemePreviewer : Form
    {
        public ColorThemePreviewer()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            var bp = new BitmapParser(RedValueBox.Text, GreenValueBox.Text, BlueValueBox.Text);
            bp.DisplayColorGradient(ColorThemeGradientOutput);
        }

        private void BlueValueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GreenValueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RedValueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ColorThemeGradientOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
