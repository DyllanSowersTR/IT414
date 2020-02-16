// Dyllan Sowers

namespace Game1
{
    class FireStaff : IWeapon
    {
        private int damage;
        private int fireDamage;

        public FireStaff()
        {
            fireDamage = 15;
            damage = 5;
        }

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public int FireDamage
        {
            get
            {
                return fireDamage;
            }
        }

        public void Use(IMonster monster)
        {
            monster.Health -= Damage + FireDamage;
            monster.Armour -= FireDamage;
        }
    }
}
