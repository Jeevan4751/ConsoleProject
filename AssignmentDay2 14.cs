//14.Write C# function to find biggest prime number in a given array.

//biggest gvn arry


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BiggestPrimeNo
    
    {
        static long MaxPrime(long num)
        {
            long CurrMaxPrime = -1;

            if (num % 2 == 0)
            {
                CurrMaxPrime = 2;
                while (num % 2 == 0)
                {
                    num = num / 2;
                }
            }

            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    CurrMaxPrime = i;
                    num = num / i;
                }
            }

            if (num > 2)
                CurrMaxPrime = num;

            return CurrMaxPrime;
        }

        public static void Main(string[] args)
        {
            long x, y, z;
            x = 42;
            y = 1092;
            z = 696;

            Console.WriteLine("Largest prime factor of " + x
                               + " is: " + MaxPrime(x));
            Console.WriteLine("Largest prime factor of " + y
                               + " is: " + MaxPrime(y));
            Console.WriteLine("Largest prime factor of " + z
                               + " is: " + MaxPrime(z));
        }
    }
}

