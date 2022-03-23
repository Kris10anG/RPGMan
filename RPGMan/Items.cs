using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    internal class Items
    {
        public string Name { get; set; }
        public string Rarity { get; set; } 
        public int Quantity { get; set; }

        public Items(string name, string rarity, int quantity)
        {
            Name = name;
            Rarity = rarity;
            Quantity = quantity;    
        }
    }
}
