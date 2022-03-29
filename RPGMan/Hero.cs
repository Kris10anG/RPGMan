using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    internal class Hero : Character
    {
        private static Random _random = new Random();
        public Hero(string name, int health, int mana, int attack) : base(name, health, mana, attack)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Atk = attack;
            Items = new List<Items>();
        }

        public override void Attack(Character opponent)
        {
            //var drawNumber = _random.Next(0, 2);
            //var luckyNumber = 1;

            switch (Mana)
            {
                case >= 20:
                    opponent.Health -= Atk;
                    Mana -= 20;
                    Console.WriteLine(Name + " did " + Atk + "dmg to " + opponent.Name + " and has " + Health + "Health left");
                    opponent.LoseHealth(Atk);
                    Console.WriteLine(Name + " has " + Mana + "Mana left!");
                    break;
                case < 20:
                    Rest();
                    Console.WriteLine(Name + " is exhausted, he has to rest");
                    break;
            }

            RunPinata(opponent);
            //if (drawNumber == luckyNumber)
            //{
            //    var randomItem = opponent.DropLoot();
            //    Items.Add(randomItem);
            //    Console.WriteLine($"You're in luck, the PINATA dropped {randomItem.Name}");
            //}
        }

        public void RunPinata(Character opponent)
        {
            var drawNumber = _random.Next(0, 2);
            var luckyNumber = 1;
            if (drawNumber == luckyNumber)
            {
                var randomItem = opponent.DropLoot();
                Items.Add(randomItem);
                Console.WriteLine($"You're in luck, the PINATA dropped {randomItem.Name}");
            }
        }
        public void Rest()
        {
            Mana += MaxMana;
        }
    }
}
