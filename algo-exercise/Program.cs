using System;

namespace algo_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1");
            int res = Exercise1(1000);
            Console.WriteLine("Result for 1000 input " + res);

            Console.WriteLine("Exercise 2");
            res = Exercise2(4000000);
            Console.WriteLine("Result for 4000000 limit " + res);

            Console.WriteLine("Exercise 3");
            res = Exercise2(13195);
            Console.WriteLine("Result for 4000000 limit " + res);
        }

        /**
         https://projecteuler.net/archives
         */

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

        public static int Exercise2(int limit)
        {
            int pointer = 1;
            int lastSequenceNumber = 1;
            int evenSum = 0;

            while(lastSequenceNumber <= limit)
            {
                var tmp = lastSequenceNumber;
                lastSequenceNumber += pointer;
                pointer = tmp;

                if (lastSequenceNumber > limit)
                    break;

                if (lastSequenceNumber % 2 == 0)
                    evenSum += lastSequenceNumber;
            }

            return evenSum;
        }

        public static int Exercise3(int number)
        {
            int currentPrimeFactor = 2;

            while (!IsPrime(currentPrimeFactor))
            {
                if (number % currentPrimeFactor == 0)
                    number /= currentPrimeFactor;
            }

            return currentPrimeFactor;
        }

        public static bool IsPrime(int number)
        {
            int dividers = 0;
            int divisor = 1;

            while (dividers < 3 || divisor >= number / 2)
            {
                if (number % divisor == 0)
                    dividers++;

                divisor++;
            }

            return dividers <= 2;
        }

    }
}
