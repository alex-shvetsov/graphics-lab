using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using System.Numerics;
using System.Linq;

namespace l8
{
    public partial class PyramidForm : Form
    {
        Pyramid pyramid;
        Pen figurePen = new Pen(Brushes.Black, 1.6f);
        Pen crossPen = new Pen(Brushes.Black, 2.0f);
        Graphics g;
        Bitmap space;
        float minX, maxX, minY, maxY;
        int autoResizeStep = 1;
        int translateXStep = -2;
        int translateYStep = 0;

        public PyramidForm()
        {
            InitializeComponent();
            space = new Bitmap(canvas.Width, canvas.Height);
            g = Graphics.FromImage(space);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float width = trackBarSize.Value;
            float height = trackBarSize.Value;
            pyramid = new Pyramid(width, height, canvas.Width, canvas.Height);
            Build();
        }

        private void InitCritical()
        {
            // Крайние точки 2D-фигуры
            minX = pyramid.Points2D.Min(c => c.X);
            maxX = pyramid.Points2D.Max(c => c.X);
            minY = pyramid.Points2D.Min(c => c.Y);
            maxY = pyramid.Points2D.Max(c => c.Y);
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            InitCritical();
            if (OutOfBounds())
            {
                Reverse();
            }
            else pyramid.Resize(trackBarSize.Value);
            Erase();
            Build();
            if (checkBoxShowCross.Checked) BuildCrossing();
        }

        private void autoTimer_Tick(object sender, EventArgs e)
        {
            if (checkBoxAutoMoving.Checked) Translate();
            if (checkBoxAutoResizing.Checked) Resize();
        }

        private void PyramidForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            g.Dispose();
            space.Dispose();
        }

        #region ОТОБРАЖЕНИЕ, ПЕРЕМЕЩЕНИЕ И ИЗМЕНЕНИЕ РАЗМЕРА
        private bool OutOfBounds() => !(maxX <= canvas.Width && minX >= 0 && maxY <= canvas.Height && minY >= 0);

        private void Build()
        {
            for (int i = 0; i < 3; i++)
                for (int j = i; j <= 3; j++)
                {
                    if (i == 0 && j == 1)
                        figurePen.DashStyle = DashStyle.Dash;
                    else figurePen.DashStyle = DashStyle.Solid;
                    g.DrawLine(figurePen, pyramid.Points2D[i], pyramid.Points2D[j]);
                }
            InitCritical();
            canvas.Image = space;
        }

        private void BuildCrossing()
        {
            crossPen.DashStyle = DashStyle.Solid;
            g.DrawLine(crossPen, pyramid.CrossSection[1], pyramid.CrossSection[2]);
            crossPen.DashStyle = DashStyle.Dash;
            g.DrawLine(crossPen, pyramid.CrossSection[0], pyramid.CrossSection[2]);
            g.FillPolygon(new SolidBrush(Color.FromArgb(128, Color.BlueViolet)), pyramid.CrossSection.ToArray());
            canvas.Image = space;
        }

        private void Erase()
        {
            g.Clear(BackColor);
            canvas.Image = space;
        }

        private void EraseCrossing()
        {
            Erase();
            Build();
        }

        private new void Resize()
        {
            try
            {
                InitCritical();
                if (!OutOfBounds())
                {
                    trackBarSize.Value += autoResizeStep;
                    pyramid.Resize(trackBarSize.Value);
                    Erase();
                    Build();

                    if (checkBoxShowCross.Checked)
                    {
                        EraseCrossing();
                        BuildCrossing();
                    }
                }
                else Reverse();
            }
            catch
            {
                autoResizeStep = -autoResizeStep;
            }
        }

        private void Reverse()
        {
            while (OutOfBounds())
            {
                InitCritical();

                if (maxX >= canvas.Width)
                {
                    translateXStep = 2;
                    translateYStep = 0;
                    radioButtonLeft.Checked = true;
                    pyramid.Translate(translateXStep, translateYStep);
                }
                else if (minX <= 0)
                {
                    translateXStep = -2;
                    translateYStep = 0;
                    radioButtonRight.Checked = true;
                    pyramid.Translate(translateXStep, translateYStep);
                }

                if (maxY >= canvas.Height)
                {
                    translateYStep = 2;
                    translateXStep = 0;
                    radioButtonUp.Checked = true;
                    pyramid.Translate(translateXStep, translateYStep);
                }
                else if (minY <= 0)
                {
                    translateYStep = -2;
                    translateXStep = 0;
                    radioButtonDown.Checked = true;
                    pyramid.Translate(translateXStep, translateYStep);
                }
            }
        }

