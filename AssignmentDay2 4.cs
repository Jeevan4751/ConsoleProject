//4.Write a program that takes as input a number in 2011) and performs the following actions:
//– Prints on the console the number in reversed order: dcba(in our example 1102).
//– Puts the last digit in the first position: dabc(in our example 1201).
//– Exchanges the second and the third digits: acbd(in our example 2101)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PlayWithDigitsFunc
    {
        public static int sumofdigit(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int rem = number % 10;
                sum = sum + rem;
                number /= 10;
            }
            return sum;
        }

        public static int reversing(int number)
        {
            int reverse = 0, rem;
            while (number > 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }

            return reverse;
        }

        public static double swapFirstLast(int number)
        {
            int temp, last, first, count = 0;
            double swap;
            last = number % 10;
            count = (int)Math.Log10(number);
            first = (int)(number / Math.Pow(10, count));

            swap = last;
            swap *= (int)Math.Round(Math.Pow(10, count));
            swap += number % ((int)Math.Round(Math.Pow(10, count)));
            swap -= last;
            swap += first;

            return swap;
        }



        public static void Main()
        {
            int number, sum, rev;
            double FirstLast;
            Console.WriteLine("Enter a Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            sum = sumofdigit(number);
            Console.WriteLine($"Sum of digits is: {sum}");
            rev = reversing(number);
            Console.WriteLine($"After reversing digits we get: {rev}");
            FirstLast = swapFirstLast(number);
            Console.WriteLine($"After interchanging first and last digitss we get: {FirstLast}");
        }
    }
}