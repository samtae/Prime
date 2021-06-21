using System;                                //To use Console.WriteLine

namespace isPrime
{
    public class testPrime
    {
        public static bool isPrime(int n)
        {                       /* Handling Special case for 1 */
            if (n == 1 || n == 0)
            {
                return false;
            }

            for (int i = 2; i <= n / 2; i++)
            {                     /* Going to n/2 to eliminate redundancy */
                if (n % i == 0)
                {
                    return false;                                /* whenever a number is divisible by i, return false */
                }
            }
            return true;                                       /* Return true if number is not divisible by any numbers between 1 to n/2 */
        }
        /* Driver code */
        public static void Main()
        {   
            Console.Write("\n\nFunction : To check a number is prime or not :\n");

            Console.WriteLine("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (isPrime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
        }
    }
}

                                                    

 
