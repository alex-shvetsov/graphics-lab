using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8
{
    class Point3D
    {
        internal float X { get; set; }
        internal float Y { get; set; }
        internal float Z { get; set; }

        internal Point3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        internal Point3D()
        {
            X = Y = Z = 0;
        }
    }
}
