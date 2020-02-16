// Dyllan Sowers

namespace Game1
{
    public class Fist : IWeapon
    {
        private int damage;
        private int tonsOfDamage;

        public Fist()
        {
            tonsOfDamage = 50;
            damage = 3;
        }

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public int TonsOfDamage
        {
            get
            {
                return tonsOfDamage;
            }
        }

        public void Use(IMonster monster)
        {
            monster.Armour -= tonsOfDamage;
            monster.DamageReceived(damage);
        }
    }
}
