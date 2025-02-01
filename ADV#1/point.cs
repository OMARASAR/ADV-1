using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_1
{
    internal struct point
    {
        public int x { get; set; }
        public int y { get; set; }

        public point(int x , int y)
        {
            this.x = x;
            this.y = y;
        }


        public override string ToString()
        {
            return $"({x}, {y})";
        }




    }
}
