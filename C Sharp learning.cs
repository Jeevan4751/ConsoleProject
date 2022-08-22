using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning
{
    internal class Assignment2
    {
        //Write a C# program that accepts and 2 numbers and prints the small no



        public static void Main(string[] args)
        {
            int num1;
            int num2;
            int minNum;
            Console.WriteLine("Number 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                minNum = num1;
            }
            else
            {
                minNum = num2;
            }
            Console.WriteLine("Minimum number is: " + minNum);

        }
    }
}    




