using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ordering_Exercise
{
    public class PizzaSize
    { 

        public PizzaSize(string name, double price, int freeIngridientCount)
        {
            Name = name;
            Price = price;
            FreeIngridientCount = freeIngridientCount;
        }

        public string Name { get; set; }


        public double Price { get; set; }


        public int FreeIngridientCount { get; set; }
    
    }
}
