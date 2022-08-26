//9.Write C# program to merge two sorted array

//merge two stored arry



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Mergesortedarray
    {        

   
        public static void Main()
        {
            int i = 0;
            int j = 0;

            int[] arr1 = new int[5] { 5, 6, 10, 30, 45 };

            int[] arr2 = new int[5] { 60, 66, 75, 89, 96 };

            int[] merged = new int[10];

            for (i = 0, j = 0; i < 5; i++)
            {
                merged[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                merged[j++] = arr2[i];
            }
            Console.WriteLine("Elements of merged array = ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
            }
            Console.WriteLine();
        }
    }
}

