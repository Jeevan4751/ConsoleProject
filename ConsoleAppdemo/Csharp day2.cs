using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppdemo
{
    internal class Csharp_day2function
    {
        public static int multiply(int num1,int num2,int num3)
        {
            return num1 * num2 * num3 ;
        }

             public static void Main()
        {
            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine($"the multiplication of three numbers are {result}");
        }

    }
}
