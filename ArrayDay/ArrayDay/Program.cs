using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Today();
        }
        private static void Today()
        {
            //xuat tieng viet co dau
            Console.OutputEncoding = Encoding.UTF8;


            while (true)
            {
                Console.WriteLine("choose days of the week");
                string day = Console.ReadLine();

                switch (day)
                {
                    case "2":
                        Console.WriteLine("Thứ Hai");
                        break;
                    case "3":
                        Console.WriteLine("Thứ Ba");
                        break;
                    case "4":
                        Console.WriteLine("Thứ Tư");
                        break;
                    case "5":
                        Console.WriteLine("Thứ Năm");
                        break;
                    case "6":
                        Console.WriteLine("Thứ Sáu");
                        break;
                    case "7":
                        Console.WriteLine("Thứ Bay");
                        break;
                    case "8":
                        Console.WriteLine("Thứ CHủ Nhật");
                        break;

                    case "exit":

                        return;
                    default:
                        Console.WriteLine("fale!again");
                        break;
                }

            }



        }
    }
}
