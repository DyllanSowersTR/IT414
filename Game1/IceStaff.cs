// Dyllan Sowers

namespace Game1
{
    class IceStaff : IWeapon
    {
        private int damage;
        private int roundsParalyzed;

        public IceStaff()
        {
            roundsParalyzed = 2;
            damage = 5;
        }

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public int RoundsParalyzed
        {
            get
            {
                return roundsParalyzed;
            }
        }

        public void Use(IMonster monster)
        {
            monster.Health -= damage;
            monster.Paralyzed = true;
            monster.RoundsParalyzed = roundsParalyzed;
        }
    }
}
