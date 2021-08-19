using System;

namespace src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name) : base(name)
        {
            Name = name;

        }
        public override void LevelUp()
        {
            Level += 1;
            HP += 15;
            MP += 5;
            Power += 5;
        }

        public void Attack(int armorclass)
        {
            Random rng = new Random();
            int dice = rng.Next(20);
            if (dice == 1)
                Console.WriteLine($"Knight {Name} rolls {dice} and critically misses!");
            if (dice < armorclass)
                Console.WriteLine($"Knight {Name} rolls {dice} and misses!");

            int dmg = Power + rng.Next(6);
            if (dice < 19)
                Console.WriteLine($"Knight {Name} rolls {dice} and hits for {dmg} damage.");

            Console.WriteLine($"Knight {Name} rolls {dice} and critically hits for {dmg * 2} damage!");


        }
    }
}
