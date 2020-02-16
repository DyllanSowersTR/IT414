// Dyllan Sowers

namespace Game1
{
    public interface IMonster
    {
        int Health { get; set; }
        int Level { get; }
        int FireDamage { get; set; }
        int Armour { get; set; }
        bool Paralyzed { get; set; }
        int RoundsParalyzed { get; set; }
        // This was made a void as C# < 8.0 does not allow defining a setter to a method in an interface
        void DamageReceived(int damage);
        bool Alive { get; set; }
        string ToString();

        void Attack(Player aPlayer);
        void Defend(Player aPlayer);
    }
}
