using System;

namespace @params
{
    internal class Program
    {
        public static int Add(params int[] numbers)
        {
            int total = 0;
            foreach(int i in numbers)
            {
                total += i;
            }
            return total;
        }
        static void Main(string[] args)
        {
            int y = Add(1, 2, 3, 4, 5);
            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}

