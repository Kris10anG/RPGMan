using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    internal class Boss : Character
    {
        private Random _random = new Random();

        public Boss(string name, int health, int mana, int attack) : base(name, health, mana, attack)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Atk = attack;
            Inventory = new List<Item>
            {
                new HealthPotion(3),
                new StrengthPotion(2),
                new StrengthPotion(2),
                new StrengthPotion(3),
            };
        }

        public override void Attack(Character opponent)
        {
            //var minDmg = Atk / 2;
            //var maxDmg = Atk * 2;
            var baseDamage = _random.Next(15, 35); // 30 - 15, 60
            Atk = baseDamage;
            opponent.LoseHealth(Atk);
            if (opponent.IsAlive)
            {
                Console.WriteLine(Name + " did " + Atk + "dmg to " + opponent.Name + " and has " + Health + "Health left");
            }
        }

    }
}
