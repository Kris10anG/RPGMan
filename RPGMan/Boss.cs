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
            Items = new List<Items>
            {
                new("Worn leather shoe"),
                new("Health Potion"),
                new("Mana Potion"),
                new("Strength Potion")
            };
        }

        public override void Attack(Character opponent)
        {
            //var minDmg = Atk / 2;
            //var maxDmg = Atk * 2;
            var baseDamage = _random.Next(15, 35); // 30 - 15, 60
            Atk = baseDamage;
            opponent.Health -= Atk;
            Console.WriteLine(Name + " did " + Atk + "dmg to " + opponent.Name + " and has " + Health + "Health left");
        }

    }
}
