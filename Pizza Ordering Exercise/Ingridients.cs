using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Ordering_Exercise
{
    public class Ingridients
    {

        public Ingridients(string name,double price)
        {
            Name = name;
            Price = price;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }


        Ingridients()
        {

        }

    }
}
