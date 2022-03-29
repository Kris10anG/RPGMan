using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Atk { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int MaxAtk { get; set; }
        public List<Items> Items { get; set; }
        protected Random Random { get; set; }

        public Character(string name, int health, int mana, int atk)
        {
            Name = name;
            MaxMana = mana;
            Health = MaxHealth = health;
            Mana = MaxMana = mana;
            Atk = MaxAtk = atk;
            Random = new Random();
        }

        public abstract void Attack(Character opponent);

        public Items DropLoot()
        {
            return Items[Random.Next(0, Items.Count)];
        }

        public void LoseHealth(int atk)
        {
            if (Mana == 0)
            {
                Console.WriteLine($"{Name} missed..");
            }
            else Health -= atk;
        }
    }
}
