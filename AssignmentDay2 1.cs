//1.Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user
//Convert this program using a function //

//multi2num
using System;
namespace ConsoleApp2
{
    internal class Program
    {
        public static int mul_num(int a, int b, int c)
        {
            return a * b * c;
        }
        public static void Main()
        {
            int a, b, c;

            Console.Write("Input the first number to multiply: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            c = Convert.ToInt32(Console.ReadLine());

            int result = mul_num(a, b, c);
            Console.WriteLine($"the output is {result}");

        }
    }
}