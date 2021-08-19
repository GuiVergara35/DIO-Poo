using System;

namespace src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
        }

        public override void LevelUp()
        {
            Level += 1;
            HP += 5;
            MP += 10;
            Power += 5;
        }

        public void CastSpell(int armorclass)
        {
            Random rng = new Random();
            int dice = rng.Next(20);
            if (dice == 1)
                Console.WriteLine($"Wizard {Name} rolls {dice} and critically misses!");
            if (dice < armorclass)
                Console.WriteLine($"Wizard {Name} rolls {dice} and misses!");

            int dmg = Power + rng.Next(6);
            if (dice < 19)
                Console.WriteLine($"Wizard {Name} rolls {dice} and hits for {dmg} damage.");
            else
                Console.WriteLine($"Wizard {Name} rolls {dice} and critically hits for {dmg * 2} damage!");


        }
    }
}
