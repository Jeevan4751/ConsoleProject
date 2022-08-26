//13.Write C# function to find position of the first prime number in a given array. Use the above function to decide a number is prime or not.

//prime number


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PositionofPrimeNo
    
    {

        static readonly int limit = 1000000;
        static int[] position = new int[limit + 1];


        static void sieve()
        {

            position[0] = -1;
            position[1] = -1;
            int pos = 0;

            for (int i = 2; i <= limit; i++)
            {

                if (position[i] == 0)
                {

                    position[i] = ++pos;

                    for (int j = i * 2; j <= limit; j += i)
                        position[j] = -1;
                }
            }
        }


        public static void Main(String[] args)
        {
            sieve();
            int n = 173;
            Console.Write(position[n]);
        }
    }
}

