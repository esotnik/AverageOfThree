using System;

namespace AverageOfThree
{
    class Program
    {
        // брать не среднее арифметическое, а медиану, то есть просто откинуть максимальную и минимальную оценки
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));
        }
        public static int MiddleOf(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                if (b >= c) return b;
                else return c;
            }
            else if (b >= a && b >= c)
            {
                if (a >= c) return a;
                else return c;
            }
            else
            {
                if (a >= b) return a;
                else return b;
            }
        }
    }
}
