using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l8_02
{
    public partial class FillingForm : Form
    {
        Rectangle square;
        Rectangle rectangle;
        Rectangle currentRectangle;
        Color currentColor;
        Brush currentBrush;

        public FillingForm()
        {
            InitializeComponent();
            square = new Rectangle(panel1.Width / 4, panel1.Height / 4, panel1.Width / 2, panel1.Height / 2);
            rectangle = square;
            rectangle.X = panel1.Width / 6;
            rectangle.Width = panel1.Width * 2 / 3;
            currentColor = Color.Orange;
            currentBrush = new SolidBrush(currentColor);

            openFileDialog1.Filter = "BMP Files | *.bmp";
            openFileDialog1.DefaultExt = "bmp";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1)
            {
                switch ((string)comboBox1.SelectedItem)
                {
                    case "Круг":
                        currentRectangle = square;
                        g.DrawEllipse(Pens.Black, currentRectangle);
                        g.FillEllipse(currentBrush, currentRectangle);
                        break;

                    case "Эллипс":
                        currentRectangle = rectangle;
                        g.DrawEllipse(Pens.Black, currentRectangle);
                        g.FillEllipse(currentBrush, currentRectangle);
                        break;

                    case "Сектор":
                        currentRectangle = square;
                        g.DrawPie(Pens.Black, currentRectangle, 100, 160);
                        g.FillPie(currentBrush, currentRectangle, 100, 160);
                        break;

                    case "Треугольник":
                        currentRectangle = rectangle;
                        PointF[] triangle = new PointF[]
                        {
                        new PointF(currentRectangle.X, currentRectangle.Y),
                        new PointF(currentRectangle.X + currentRectangle.Width / 2, currentRectangle.Y + currentRectangle.Height),
                        new PointF(currentRectangle.X + currentRectangle.Width, currentRectangle.Y)
                        };
                        g.DrawPolygon(Pens.Black, triangle);
                        g.FillPolygon(currentBrush, triangle);
                        break;

                    case "Прямоугольник":
                        currentRectangle = rectangle;
                        g.DrawRectangle(Pens.Black, currentRectangle);
                        g.FillRectangle(currentBrush, currentRectangle);
                        break;

                    case "Многоугольник":
                        currentRectangle = square;
                        PointF[] polygon = new PointF[]
                        {
                        new PointF(currentRectangle.X, currentRectangle.Y + currentRectangle.Height / 3),
                        new PointF(currentRectangle.X + currentRectangle.Width / 3, currentRectangle.Y),
                        new PointF(currentRectangle.X + currentRectangle.Width * 2 / 3, currentRectangle.Y),
                        new PointF(currentRectangle.X + currentRectangle.Width, currentRectangle.Y + currentRectangle.Height / 3),
                        new PointF(currentRectangle.X + currentRectangle.Width, currentRectangle.Y + currentRectangle.Height * 2 / 3),
                        new PointF(currentRectangle.X + currentRectangle.Width * 2 / 3, currentRectangle.Y + currentRectangle.Height),
                        new PointF(currentRectangle.X + currentRectangle.Width / 3, currentRectangle.Y + currentRectangle.Height),
                        new PointF(currentRectangle.X, currentRectangle.Y + currentRectangle.Height * 2 / 3)
                        };
                        g.DrawPolygon(Pens.Black, polygon);
                        g.FillPolygon(currentBrush, polygon);
                        break;
                }
            }

            g.Dispose();
        }

        // Изменение цвета заливки
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
            }

            ProcessBrushes();
            panel1.Refresh();
        }

        // Кисти
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessBrushes();
            panel1.Refresh();
        }

        private void ProcessBrushes()
        {
            if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1)
            switch ((string)comboBox2.SelectedItem)
            {
                case "Сплошная заливка":
                    currentBrush = new SolidBrush(currentColor);
                    break;

                case "Текстура":
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Image image = Image.FromFile(openFileDialog1.FileName);
                        currentBrush = new TextureBrush(image);
                    }
                    else comboBox2.SelectedIndex = 0;
                    break;

                case "Штриховка":
                    Color forecolor = Color.FromArgb(currentColor.ToArgb() ^ 0xffffff);
                    currentBrush = new HatchBrush(HatchStyle.Cross, forecolor, currentColor);
                    break;

                case "Градиент":
                    Color endcolor = Color.FromArgb(currentColor.ToArgb() ^ 0xffffff);
                    currentBrush = new LinearGradientBrush(currentRectangle, currentColor, endcolor, LinearGradientMode.Horizontal);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
            ProcessBrushes();
            panel1.Refresh();
        }
    }
}
