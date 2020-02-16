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
        private MonsterFactory aFactory = new MonsterFactory();

        public GameScene1()
        {
            // Often this would be Player.Instance;
            this.aPlayer = Player.ThePlayer;
            aPlayer.Name = Menu.SelectName();

            while (aPlayer.Weapon == null)
                aPlayer.Weapon = Menu.SelectWeapon();

            aListOfMonsters = aFactory.SpawnMonster(Menu.SelectLevel());

            foreach (var m in aListOfMonsters)
            {
                //m.Attack(aPlayer);
                while (m.Alive)
                {
                    //Thread.Sleep(1000);
                    Console.Write(m.GetType() + aListOfMonsters.IndexOf(m).ToString() + "     \n" + m.ToString() + "\n\n");
                    m.Defend(aPlayer);
                }
                Console.WriteLine("You have killed " + m.GetType() + "! Nice job! \n\n");
            }
            Console.WriteLine("All monsters are dead. Congrats!");

        }
    }
}
