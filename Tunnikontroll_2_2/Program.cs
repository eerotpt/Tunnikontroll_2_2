using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Taco Palenque", "1200 Main ST.");

            Tab tab = new Tab();

            tab.Add(7.99);
            tab.Add(6.55);
            tab.Add(2.345);

            foreach(var item in tab.Items)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();

            Receipt receipt = restaurant.GetReceipt(tab);

            Console.Write(receipt);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
