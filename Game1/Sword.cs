// Dyllan Sowers

namespace Game1
{
    public class Sword : IWeapon
    {
        private int damage;
        private int armourDamage;

        public Sword()
        {
            // 'this' not added per IDE recommendations on simplification
            armourDamage = 10;
            damage = 5;
        }

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public int ArmourDamage
        {
            get
            {
                return armourDamage;
            }
        }

        public void Use(IMonster monster)
        {
            monster.Armour -= ArmourDamage;
            monster.DamageReceived(damage);
        }
    }
}
