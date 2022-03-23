using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMan
{
    public class test
    {


        //public void CalculateTwoNumbers(int a, int b)
        //{
        //    System.Console.WriteLine(a + b);
        //}

        //public void CalculateTwoNumbers(string a, string b)
        //{
        //    var numA = Convert.ToInt32(a);
        //    var numN = Convert.ToInt32(b);
        //    CalculateTwoNumbers(numA, numN);
        //}
    }

    public class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; } = "Animal Sound";


        public virtual void MakeSound()
        {
            System.Console.WriteLine(Sound);
        }
    }

    public class Cat : Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Voff");
        }
        //public override void MakeSound()
        //{
        //    base.MakeSound();
        //}
    }
}
