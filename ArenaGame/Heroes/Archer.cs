using System;

namespace ArenaGame
{
    public class Archer : Hero
    {
        public Archer(string name, double armor, double strength, IWeapon weapon)
            : base(name, armor, strength, weapon)
        {
        }

        public override double Attack()
        {
            double basicAttackDamage = base.Attack();
            if (Weapon is ArenaGame.Weapons.Bow bow)
            {
                int targetsHit = bow.SpecialAbility();
                return basicAttackDamage * targetsHit;
            }
            return basicAttackDamage;
        }
    }
}
