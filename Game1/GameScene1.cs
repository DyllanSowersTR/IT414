// Dyllan Sowers

using System;
using System.Collections.Generic;
using System.Threading;

namespace Game1
{
    // AKA the Scene Manager for the first Game Level
    public class GameScene1
    {
        private Player aPlayer;
        // Having a Concrete class in the List would Violate SOLID
        // We would be limited to only Giants
        // Therefore we use IMonsters
        //private List<Giant> aListOfMonsters = new List<Giant>();
        private List<IMonster> aListOfMonsters = new List<IMonster>();
        // private MonsterFactory aFactory = new MonsterFactory();

        private int aLevel;

        public GameScene1()
        {
            // Often this would be Player.Instance;
            this.aPlayer = Player.ThePlayer;
            aPlayer.Name = Menu.SelectName();

            while (aPlayer.Weapon == null)
                aPlayer.Weapon = Menu.SelectWeapon();

            aLevel = Menu.SelectLevel();
            EnemyFactory aFactory = new EnemyFactory(aLevel);
            Zombie zombie = aFactory.SpawnZombie(aLevel);
            int count = 1;

            while (aFactory.ZombieCount() > 0)
            {          
                string mName = zombie.GetType().ToString() + count.ToString();
                while (zombie.Alive)
                {
                    Console.Write(mName + "     \n" + zombie.ToString() + "\n\n");
                    zombie.Defend(aPlayer);
                }
                // aFactory.ReclaimZombie(zombie);
                Console.WriteLine("You have killed " + mName + "! Nice job! \n\n");
                zombie = aFactory.SpawnZombie(aLevel);
                count++;
            }

            
            Console.WriteLine("All monsters are dead. Congrats!");

        }
    }
}
