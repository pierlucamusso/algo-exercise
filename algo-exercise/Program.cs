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
            Console.WriteLine("Result for 13195 " + Exercise3(13195));
            Console.WriteLine("Result for 600851475143 " + Exercise3(600851475143));

            Console.WriteLine("Exercise 4");
            Console.WriteLine("Result for 10 " + Exercise4(10));
            Console.WriteLine("Result for 100 " + Exercise4(100));
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

        public static long Exercise3(long number)
        {
            long currentPrimeFactor = 2;
            long start_point = 1;
            long end_point = number;


            while (start_point != number)
            {
                if (end_point % currentPrimeFactor == 0)
                {
                    end_point /= currentPrimeFactor;
                    start_point *= currentPrimeFactor;
                }
                else
                {
                    while (end_point % currentPrimeFactor != 0 && !IsPrime(currentPrimeFactor))
                        currentPrimeFactor++;
                }
            }

            return currentPrimeFactor;
        }

        public static bool IsPrime(long number)
        {
            int dividers = 0;
            int divisor = 1;

            while (dividers < 3 || divisor >= number / 2)
            {
                if (number % divisor == 0 && (divisor == 1 || divisor == number))
                    dividers++;
                else
                    return false;
                divisor++;
            }

            return dividers == 2;
        }

        public static bool IsPrime_Beauty(long number)
        {
            for (long x = 2; x <= number / 2; x++)
            {
                if (number % x == 0)
                    return false;
            }

            return true;
        }

        public static long Exercise4(int limit)
        {
            long sum_of_squares = 0;
            long square_of_sum = 0;

            for (long x = 0; x <= limit; x++)
            {
                sum_of_squares += x * x;
                square_of_sum += x;
            }

            return (square_of_sum * square_of_sum) - sum_of_squares;
        }

    }
}
