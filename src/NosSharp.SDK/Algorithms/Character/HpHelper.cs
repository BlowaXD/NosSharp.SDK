using NosSharp.SDK.Enumerations.Character;

namespace NosSharp.SDK.Algorithms.Character
{
    /// <summary>
    /// HpHelper
    /// </summary>
    public class HpHelper
    {
        /// <summary>
        /// Will fill the Data array with Adventurer Hp algorithm
        /// </summary>
        private void LoadAdventurerData()
        {
            // Adventurer HP
            for (int i = 1; i < Data.GetLength(1); i++)
            {
                Data[(int) CharacterClass.Adventurer, i] = (int) (1 / 2.0 * i * i + 31 / 2.0 * i + 205);
            }
        }

        /// <summary>
        /// Will fill the Data array with Swordman Hp Algorithm
        /// </summary>
        private void LoadSwordmanData()
        {
            for (int i = 0; i < Data.GetLength(1); i++)
            {
                int j = 16;
                int hp = 946;
                int inc = 85;
                while (j <= i)
                {
                    if (j % 5 == 2)
                    {
                        hp += inc / 2;
                        inc += 2;
                    }
                    else
                    {
                        hp += inc;
                        inc += 4;
                    }

                    ++j;
                }

                Data[(int) CharacterClass.Swordman, i] = hp;
            }
        }

        /// <summary>
        /// Will fill the Data array with Archer Hp Algorithm
        /// </summary>
        private void LoadArcherData()
        {
            // Archer HP
            for (int i = 0; i < Data.GetLength(1); i++)
            {
                int hp = 680;
                int inc = 35;
                int j = 16;
                while (j <= i)
                {
                    hp += inc;
                    ++inc;
                    if (j % 10 == 1 || j % 10 == 5 || j % 10 == 8)
                    {
                        hp += inc;
                        ++inc;
                    }

                    ++j;
                }

                Data[(int) CharacterClass.Archer, i] = hp;
            }
        }

        /// <summary>
        /// Will fill the Data array with Magician Hp Algorithm
        /// </summary>
        private void LoadMagicianData()
        {
            // Magician HP
            for (int i = 0; i < Data.GetLength(1); i++)
            {
                Data[(int) CharacterClass.Magician, i] = (int) ((i + 15) * (i + 15) + i + 15.0 - 465 + 550);
            }
        }


        /// <summary>
        /// Will fill the Data array with all classes Hp Algorithm
        /// </summary>
        public void Initialize()
        {
            Data = new int[4, 256];

            LoadAdventurerData();
            LoadSwordmanData();
            LoadArcherData();
            LoadMagicianData();
        }

        public int[,] Data { get; private set; }
    }
}