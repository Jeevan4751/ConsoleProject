using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning
{
    //Write a C# program to create a new string from a given string where the first and last characters will change their positions
    internal class Assignment5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("DotNet"));
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }

    }
}