        private void Translate()
        {
            InitCritical();
            if (OutOfBounds()) Reverse();
            else
            {
                pyramid.Translate(translateXStep, translateYStep);
                Erase();
                Build();

                if (checkBoxShowCross.Checked)
                {
                    EraseCrossing();
                    BuildCrossing();
                }
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Translate();
            }
        }
        #endregion

        #region ЧЕКБОКСЫ И КНОПКИ
        private void checkBoxShowFigure_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowFigure.Checked)
            {
                checkBoxAutoMoving.Enabled = true;
                checkBoxAutoResizing.Enabled = true;
                checkBoxAutoMoving.Enabled = true;
                checkBoxShowCross.Enabled = true;
                showFigureToolStripMenuItem.Checked = true;
                autoResizingToolStripMenuItem.Enabled = true;
                autoMovingToolStripMenuItem.Enabled = true;
                showCrossToolStripMenuItem.Enabled = true;
                if (checkBoxShowCross.Checked)
                {
                    BuildCrossing();

                }
                trackBarSize.Enabled = true;
                Build();
            }
            else
            {
                if (autoTimer.Enabled) autoTimer.Stop();
                checkBoxAutoMoving.Checked = false;
                checkBoxAutoResizing.Checked = false;
                checkBoxShowCross.Enabled = false;
                checkBoxAutoMoving.Enabled = false;
                checkBoxAutoResizing.Enabled = false;
                showFigureToolStripMenuItem.Checked = false;
                autoResizingToolStripMenuItem.Enabled = false;
                autoMovingToolStripMenuItem.Enabled = false;
                showCrossToolStripMenuItem.Enabled = false;
                trackBarSize.Enabled = false;
                Erase();
            }
        }

        private void checkBoxAutoMoving_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoMoving.Checked)
            {
                autoTimer.Start();
                autoMovingToolStripMenuItem.Checked = true;
            }
            else
            {
                if (!checkBoxAutoResizing.Checked) autoTimer.Stop();
                autoMovingToolStripMenuItem.Checked = false;
            }
        }

        private void checkBoxAutoResizing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoResizing.Checked)
            {
                autoTimer.Start();
                autoResizingToolStripMenuItem.Checked = true;
            }
            else
            {
                if (!checkBoxAutoMoving.Checked) autoTimer.Stop();
                autoResizingToolStripMenuItem.Checked = false;
            }
        }

        private void checkBoxShowCross_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowCross.Checked)
            {
                BuildCrossing();
                showCrossToolStripMenuItem.Checked = true;
            }
            else
            {
                EraseCrossing();
                showCrossToolStripMenuItem.Checked = false;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == radioButtonRight)
            {
                translateXStep = -2;
                translateYStep = 0;
                rightToolStripMenuItem.Checked = rb.Checked;
            }
            if (rb == radioButtonLeft)
            {
                translateXStep = 2;
                translateYStep = 0;
                leftToolStripMenuItem.Checked = rb.Checked;
            }
            if (rb == radioButtonUp)
            {
                translateYStep = 2;
                translateXStep = 0;
                upToolStripMenuItem.Checked = rb.Checked;
            }
            if (rb == radioButtonDown)
            {
                translateYStep = -2;
                translateXStep = 0;
                downToolStripMenuItem.Checked = rb.Checked;
            }
        }
        #endregion

        #region КОНТЕКСТНОЕ МЕНЮ
        private void showFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxShowFigure.Checked = !checkBoxShowFigure.Checked;
        }

        private void showCrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxShowCross.Checked = !checkBoxShowCross.Checked;
        }

        private void autoMovingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxAutoMoving.Checked = !checkBoxAutoMoving.Checked;
        }

        private void autoResizingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBoxAutoResizing.Checked = !checkBoxAutoResizing.Checked;
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            radioButtonUp.Checked = (tsmi == upToolStripMenuItem);
            radioButtonDown.Checked = (tsmi == downToolStripMenuItem);
            radioButtonLeft.Checked = (tsmi == leftToolStripMenuItem);
            radioButtonRight.Checked = (tsmi == rightToolStripMenuItem);
        }
        #endregion
    }
}
