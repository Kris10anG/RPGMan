using NUnit.Framework;
using RPGMan;

namespace RPGManTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfMethodDropLootReturnsSomething()
        {
            var character = new Boss("Hei", 20, 20, 20);

           var dropLoot = character.DropLoot();
            Assert.IsNotNull(dropLoot);
        }

        //public void LoseHealth(int atk)
        //{
        //    if (Health - atk <= 0)
        //    {
        //        IsAlive = false;
        //        Console.WriteLine(Name + " Died because he has " + Health + " left");
        //        return;
        //    }

        //    if (Mana == 0)
        //    {
        //        Console.WriteLine($"{Name} missed..");
        //    }
        //    else Health -= atk;
        //}
        [Test]
        public void TestLoseHealth()
        {
            var character = new Boss("Hei", 20, 20, 50);
            character.LoseHealth(20);
            var expectedValue = 0;
            var actual = character.Health;
            Assert.AreEqual(expectedValue, actual);
        }

        [Test]
        public void TestIfIsAliveIsFalseWhen0Hp()
        {
            var character = new Boss("Hei", 20, 20, 50);
            character.LoseHealth(20);
            Assert.IsFalse(character.IsAlive);
        }

        [Test]
        public void TestIfIsAliveIsFalseWhen0Hp()
        {
            var character = new Boss("Hei", 20, 20, 50);
            character.LoseHealth(20);
            Assert.IsFalse(character.IsAlive);
        }
    }
}