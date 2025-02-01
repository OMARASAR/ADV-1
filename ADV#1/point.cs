using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_1
{
    internal class point : IComparable
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

        //public int CompareTo(object? obj)
        //{
        //    point p = (point)obj;
        //    if (x == p.x) return y.CompareTo(p.y);
        //    return x.CompareTo(p.x);
        //}
        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        point p = (point)obj;
        //        if (x == p.x) return y.CompareTo(p.y);
        //        return x.CompareTo(p.x);

        //    }
        //    return 1;

        //}

        //public int CompareTo(object? obj)
        //{
        //    // is conditional operetor
        //    if (obj is not null)
        //    {
        //        if(obj is point p)
        //        {
        //            //point p = (point)obj;
        //            if (x == p.x) return y.CompareTo(p.y);
        //            return x.CompareTo(p.x);


        //        }

        //    }
        //    return 1;

        //}

        public int CompareTo(object? obj)
        {
            // as casting

            point p = obj as point;
            if (obj is not null)
            {
                if (x == p.x) return y.CompareTo(p.y);
                    return x.CompareTo(p.x);
            }


            return 1;

        }




    }
}
