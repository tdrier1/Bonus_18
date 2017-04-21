using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_18
{
    class CarClass
    {
        private string make;
        private string model;
        private int year;
        private double price;
    
        public CarClass()
        {
            make = "N/A";
            model = "N/A";
            year = 0;
            price = 0;
        }

        public CarClass(string makeinput, string modelinput, int yearinput, double priceinput)
        {
            make = makeinput;
            model = modelinput;
            year = yearinput;
            price = priceinput;
        }

        public string makeProp
        {
            set
            {
                make = value;
            }
            get
            {
                return make;
            }
        }
        public string modelProp
        {
            set
            {
                model = value;
            }
            get
            {
                return model;
            }
        }
        public int yearProp
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }
        public double priceProp
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
    }
}
