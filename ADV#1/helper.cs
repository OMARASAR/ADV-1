using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_1
{
    internal static class helper
    {
        public static void SWAP<T>(ref T x, ref T y)
        {

            T temp = x;
            x = y;
            y = temp;

        }


        #region nongeneric
        //public static void SWAP(ref int x, ref int y)
        //{

        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}

        //public static void SWAP(ref double x, ref double y)
        //{

        //    double temp = x;
        //    x = y;
        //    y = temp;

        //}
        //public static void SWAP(ref point x, ref point y)
        //{

        //    point temp = x;
        //    x = y;
        //    y = temp;

        //}

        #endregion



    }
}
