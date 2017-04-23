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
            bool run = true;
            Car CarInv = new Car();
            List<List<string>> carList = new List<List<string>>();
            do
            {
                Console.WriteLine("Welcome to the Grand Circus Motors Admin Console!");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("\nHow many cars do you want to enter? ");
                int input = GetInt();

                CarInfo(input, CarInv, carList);

                PrintInv(carList);

                run = Continue();

            } while (run == true);
        }

        public static int GetInt()
        {
            int value;

            while (!Int32.TryParse(Console.ReadLine(), out value))
            {
                {
                    Console.WriteLine("\n");
                    Console.Write("Try again! Please enter an integer: ");
                }

            }
            return value;
        }

        public static void CarInfo(int input, Car CarInv, List<List<string>> carList)
        {
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
                CarInv.yearProp = GetIntWithinRange();
                sublist.Add(CarInv.yearProp.ToString());

                Console.Write("\nPrice of Car#{0} (in dollars): $", i);
                CarInv.priceProp = GetDblWithinRange();
                sublist.Add(CarInv.priceProp.ToString());

                carList.Add(sublist);
            }

                Console.Clear();
        }

        public static int GetIntWithinRange()
        {
            int Min = 1900;
            int Max = 2017; 
            int value;

            while (true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Please enter a valid input year:");
                }
                else if (value < Min || value > Max)
                {
                    Console.Write("Please enter a valid input year between {0} and {1}: ", Min, Max);
                }
                else
                {
                    break;
                }
            } 
         return value;
        }

        public static double GetDblWithinRange()
        {
            double Min = 0;
            double Max = 9999999.99;
            double value;

            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    
                        Console.Write("Please enter a dollar ammount: $");
                }
                else if (value < Min || value > Max)
                {
                        
                        Console.Write("Please enter a valid dollar amount between {0} and {1}: $");
                }
                else
                {
                    break;
                }
            }
            return value;
        }

        public static void PrintInv(List<List<string>> carList)
        {
            Console.WriteLine("\nCurrent Inventory:");
            Console.WriteLine("--------------------");

            for (int f = 0; f < carList.Count; f++)
            {
                Console.WriteLine("\n");

                for (int p = 0; p <= 3; p++)
                {
                    if(p == 3)
                    {
                        var convertDecimal = Convert.ToDecimal(carList[f][p]);
                        string moneyValue = String.Format("{0:C}", convertDecimal);
                        Console.Write(moneyValue + "\t\t");
                    }
                    else
                    {
                        Console.Write(carList[f][p] + "\t\t");
                    }
                    
                }
            }
            Console.WriteLine("\n");
        }

        public static bool Continue()
        {
            string conf;
            bool check = true;
            bool run = true;

            Console.WriteLine("\n================================================");
            Console.WriteLine("\nWould you like to add more cars to the database?");
            Console.Write("\nPlease Enter (y/n): ");

            do
            {
                conf = Console.ReadLine();
                var t = conf.ToLower();

                if (t != "y" || t != "n")
                {
                    Console.Write("\nPlease Enter (y/n): ");
                }
                if (t == "y")
                {
                    Console.Clear();
                    check = false;
                }
                if (t == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Grand Circus Motors admin console!\n");

                    run = false;
                    check = false;
                }
            } while (check == true);

            return run;
        }

    }
}

