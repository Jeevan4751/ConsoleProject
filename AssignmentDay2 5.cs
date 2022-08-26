
//5.Write C# Program to Find Minimum and Maximum of Numbers

//min&max num

using System;
using System.Linq;
namespace ConsoleApp2;
  
      internal class MaxMin
      {
        static void Main()
        {
           int[] Arr = { 22, -15, -43, 0, 28, 485, 35 };
           Console.WriteLine("Maximum Element : " + Arr.Max());
           Console.WriteLine("Minimum Element : " + Arr.Min());
           Console.Read();
        }
      }
  