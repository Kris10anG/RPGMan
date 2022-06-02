using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{   
    public class HealthPotion : Item
    {
        private int HealingEffect { get; set; }
        public HealthPotion(int lvl) : base("HealthPotion", lvl)
        {
            HealingEffect = lvl * 40;
        }


        public override void Use(Character character)
        {
            character.Health += HealingEffect;
            System.Console.WriteLine(character.Name + "used a health-potion and restored " + HealingEffect + "in health");
        }
    }
}
