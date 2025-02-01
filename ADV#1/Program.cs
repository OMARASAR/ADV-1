namespace ADV_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SWAP 
            int a = 4, b = 5;
            Console.WriteLine($"a:{a}");
            Console.WriteLine($"b:{b}");
            Console.WriteLine("***********After swap *************");

            helper.SWAP(ref a, ref b);
            Console.WriteLine($"a:{a}");
            Console.WriteLine($"b:{b}");

            double k = 4.5, l = 5.2;
            Console.WriteLine($"k:{k}");
            Console.WriteLine($"l:{l}");
            Console.WriteLine("***********After swap *************");

            helper.SWAP(ref k, ref l);
            Console.WriteLine($"a:{k}");
            Console.WriteLine($"b:{l}");

            point p01 = new point(1,1);
            point p02 = new point(2, 2);

            Console.WriteLine($"p01:{p01}");
            Console.WriteLine($"p02:{p02}");
            Console.WriteLine("***********After swap *************");

            helper.SWAP(ref p01, ref p02);
            Console.WriteLine($"p01:{p01}");
            Console.WriteLine($"p02:{p02}");








        }
    }
}
