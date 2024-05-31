using System;

namespace ArenaGame
{
    public class Berserker : Hero
    {
        public Berserker(string name, double armor, double strength, IWeapon weapon)
            : base(name, armor, strength, weapon)
        {
        }

        public override double Attack()
        {
            double basicAttackDamage = base.Attack();
            if (Weapon is ArenaGame.Weapons.Axe axe)
            {
                if (axe.SpecialAbility())
                {
                    Console.WriteLine($"{Name} has stunned the opponent!");
                }
            }
            return basicAttackDamage;
        }
    }
}
