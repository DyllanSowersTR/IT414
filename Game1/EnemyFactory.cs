using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    public class EnemyFactory
    {
        // class variables
        private int _areaLevel;
        private Stack<Zombie> _zombiesPool = new Stack<Zombie>();
        private Stack<WereWolf> _werewolvesPool = new Stack<WereWolf>();
        private Stack<Giant> _giantsPool = new Stack<Giant>();

        // gets and sets
        public int AreaLevel { get; set; }

        // constructor
        public EnemyFactory(int areaLevel)
        {
            _areaLevel = areaLevel;
            PreLoadZombies();

        }

        // ***********************************************************
        // The next two methods go together but could easily be made one method
        // It is only two methods because ** in theory ** the number of zombies
        // and how tough they are could be tweaked separately
        // You yourself can just use one method that does both things
        // ***********************************************************
        private void PreLoadZombies()
        {
            // this code would be unique to you and could be much simpler
            // this method GetZombieStatus just makes the zombies tougher
            // as the level goes up
            int count;
            int health;
            int armor;
            int level;

            if (_areaLevel < 3)
            {
                count = 15;
            }
            else if (_areaLevel >= 3 && _areaLevel < 10)
            {
                count = 50;
            }
            else
            {
                count = 200;
            }

            (health, level, armor) = GetZombieStatus(_areaLevel);

            for (int i = 0; i < count; i++)
            {
                _zombiesPool.Push(new Zombie(health, level, armor));
            }
        }

        private (int health, int level, int armor) GetZombieStatus(int areaLvl)
        {
            int health, armor, level;

            if (areaLvl < 3)
            {
                health = 100;
                level = 2;
                armor = 15;
            }
            else if (areaLvl >= 3 && areaLvl < 10)
            {
                health = 200;
                level = 5;
                armor = 15;
            }
            else
            {
                health = 300;
                level = 8;
                armor = 15;
            }
            return (health, level, armor);
        }
        // ***********************************************************
        // This is the method you call whenever you need a zombie
        // instead of using the New keyword
        // ***********************************************************


        public Zombie SpawnZombie(int areaLevel)
        {
            if (_zombiesPool.Count > 0)
            {
                return _zombiesPool.Pop();
            }
            else
            {
                throw new Exception("Zombies pool depleted");
            }
        }

        // ***********************************************************
        // This is the method you call whenever you need a "Dead" zombie
        // to be put back on the stack and reset
        // ***********************************************************



        public void ReclaimZombie(Zombie zombie)
        {
            (int health, int level, int armour) = GetZombieStatus(_areaLevel);
            zombie.Health = health;
            zombie.Armour = armour;
            zombie.Alive = true;
            _zombiesPool.Push(zombie);
        }

        public int ZombieCount()
        {
            return _zombiesPool.Count;
        }
        // you will need similar code for giants and werewolves

    }
}
