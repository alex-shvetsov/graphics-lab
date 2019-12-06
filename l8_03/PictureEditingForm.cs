using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l8_03
{
    public partial class PictureEditingForm : Form
    {
        Point rOld, lOld;
        Point rNew, lNew;
        Pen rPen, lPen;
        Graphics g;
        Image drawing;
        bool prohibitPainting = false;

        public PictureEditingForm()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "JPEG Files | *.jpg";
            saveFileDialog1.DefaultExt = "jpg";
            openFileDialog1.Filter = saveFileDialog1.Filter;
            openFileDialog1.DefaultExt = saveFileDialog1.DefaultExt;
            openFileDialog1.FileName = string.Empty;

            lPen = new Pen(panel1.BackColor, 2f);
            rPen = new Pen(panel2.BackColor, 2f);
            drawing = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(drawing);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, drawing.Width, drawing.Height);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            ToCanvas();
        }

        private void ToCanvas() => canvas.Image = drawing;

        private void color1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
                lPen.Color = colorDialog1.Color;
            }
        }

        private void color2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
                rPen.Color = colorDialog1.Color;
            }
        }

        private void saveBuffer_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(canvas.Image);
        }

        private void loadBuffer_Click(object sender, EventArgs e)
        {
            Image loadedImage = Clipboard.GetImage();
            if (loadedImage != null)
            {
                g.DrawImage(loadedImage, 0, 0);
            }
            loadedImage.Dispose();
            canvas.Refresh();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ToCanvas();
                    canvas.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка сохранения файла.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            try
            {
                prohibitPainting = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Image loadedImage = Image.FromFile(openFileDialog1.FileName);
                    g.DrawImage(loadedImage, 0, 0);
                    loadedImage.Dispose();
                }
                prohibitPaintingTimer.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки файла.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, drawing.Width, drawing.Height);
            ToCanvas();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lOld = e.Location;
            }

            if (e.Button == MouseButtons.Right)
            {
                rOld = e.Location;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!prohibitPainting)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lNew = e.Location;
                    g.DrawLine(lPen, lOld, lNew);
                    lOld = lNew;
                }

                if (e.Button == MouseButtons.Right)
                {
                    rNew = e.Location;
                    g.DrawLine(rPen, rOld, rNew);
                    rOld = rNew;
                }

                ToCanvas();
            }
        }

        private void prohibitPaintingTimer_Tick(object sender, EventArgs e)
        {
            prohibitPaintingTimer.Stop();
            prohibitPainting = false;
        }

        private void PictureEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
            rPen.Dispose();
            lPen.Dispose();
            drawing.Dispose();
        }
    }
}
