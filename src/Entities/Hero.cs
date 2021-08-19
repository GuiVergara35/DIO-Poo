namespace src.Entities
{
    public abstract class Hero
    {
        protected Hero(string name)
        {
            Name = name;
            Level = 1;
            HP = 10;
            MP = 10;
            Power = 5;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Power { get; set; }

        public override string ToString()
        {
            string hero = "";
            hero += $"Hero name: {Name} | Level: {Level} | HP: {HP} | MP: {MP}.";
            return hero;
        }

        public virtual void LevelUp()
        {
            Level += 1;
            HP += 10;
            MP += 5;
        }
    }
}
