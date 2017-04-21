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

            CarClass Cars = new CarClass();
            List<string> makelist = new List<string>();
            List<string> modellist = new List<string>();
            List<string> yearlist = new List<string>();
            List<string> pricelist = new List<string>();

            Console.WriteLine("Welcome to the Grand Circus Motors Admin Console!");
            Console.Write("\nHow many cars do you want to enter? ");
            int input = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<=input; i++)
            {
                Console.Write("\nMake: ");
                Cars.makeProp = Console.ReadLine();
                makelist.Add(Cars.makeProp);

                Console.Write("\nModel: ");
                Cars.makeProp = Console.ReadLine();
                modellist.Add(Cars.makeProp);

                Console.Write("\nYear: ");
                Cars.makeProp = Convert.ToString(Console.ReadLine());
                yearlist.Add(Cars.makeProp);

                Console.Write("\nPrice: ");
                Cars.makeProp = Convert.ToString(Console.ReadLine());
                pricelist.Add(Cars.makeProp);

            }

            Console.WriteLine("\nCurrent Inventory:");

            for (int f=0; f<makelist.Count; f++)
            {
                Console.WriteLine("\n"+ makelist[f] + "\t" + modellist[f] + "\t" + yearlist[f] + "\t" + pricelist[f]);
            }
            

        }
    }
}
