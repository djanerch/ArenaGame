using System;

namespace ArenaGame.Weapons
{
    public class Bow : IWeapon
    {
        private Random random = new Random();
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 35;
            BlockingPower = 2;
        }

        public int SpecialAbility()
        {
            return random.Next(0, 100) < 10 ? 3 : 1;
        }
    }
}
