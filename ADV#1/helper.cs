using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_1
{
    internal static class helper
    {


        #region sorting Bubble sort
        public static void Bubblesort<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }

        #endregion



        #region Non Generic Bubblesort
        //public static void Bubblesort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length-i-1; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}

        #endregion



        #region /*Generic linear search*/
        //// /*Generic linear search*/
        public static int linearsearch<T>(T[] Arr, T value, IEqualityComparer<T> equalityComparer )
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equalityComparer.Equals(Arr[i], value)){
                        return i;
                    }
                       

                }

            }
            return -1;
        }

        #endregion


        #region NOn Generic linear search
        //public static int linearsearch(int[] Arr,int value)
        //{
        //    if(Arr?.Length > 0)
        //    {
        //        for(int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == value) return i;

        //        }

        //    }
        //    return -1;
        //}

        #endregion


        #region Generic SWAP
        public static void SWAP<T>(ref T x, ref T y)
        {

            T temp = x;
            x = y;
            y = temp;

        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach(T i in arr)
            {
                Console.WriteLine(i);
            }
        }

    #endregion

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
