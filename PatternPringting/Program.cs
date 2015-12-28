using System;

namespace PatternPringting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n RightAngleTriangle");
            RightAngleTriangle();
            Console.WriteLine("\n MirrorRightAngleTriangle");
            MirrorRightAngleTriangle();

            Console.WriteLine("\n InvertedTriangle");
            InvertedTriangle();
            Console.WriteLine("\n Diamond of Stars\n");
            var n = 5;
            PrintDiamond(n);
            Console.WriteLine("\n Factorial\n");

            var ans = Factorial(n);
            Console.WriteLine("\n Factorial of 5 is {0}\n", ans);

            Console.WriteLine("\n Fibonaci Series\n");

            var fib = Fib(n);
            Console.WriteLine("\n Fibonaci of 5 is {0}\n", fib);
            Console.ReadLine();
        }
     
        private static void PrintDiamond(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                PrintDiamondRow(n, i);
                Console.WriteLine();
            }

            for (var i = n - 1; i >= 1; i--)
            {

                PrintDiamondRow(n, i);
                Console.WriteLine();
            }
        }

        private static void PrintDiamondRow(int n, int i)
        {
            for (var j = 0; j < (n - i); j++)
                Console.Write(" ");
            for (var j = 1; j <= i; j++)
                Console.Write("*");
            for (var k = 1; k < i; k++)
                Console.Write("*");
        }

        private static void InvertedTriangle()
        {
            var val = 5;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    //Console.Write(" ");
                }
               // j = val - i;
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        private static void RightAngleTriangle()
        {
            var val = 5;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                /*for (j = 1; j <= i; j++)
                {
                    Console.Write("");
                }*/
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        private static void MirrorRightAngleTriangle()
        {
            var val = 5;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        static decimal Factorial(int n)
        {
            // The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            return n * Factorial(n - 1);
        }

        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }



    }
}
