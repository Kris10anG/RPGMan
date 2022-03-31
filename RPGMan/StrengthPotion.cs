using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    internal class StrengthPotion : Item
    {
        private int StrengthEffekt { get; set; }
        public StrengthPotion(int lvl) : base("StrengthPotion", lvl)
        {
            StrengthEffekt = lvl * 10;
        }

        public override void Use(Character character)
        {
            character.Atk += StrengthEffekt;
            System.Console.WriteLine(character.Name + " used a strength-potion and gained " + StrengthEffekt + " in strength");
        }
    }
}
