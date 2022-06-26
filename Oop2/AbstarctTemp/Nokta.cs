using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctTemp
{
    class Nokta
    {
        int x;
        int y;

        public Nokta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get=> x; set=> x = value; }
        public int Y { get=>y; set=>y=value; }

    }
}
