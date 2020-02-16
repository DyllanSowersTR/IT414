// Dyllan Sowers

namespace Game1
{
    public interface IWeapon
    {
        int Damage { get; }

        void Use(IMonster monster);
    }
}
