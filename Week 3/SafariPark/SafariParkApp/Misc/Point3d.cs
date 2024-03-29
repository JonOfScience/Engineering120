﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp.Misc
{
    public struct Point3d
    {
        public int x, y, z;

        public Point3d(int x, int y, int z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int SumOfPoints()
        {
            return x + y + z;
        }
    }
}
