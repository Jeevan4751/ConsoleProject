using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning
{
    //Write a program that reads your age from the console and prints your age after 10 years.
    internal class Assignment7
    {
        public static void Main()
        {
            int age;
            Console.WriteLine("Enter your age ");
            age = int.Parse(Console.ReadLine());
            age = 10 + age;
            Console.WriteLine("your age after 10 years is:" + age);
        }
    }
}
