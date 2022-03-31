using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    public abstract class Character
    {
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Atk { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int MaxAtk { get; set; }
        public List<Item> Inventory { get; set; }
        protected Random Random { get; set; }

        public Character(string name, int health, int mana, int atk)
        {
            Name = name;
            MaxMana = mana;
            Health = MaxHealth = health;
            Mana = MaxMana = mana;
            Atk = MaxAtk = atk;
            Random = new Random();
            IsAlive = true;
        }

        public abstract void Attack(Character opponent);

        public Item DropLoot()
        {
            return Inventory[Random.Next(0, Inventory.Count)];
        }

        public void LoseHealth(int atk)
        {
            if (Health - atk <= 0)
            {
                IsAlive = false;
                Console.WriteLine(Name + " Died because he has " + Health + " left" );
                return;
            }

            if (Mana == 0)
            {
                Console.WriteLine($"{Name} missed..");
            }
            else Health -= atk;
        }
    }
}
