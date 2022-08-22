using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Learning
{
    //Accept a string from the user and return count of words
    internal class Assignment4
    {
        public static void Main()
        {
            int a = 0, myWord = 1;
            string str = "Digital Engineer Trainee in Sonata Software Limited";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    myWord++;
                }
                a++;
            }
            Console.Write("Number of words in the string = {0}\n", myWord);
        }

    }

}
