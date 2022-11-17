using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todayCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            volums();
            Console.ReadKey();
        }
            
        private static void volums()
        {
            var service = new string[]
            {
                "Event-Assign", "Event-View", "Event-Assign", "Event-Accept", "Event-Delete",
                "Event-Assign", "Event-Accept", "Event-Delete", "Event-Delete", "Event-View",
                "Event-Assign", "Event-Accept", "Event-Delete", "Event-Assign"
            };
            var Cout = 0;
            for (int i = 0; i < service.Length; i++)
            {
               if(service[i].Equals("Event-View") && service[i + 1].Equals("Event-Assign") 
                  && service[i + 2].Equals("Event-Accept") && service[i + 3].Equals("Event-Delete"))
                {
                    Cout++;
                }
            }
            Console.WriteLine($"repeat array: {Cout}");
            var cout2 = 0;
            foreach (var Again in service )
            {
                if (Again.Equals("Event-Accept"))
                {
                    cout2++;
                }
            }
            Console.WriteLine($"repeat member {cout2}");

        }
        
    }
}
