using System;
using System.Reflection;

namespace ADV_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SWAP 
            #region Generic EX01 : SWAP
            //int a = 4, b = 5;
            //Console.WriteLine($"a:{a}");
            //Console.WriteLine($"b:{b}");
            //Console.WriteLine("***********After swap *************");

            //helper.SWAP(ref a, ref b);
            //Console.WriteLine($"a:{a}");
            //Console.WriteLine($"b:{b}");

            //double k = 4.5, l = 5.2;
            //Console.WriteLine($"k:{k}");
            //Console.WriteLine($"l:{l}");
            //Console.WriteLine("***********After swap *************");

            //helper.SWAP(ref k, ref l);
            //Console.WriteLine($"a:{k}");
            //Console.WriteLine($"b:{l}");

            //point p01 = new point(1, 1);
            //point p02 = new point(2, 2);

            //Console.WriteLine($"p01:{p01}");
            //Console.WriteLine($"p02:{p02}");
            //Console.WriteLine("***********After swap *************");

            //helper.SWAP(ref p01, ref p02);
            //Console.WriteLine($"p01:{p01}");
            //Console.WriteLine($"p02:{p02}");

            #endregion


            #region Generic EX02 : linear search
            // linear search
            // 4 7 8 9 10 1 2 3 5 12 -1 -13 11
            //int[] Numbers = { 8, 7, 6, 1, 2, 3, 4, 5, 6, 12, -1, 13, 9 };

            ////int index =  helper.linearsearch(Numbers, 4);
            ////int index = helper.linearsearch(Numbers, 12);
            //int index = helper.linearsearch(Numbers, 66);


            //Console.WriteLine($"Index : {index}");



            //Employee E01 = new Employee() {id = 1 , name = "Ahmed" , salary =500000 , age=25};
            //Employee E02 = new Employee() { id = 2, name = "Mohamed", salary = 500000, age = 30 };
            //Employee E03 = new Employee() { id = 3, name = "Omar", salary = 500000, age = 24 };
            //Employee E04 = new Employee() { id = 4, name = "Zain", salary = 500000, age = 32 };

            //Employee[] employees = { E01, E02, E03, E04 };
            //int index = helper.linearsearch(employees, E01);
            //Console.WriteLine($"Index : {index}");

            #endregion



            #region MyRegion
            //Employee E01 = new Employee() { id = 1, name = "Ahmed", salary = 500000, age = 25 };
            //Employee E02 = new Employee() { id = 1, name = "Ahmed", salary = 500000, age = 25 };
            ////Employee E02 = new Employee() { id = 2, name = "Mohamed", salary = 500000, age = 30 };


            ////if (E01.Equals(E02))
            ////    Console.WriteLine("E01=E02");
            ////else
            ////    Console.WriteLine("E01!=E02");

            //if (E01==E02)
            //    Console.WriteLine("E01=E02");
            //else
            //    Console.WriteLine("E01!=E02");

            #endregion


            #region sorting Bubble sort
            // sorting Bubble sort
            //int[] Numbers = { 8, 7, 6, 1, 2, 3, 4, 5, 6, 12, -1, 13, 9 };

            //helper.PrintArray(Numbers);

            //Console.WriteLine("***********After sort *************");

            //helper.Bubblesort(Numbers);
            //helper.PrintArray(Numbers);

            //point[] points =
            //{
            //    new point(1,1),
            //    new point(3,3),
            //    new point(0,0),
            //    new point(4,4),
            //    new point(2,2),
            //    new point(5,5)
            //};
            //helper.Bubblesort(points);
            //helper.PrintArray(points);

            //Employee E01 = new Employee() { id = 1, name = "Ahmed", salary = 500000, age = 25 };
            //Employee E02 = new Employee() { id = 2, name = "Mohamed", salary = 500000, age = 30 };
            //Employee E03 = new Employee() { id = 3, name = "Omar", salary = 500000, age = 24 };
            //Employee E04 = new Employee() { id = 4, name = "Zain", salary = 500000, age = 32 };

            //Employee[] employees = { E01, E02, E03, E04 };
            //helper.PrintArray(employees);

            //helper.Bubblesort(employees);

            //helper.PrintArray(employees);

            #endregion

            #region is & as
            //point[] points =
            //{
            //    new point(1,1),
            //    new point(3,3),
            //    new point(0,0),
            //    new point(4,4),
            //    new point(2,2),
            //    new point(5,5)
            //};
            //helper.PrintArray(points);

            //helper.Bubblesort(points);
            //helper.PrintArray(points);

            //point p01 = new point(1, 1);
            //point p02 = new point(2, 2);
            //if (p01.CompareTo(p02) > 0)
            //    Console.WriteLine("p01 is Greater than p02");
            //else
            //    Console.WriteLine("p01 is not Greater than p02");

            #endregion

            #region genetic ico
            //Employee E01 = new Employee() { id = 1, name = "Ahmed", salary = 500000, age = 25 };
            //Employee E02 = new Employee() { id = 2, name = "Mohamed", salary = 500000, age = 30 };
            //Employee E03 = new Employee() { id = 3, name = "Omar", salary = 500000, age = 24 };
            //Employee E04 = new Employee() { id = 4, name = "Zain", salary = 500000, age = 32 };

            //Employee[] employees = { E01, E02, E03, E04 };
            //helper.PrintArray(employees);

            //helper.Bubblesort(employees);

            //helper.PrintArray(employees);

            #endregion













        }
    }
}
