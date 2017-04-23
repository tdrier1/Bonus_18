using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Car CarInv = new Car();
            List<List<string>> carList = new List<List<string>>();


            Console.WriteLine("Welcome to the Grand Circus Motors Admin Console!");
            Console.Write("\nHow many cars do you want to enter? ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                List<string> sublist = new List<string>();
                Console.Write("\nMake of Car #{0}: ", i);
                CarInv.makeProp = Console.ReadLine();
                sublist.Add(CarInv.makeProp);

                Console.Write("\nModel of Car #{0}: ", i);
                CarInv.modelProp = Console.ReadLine();
                sublist.Add(CarInv.modelProp);

                Console.Write("\nYear of Car #{0}: ", i);
                CarInv.yearProp = Convert.ToInt32(Console.ReadLine());
                sublist.Add(CarInv.yearProp.ToString());

                Console.Write("\nPrice of Car#{0}: ", i);
                CarInv.priceProp = Convert.ToInt32(Console.ReadLine());
                sublist.Add(CarInv.priceProp.ToString());

                carList.Add(sublist);
            }

            Console.WriteLine("\nCurrent Inventory:");
            Console.WriteLine("--------------------");

            for (int f = 0; f < carList.Count; f++)
            {
                Console.WriteLine("\n");

                for (int p = 0; p <= 3; p++)
                {
                    Console.Write(carList[f][p]+ "\t\t");
                }
            }
            Console.WriteLine("\n");
        }
    }
}

