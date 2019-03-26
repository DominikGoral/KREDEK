using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa budynki, klasa nadrzędna po której dziedziczą inne klasy
    /// </summary>
    public abstract class Buildings
    {
        /// <summary>
        /// Zmienna przechowująca nazwę budynku
        /// </summary>
        public string name;
        /// <summary>
        /// Zmienna przechowująca poziom budynku
        /// </summary>
        public int level;
        /// <summary>
        /// Zmienne przechowujące ilość surowców potrzebną do wybudowania lub ulepszenia
        /// </summary>
        int costGold = 0;
        int costWood = 0;
        int costStone = 0;
        int costSand = 0;
        int costClay = 0;
        /// <summary>
        /// Zmienne przechowujące ilość surowców potrzebną do wybudowania lub ulepszenia ( 1 poziom wyżej niż jesteśmy) Potrzebne do wyświetlania info
        /// </summary> 
        int costGoldOfNextOperation = 0;
        int costWoodOfNextOperation = 0;
        int costStoneOfNextOperation = 0;
        int costSandOfNextOperation = 0;
        int costClayOfNextOperation = 0;
        /// <summary>
        /// Metoda ulepszająca budynek
        /// </summary>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <returns></returns>
        public abstract string Upgrade(int gold, int wood, int stone, int sand, int clay);
        /// <summary>
        /// Metoda budująca budynek
        /// </summary>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <returns></returns>
        public abstract string Built(int gold, int wood, int stone, int sand, int clay);
        // Getery i Setery
        public string GetName()
        {
            return name;
        }

        public int GetLevel()
        {
            return level;
        }

        public int GetCostGold()
        {
            return costGold;
        }

        public int GetCostWood()
        {
            return costWood;
        }

        public int GetCostStone()
        {
            return costStone;
        }

        public int GetCostSand()
        {
            return costSand;
        }

        public int GetCostClay()
        {
            return costClay;
        }

        public int GetCostGoldOfNextOperation()
        {
            return costGoldOfNextOperation;
        }

        public int GetCostWoodOfNextOperation()
        {
            return costWoodOfNextOperation;
        }

        public int GetCostStoneOfNextOperation()
        {
            return costStoneOfNextOperation;
        }

        public int GetCostSandOfNextOperation()
        {
            return costSandOfNextOperation;
        }

        public int GetCostClayOfNextOperation()
        {
            return costClayOfNextOperation;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetLevel(int level)
        {
            this.level = level;
        }

        public void SetCostGold(int costGold)
        {
            this.costGold = costGold;
        }

        public void SetCostWood(int costWood)
        {
            this.costWood = costWood;
        }

        public void SetCostStone(int costStone)
        {
            this.costStone = costStone;
        }

        public void SetCostSand(int costSand)
        {
            this.costSand = costSand;
        }

        public void SetCostClay(int costClay)
        {
            this.costClay = costClay;
        }

        public void SetCostGoldOfNextOperation(int costGoldOfNextOperation)
        {
            this.costGoldOfNextOperation = costGoldOfNextOperation;
        }

        public void SetCostWoodOfNextOperation(int costWoodOfNextOperation)
        {
            this.costWoodOfNextOperation = costWoodOfNextOperation;
        }

        public void SetCostStoneOfNextOperation(int costStoneOfNextOperation)
        {
            this.costStoneOfNextOperation = costStoneOfNextOperation;
        }

        public void SetCostSandOfNextOperation(int costSandOfNextOperation)
        {
            this.costSandOfNextOperation = costSandOfNextOperation;
        }

        public void SetCostClayOfNextOperation(int costClayOfNextOperation)
        {
            this.costClayOfNextOperation = costClayOfNextOperation;
        }
    }
}
