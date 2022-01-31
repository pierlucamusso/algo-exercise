using System;

namespace algo_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1");
            int res = Exercise1(1000);
            Console.WriteLine("Result for 1000 input" + res);
        }

        public static int Exercise1(int limit)
        {
            int result = 0;

            for (int x = 0; x < limit; x++)
            {
                if (x % 3 == 0 || x % 5 == 0)
                    result += x;
            }

            return result;
        }
    }
}
