using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new string[] { "one", "two", "three", "four", "five", "six", "seven" };
            //Console.Write("Enter the length of array : ");
            string[] input = new string[] { "One, 2, Three, 2" };

            var inpItems = input.Replace(" ", "").Split(',');

            for (int j = 0; j < arrNum.Length; j++)
            {
                Console.WriteLine(arrNum[j]);
            }

        }
    }
}
