using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppdemo
{
    internal class print_small_number
    {
        public static int smallnumber(int num1,int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
                return num2;
        }

       public static void Main(string[] args)
        {
            int num1;
            int num2;
            int minnum;
            Console.WriteLine("Number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            num2 = int.Parse(Console.ReadLine());
            minnum = smallnumber(num1, num2);
            Console.WriteLine($"Minimum number is {minnum}");

        }
    }
}
