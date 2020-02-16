// Dyllan Sowers

using System;

namespace Game1
{
    public class Giant : IMonster
    {
        private int health;
        private readonly int level;
        private int fireDamage;
        private int armour;
        private bool paralyzed;
        private int roundsParalyzed;
        private bool alive = true;

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    health = 0;
                    alive = false;
                }
                else
                {
                    health = value;
                }
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
        }

        public int FireDamage
        {
            get
            {
                return fireDamage;
            }
            set
            {
                fireDamage = value;
            }
        }

        public int Armour
        {
            get
            {
                return armour;
            }
            set
            {
                if (value < 0)
                {
                    armour = 0;
                }
                else
                {
                    armour = value;
                }
            }
        }

        public bool Paralyzed
        {
            get
            {
                return paralyzed;
            }
            set
            {
                paralyzed = value;
            }
        }
        public int RoundsParalyzed
        {
            get
            {
                return roundsParalyzed;
            }
            set
            {
                roundsParalyzed = value;
            }
        }

        public void DamageReceived(int damage)
        {
            // Use the Armour method so the restriction of armour >= 0 is applied (same for health)
            Armour -= damage;
            if (Armour == 0)
            {
                Health -= damage * 2;
            }
            else
            {
                Health -= damage;
            }
        }

        public bool Alive
        {
            get
            {
                return alive;
            }
            set
            {
                alive = value;
            }
        }

        public string ToString()
        {
            string stats = "Level " + level + " Giant. \nHealth: " + health + "\nArmour: " + armour;
            if (paralyzed)
                stats += "\nParalyzed for " + roundsParalyzed + " rounds";

            return stats;
        }

        public Giant(int health, int armour, int level)
        {
            this.health = health;
            this.level = level;
            this.armour = armour;
        }

        public void Attack(Player player)
        {
            Console.WriteLine("Giant Attacks: " + player.Name);
        }

        public void Defend(Player player)
        {
            Console.WriteLine("Giant defends from " + player.Name);
            player.Weapon.Use(this);
        }

    }
}
