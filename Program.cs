using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("Problem 2: The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Problem 3: Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 11111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Problem 4: Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2, 1, 21 };
            computeFrequency(arr);

            Console.WriteLine("Please press any key to close the Console Window");
            Console.ReadKey();

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            List<int> prime = new List<int>();
            if (y < x)
            {
                Console.WriteLine("Problem 1 Exception: Please make sure that 'b' is greater or equal to 'a'");
                return;
            }
            try
            {
                x = Convert.ToInt32(x);
                y = Convert.ToInt32(y);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
            for (int i = x; i <= y; i++)
            {
                if (isPrime(i))
                {
                    prime.Add(i);
                }
            }
            if (prime.Count > 0)
            {
                Console.WriteLine("Problem 1: Prime numbers in the range provided are " + String.Join(", ", prime));
                Debug.WriteLine("Problem 1: Prime numbers in the range provided are " + String.Join(", ", prime));
            }
            else
            {
                Console.WriteLine("Problem 1: There are no prime numbers in the range provided");
                Debug.WriteLine("Problem 1: There are no prime numbers in the range provided");
            }
        }
        // Method to check whether a specific number a prime or not
        private static bool isPrime(int i)
        {
            if (i < 0 || i == 0 || i == 1)
            {
                return false;
            }
            else
            {
                for (int a = 2; a <= (int)Math.Floor(Math.Sqrt(i)); a++)
                {
                    if (i % a == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            throw new NotImplementedException();
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                // Write your code here
                double result = 0;
                for (int i = 1; i <= n; i++)
                {
                    result = result + Math.Pow(-1, i + 1) * factorial(i) / (i + 1);
                }
                Debug.WriteLine("Problem 2: The series result is " + Math.Round(result, 3));
                return Math.Round(result, 3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }
        // Method to calculate a factorial of n
        private static double factorial(int n)
        {
            double fact_result = 1;
            for (int i = 1; i <= n; i++)
            {
                fact_result = fact_result * i;
            }
            return fact_result;
            throw new NotImplementedException();
        }

        public static long decimalToBinary(long n)
        {
            try
            {
                // Write your code here
                decimal r;
                string result = string.Empty;
                if (n == 0)
                {
                    result = n.ToString();
                }
                else
                {
                    while (n > 0)
                    {
                        r = n % 2;
                        n /= 2;
                        result = r.ToString() + result;
                    }
                }
                Debug.WriteLine("Problem 3: Binary conversion of the decimal number is: " + result);
                return Convert.ToInt64(result);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
                // Write your code here
                string str = n.ToString();
                int length = str.Length;
                long result = 0;
                for (int i = 1; i <= length; i++)
                {
                    int power = length - i;
                    if (power == 0)
                    {
                        result += 1;
                    }
                    else
                    {
                        result += Convert.ToInt64(Math.Pow(2, power) * Convert.ToInt64(str.Substring(i, 1)));
                    }
                }
                Debug.WriteLine("Problem 4: Decimal conversion of the binary number is: " + result);
                return Convert.ToInt64(result);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
                if (n <= 0)
                {
                    Console.WriteLine("Problem 4: Please provide a positive Integer number");
                }
                else
                {
                    Console.WriteLine("Problem 4: This is your triangle:");
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine(new string(' ', (5 - i)) + new string('*', (2 * i - 1)));
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                // Write your code here
                int[] distinct = a.Distinct().ToArray();
                int length = distinct.Length;
                int count;
                Console.WriteLine("Problem 5: The answer is presented as 'element: frequency'");
                for (int i = 0; i < length; i++)
                {
                    count = a.Count(b => b == distinct[i]);
                    Console.WriteLine("{0}: {1}", distinct[i], count);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}