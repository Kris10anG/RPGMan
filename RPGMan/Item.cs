using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Lvl { get; set; }
       

        protected Item(string name, int lvl)
        {
            Name = name;
            Lvl = lvl;

        }

        public abstract void Use(Character character);

    }
}
