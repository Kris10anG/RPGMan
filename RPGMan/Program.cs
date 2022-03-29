using System;
using System.Collections.Generic;

namespace RPGMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var boss = new Boss("Linus", 300, 0, 30); // this.atk = 30
            //var boss2 = new Boss("Linus", 300, 20, 130); // Atk = 130
            var hero = new Hero("Kris10an", 200, 40, 30);

            while (true)
            {
            hero.Attack(boss);
            boss.Attack(hero);
            }
            /*
             (BASE)Character
                    * HP, Mana, Atk, Inventory
                    Attack(); <-- Sjekke mana og la karakteren gjøre damage mtp dette.


                Hero : Character
                    Rest(); //når han rester kan han ha 50 prosent sjanse for å dukke unna et angrep

                Boss : Character
                    DropLoot(); //for hver gang han mister 100Health får Hero mulighet til å plukke opp items han dropper
                
                Inventory
                    * List<Item> Items ManaPotion, StrengthPotion og HealthPotion
             * ManaPotion gir 1000Mana
             * StrengtPotion øker styrken med 20Atk
             * HealthPotion gir 100Health
                
                Item
                    *Name,  
            */
        }
    }
}







//var animal = new Animal();
//animal.MakeSound();

//var myCat = new Cat();
//myCat.MakeSound();
//var test = new test();
//test.CalculateTwoNumbers(1, 2);

//System.Console.WriteLine("Enter first number");
//var userInputNum1 = Console.ReadLine();
//System.Console.WriteLine("Enter second number");
//var userInputNum2 = Console.ReadLine();

//test.CalculateTwoNumbers(userInputNum1, userInputNum2);