using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai baos mang
            int[] number = { 2, 3, 1, 5, 4, 6, 8, 20, 14 };
           
            for ( int chiso = 0; chiso < number.Length; chiso++)
            {
                Console.WriteLine(number[chiso]);
            }

            int minx = int.MaxValue;
            FindMin(number,ref minx);
            
            Console.WriteLine("so phan tu nho nhat:" + minx);
            Console.ReadKey();


        }

        static void FindMin(int[] number, ref int minx )
        {
            for( int i = 0; i < number.Length; i ++)
            {
                if (number[i] < minx)
                {
                    minx = number[i];
                }
            }
        }

    }
}
