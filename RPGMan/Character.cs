using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    internal class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }
        public int Attack { get; set; }
        public List<Items> items { get; set; }
    }
}
