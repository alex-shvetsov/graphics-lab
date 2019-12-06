using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Law = l8_04.PictureCrossingForm.Laws;

namespace l8_04
{
    class Picture
    {
        Image image;
        Point origin;
        string name;
        string crossings;
        Law law;

        int width = PictureCrossingForm.CanvasWidth;
        int height = PictureCrossingForm.CanvasHeight;
        int stepX = 2;
        int stepY = 2;

        internal Image Image => image;
        internal Point Origin => origin;
        internal string Crossings => crossings;

        internal Picture(Image image, Point origin, string name, Law law)
        {
            this.image = image;
            this.origin = origin;
            this.name = name;
            this.law = law;
            crossings = CheckForCrossing();
        }

        internal void Move()
        {
            switch (law)
            {
                case Law.Horizontal:
                    origin.X += stepX;
                    if (origin.X + image.Width > PictureCrossingForm.CanvasWidth || origin.X < 0) stepX = -stepX;
                    break;

                case Law.Vertical:
                    origin.Y += stepY;
                    if (origin.Y + image.Height > PictureCrossingForm.CanvasHeight || origin.Y < 0) stepY = -stepY;
                    break;

                case Law.SlightDiagonal:
                    origin.X += stepX;
                    if (origin.X + image.Width > PictureCrossingForm.CanvasWidth || origin.X < 0) stepX = -stepX;
                    if (origin.X % 3 == 0)
                    {
                        origin.Y += stepY;
                        if (origin.Y + image.Height > PictureCrossingForm.CanvasHeight || origin.Y < 0)
                            stepY = -stepY;
                    }
                    break;

                case Law.StrictDiagonal:
                    origin.X += stepX;
                    if (origin.X + image.Width > PictureCrossingForm.CanvasWidth || origin.X < 0) stepX = -stepX;
                    origin.Y += stepY;
                    if (origin.Y + image.Height > PictureCrossingForm.CanvasHeight || origin.Y < 0) stepY = -stepY;
                    break;
            }

            crossings = CheckForCrossing();
        }

        private string CheckForCrossing()
        {
            string crossInfo = string.Empty;
            foreach (Picture pic in PictureCrossingForm.Pictures)
            {
                if (pic != this &&
                   ((origin.Y >= pic.Origin.Y && 
                    origin.Y <= pic.origin.Y + pic.Image.Height) ||
                    origin.Y + image.Height >= pic.Origin.Y &&
                    origin.Y + image.Height <= pic.Origin.Y + pic.Image.Height) &&
                    origin.X >= pic.Origin.X &&
                    origin.X <= pic.Origin.X + pic.Image.Width)
                {
                    crossInfo += $"Пересечение: {name}({PictureCrossingForm.Pictures.FindIndex(c => c == this) + 1}), {pic.name}({PictureCrossingForm.Pictures.FindIndex(c => c == pic) + 1})|";
                }
            }

            return crossInfo;
        }
    }
}
