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
    public partial class PictureCrossingForm : Form
    {
        delegate void PictureMover();

        string lastPath;
        byte lawWatcher = 0;
        PictureMover MovePictures;

        internal enum Laws { Vertical, Horizontal, StrictDiagonal, SlightDiagonal }
        internal static List<Picture> Pictures = new List<Picture>(4);
        internal static int CanvasWidth { get; private set; }
        internal static int CanvasHeight { get; private set; }

        internal PictureCrossingForm()
        {
            InitializeComponent();
            CanvasHeight = canvas.Height;
            CanvasWidth = canvas.Width;
            deletePicture.Enabled = false;
        }

        private void loadPicture_Click(object sender, EventArgs e)
        {
            Options opt = new Options(lastPath, canvas);
            if (opt.ShowDialog() == DialogResult.OK)
            {
                deletePicture.Enabled = true;
                Laws law = (Laws)lawWatcher;
                ++lawWatcher;

                lastPath = opt.Path;
                Picture pic = new Picture(opt.Image, opt.Origin, opt.Name, law);
                Pictures.Add(pic);
                MovePictures += pic.Move;

                canvas.Refresh();
                wait.Start();
            };

            loadPicture.Enabled = (Pictures.Count < 4); ;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            info.Text = string.Empty;
            if (Pictures.Count > 0)
            {
                using (Graphics g = e.Graphics)
                {
                    foreach (Picture pic in Pictures)
                    {
                        g.DrawImage(pic.Image,pic.Origin);
                        string[] crossingSet = pic.Crossings.Split('|');
                        if (crossingSet.Length > 0)
                        {
                            for (int i = 0; i < crossingSet.Length; i++)
                                if (crossingSet[i] != string.Empty)
                                    info.Text += crossingSet[i] + '\n';
                        }
                    }
                }
            }
        }

        private void wait_Tick(object sender, EventArgs e)
        {
            MovePictures();
            canvas.Refresh();
        }

        private void deletePicture_Click(object sender, EventArgs e)
        {
            Pictures.RemoveAt(--lawWatcher);
            loadPicture.Enabled = true;
            deletePicture.Enabled = (Pictures.Count > 0);
        }
    }
}
