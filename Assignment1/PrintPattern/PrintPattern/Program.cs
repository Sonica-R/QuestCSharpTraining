using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the rectangle");
            int height = int.Parse(Console.ReadLine());
            int length = 12;

            for (int i = 0; i < height; i++)
            {
                if ((i == 0) || (i == height - 1))
                {
                    Console.Write("*************");
                }
                for (int j = 0; j < length; j++)
                {
                    if (!((i == 0) || (i == height - 1)))
                    {
                        if ((j == 0) || (j == length - 1))
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
