using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l8_04
{
    public partial class Options : Form
    {
        const string mes = "Картинка выходит за пределы холста либо \nодно из полей пустое.";

        DoubleBufferPanel canvas;
        Image consideredImage;
        bool xProper = true;
        bool yProper = true;

        internal Image Image { get; private set; }
        internal string Path { get; private set; }
        internal Point Origin { get; private set; }
        internal new string Name { get; private set; }

        public Options(string lastPath, DoubleBufferPanel canvas)
        {
            InitializeComponent();
            tbPath.Text = lastPath ?? string.Empty;

            if (tbPath.Text != string.Empty)
            {
                okButton.Enabled = tbX.Enabled = tbY.Enabled = true;
                imageName.Text = tbPath.Text.Split('\\').Last();
                consideredImage = new Bitmap(tbPath.Text);
            }
            else
            {
                okButton.Enabled = tbX.Enabled = tbY.Enabled = false;
            }

            openFileDialog1.Filter = "JPEG Files|*.jpg|BMP Files|*.bmp|PNG Files|*.png";
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.FileName = string.Empty;
            this.canvas = canvas;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Path = tbPath.Text;
            Image = consideredImage;
            Name = imageName.Text;
            Origin = new Point(int.Parse(tbX.Text), int.Parse(tbY.Text));
        }

        private void tbX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)) e.Handled = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = openFileDialog1.FileName;
                consideredImage = Image.FromFile(openFileDialog1.FileName);
                imageName.Text = tbPath.Text.Split('\\').Last();
                sizeData.Text = $"ширина: {consideredImage.Width},  высота: {consideredImage.Height}";
                okButton.Enabled = tbX.Enabled = tbY.Enabled = (consideredImage.Width < canvas.Width && consideredImage.Height < canvas.Height);
            }
        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProcessText(int.Parse(tbY.Text), consideredImage.Height, canvas.Height, ref yProper);
            }
            catch
            {
                SetError();
            }
        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProcessText(int.Parse(tbX.Text), consideredImage.Width, canvas.Width, ref xProper);
            }
            catch
            {
                SetError();
            }
        }

        private void ProcessText(int parse, int imageProp, int canvasProp, ref bool acc)
        {
            if (parse + imageProp > canvasProp)
            {
                SetError();
                acc = false;
            }
            else acc = true;

            if (xProper && yProper)
            {
                additionalInfo.Text = string.Empty;
                okButton.Enabled = true;
            }
        }

        private void SetError()
        {
            additionalInfo.Text = mes;
            okButton.Enabled = false;
        }
    }
}
