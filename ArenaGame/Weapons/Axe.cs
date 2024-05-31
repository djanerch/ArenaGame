using System;

namespace ArenaGame.Weapons
{
    public class Axe : IWeapon
    {
        private Random random = new Random();
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Axe(string name)
        {
            Name = name;
            AttackDamage = 50;
            BlockingPower = 3;
        }

        public bool SpecialAbility()
        {
            return random.Next(0, 100) < 15;
        }
    }
}
