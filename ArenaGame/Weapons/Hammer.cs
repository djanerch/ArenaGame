using System;

namespace ArenaGame.Weapons
{
    public class Hammer : IWeapon
    {
        private Random random = new Random();
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Hammer(string name)
        {
            Name = name;
            AttackDamage = 45;
            BlockingPower = 4;
        }

        public double SpecialAbility()
        {
            if (random.Next(0, 100) < 25)
            {
                return AttackDamage * 1.5;
            }
            return 0;
        }
    }
}
