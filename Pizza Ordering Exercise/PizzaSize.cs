using Newtonsoft.Json;
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

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("freeIngridientCount")]
        public int FreeIngridientCount { get; set; }
    
    }
}
