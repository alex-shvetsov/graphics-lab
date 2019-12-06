using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace l8
{
    class Pyramid
    {
        Point3D origin, onaxis, elsewh, top, cross, center;
        List<PointF> crossPoints = new List<PointF>(3);
        List<PointF> points2D = new List<PointF>(5);
        
        float height;
        float width;
        float ratio = 1f;
        int clientHeight;
        int clientWidth;
        int xShift = 0, yShift = 0;

        internal List<PointF> CrossSection => crossPoints;
        internal List<PointF> Points2D => points2D;

        internal Pyramid(float width, float height, int canWidth, int canHeight)
        {
            this.width = width;
            this.height = height;
            this.clientWidth = canWidth;
            this.clientHeight = canHeight;

            origin = new Point3D();
            onaxis = new Point3D();
            elsewh = new Point3D();
            top = new Point3D();
            cross = new Point3D();
            center = new Point3D();

            SetPoints();
        }

        internal void Translate(int x, int y)
        {
            yShift += y;
            xShift += x;
            SetPoints();

        }

        internal void Resize(int ratio)
        {
            width = ratio;
            height = ratio;
            SetPoints();
        }

        void SetPoints()
        {
            points2D.Clear();
            crossPoints.Clear();

            center.X = width / (float)(2 * Math.Sqrt(3));
            center.Y = width / 2 + xShift;
            center.Z = height / 4 - yShift;

            origin.Y = -center.Y;
            origin.Z = yShift;
            onaxis.Y = width - center.Y;
            onaxis.Z = yShift;
            elsewh.Y = width / 2 - center.Y;
            elsewh.X = (float)(width * Math.Sqrt(3) / 2) - center.X;
            elsewh.Z = yShift;
            top.Y = width / 2 - center.Y;
            top.X = (float)(width * Math.Sqrt(3) / 4) - center.X;
            top.Z = height - center.Z;
            cross.X = width * width / (6 * height + 2 * width) - center.X;
            cross.Y = 3 * width * height / (3 * height + width) - center.Y;
            cross.Z = 3 * width * height / (6 * height + 2 * width) - center.Z;

            Point3D[] points3D = new Point3D[] { origin, onaxis, elsewh, top, cross };
            foreach (Point3D p in points3D)
            {
                float y = -p.Z * ratio + p.X * ratio / 2 + clientHeight / 2;
                float x = p.Y * ratio - p.X * ratio / 2 + clientWidth / 2;
                PointF p2d = new PointF(x, y);
                points2D.Add(p2d);
                if (p == origin || p == elsewh || p == cross)
                    crossPoints.Add(p2d);
            }
        }
    }
}
