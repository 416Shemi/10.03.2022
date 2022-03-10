using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry1 = { 2, -3, -4, -5 };
            int[] arry2 = arry1;
            Console.WriteLine(menfi(arry2));
            Console.ReadLine();
        }
        static int menfi(int[] arry)
        {
            int arry2;
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] < 0)
                {
                    arry2 = arry[i] * (-1);
                }
                else (arry[i] > 0)
                {
                    arry2 = arry[i] * 1;
                }
                arry2 = arry1;
            }
            return arry2 ;
           
        }
        
    }
}
