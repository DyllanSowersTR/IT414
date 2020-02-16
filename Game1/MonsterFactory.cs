// Dyllan Sowers

using System.Collections.Generic;

namespace Game1
{
    public class MonsterFactory
    {
        public List<IMonster> SpawnMonster(int aLevel)
        {
            List<IMonster> aListOfMonsters = new List<IMonster>();
            // We could throw the if statement below into another class
            // and use the strategy method to replace the if statement
            // as we experimented with difficulty levels


            if (aLevel < 10)
            {
                int i = 0;

                while (i < 10)
                {
                    aListOfMonsters.Add(new Zombie(100, 100, 10));
                    i = i + 1;
                }


            }
            else if (aLevel < 20)
            {
                int i = 0;
                int j = 0;

                while (i < 10)
                {
                    aListOfMonsters.Add(new Zombie(200, 200, 20));
                    i = i + 1;
                }
                while (j < 10)
                {
                    aListOfMonsters.Add(new Giant(200, 200, 20));
                    j = j + 1;
                }

            }
            else
            {
                int i = 0;
                int j = 0;
                int k = 0;

                while (i < 10)
                {
                    aListOfMonsters.Add(new Zombie(300, 300, 30));
                    i = i + 1;
                }
                while (j < 10)
                {
                    aListOfMonsters.Add(new Giant(300, 300, 30));
                    j = j + 1;
                }
                while (k < 10)
                {
                    aListOfMonsters.Add(new WereWolf(300, 300, 30));
                    k = k + 1;
                }

            }

            return aListOfMonsters;

        }

    }
}
