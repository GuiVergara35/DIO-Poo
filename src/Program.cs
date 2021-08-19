using System;
using src.Entities;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Aurum");
            Wizard mage = new Wizard("Argentia");

            Console.WriteLine(mage);

            mage.CastSpell(5);

            mage.LevelUp();

            Console.WriteLine(mage);
        }
    }
}
