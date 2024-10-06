using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "10_200_3_1";
            int sum = 0;
            string str = "";
            for (int i = 0; i < data.Length; i++)
            {
                //char ch = data[i];
                if(data[i] != '_')
                {
                    str += data[i];
                }        
                else
                {
                    sum += int.Parse(str);
                    str = "";
                }
                if (i == data.Length - 1)
                {
                    sum += int.Parse(str);
                }

            }
            
            Console.WriteLine(sum);
        }
    }
}
