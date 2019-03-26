using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa chatka
    /// </summary>
    class Hut
    {
        /// <summary>
        /// zmienna przechowująca ilość mieszkańców
        /// </summary>
        int quantityOfPeople = 0;
        /// <summary>
        /// zmienna przechowująca ilość chatek
        /// </summary>
        int quantityOfHuts = 0;
        /// <summary>
        /// zmienne przechowujące koszty zbudowania chatek
        /// </summary>
        int costGold = 0;
        int costWood = 0;
        int costStone = 0;
        int costSand = 0;
        int costClay = 0;
        /// <summary>
        /// Konstruktor domyślny chatki
        /// </summary>
        public Hut()
        {
            quantityOfPeople = 0;
            quantityOfHuts = 0;
        }
        // Getery i Setery
        public int GetQuantityOfPeople()
        {
            return quantityOfPeople;
        }

        public int GetQuantityOfHuts()
        {
            return quantityOfHuts;
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

        public void SetQuantityOfPeople(int quantityOfPeople)
        {
            this.quantityOfPeople = quantityOfPeople;
        }

        public void SetQuantityOfHuts(int quantityOfHuts)
        {
            this.quantityOfHuts = quantityOfHuts;
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
        /// <summary>
        /// metoda buduj dla chatki
        /// </summary>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <returns></returns>
        public string Built(int gold, int wood, int stone, int sand, int clay)
        {
            // sprawdzam czy mam wystarczająco duże zasoby
            if (gold >= 100 && wood >= 100 && stone >= 100 && sand >= 100 && clay >= 100)
            {
                // ustawiam koszty wybudowania w przypadku powodzenia
                SetCostGold(100);
                SetCostWood(100);
                SetCostStone(100);
                SetCostSand(100);
                SetCostClay(100);
                quantityOfHuts++;
                quantityOfPeople = quantityOfPeople + 5;
                // zwracam informacje o powodzeniu operacji
                return "Udało Ci się wybudować chatkę. Zwiększasz liczbę swoich mieszkańców!";
            }
            else
            {
                // ustawiam koszty wybudowania w przypadku niepowodzenia
                SetCostGold(0);
                SetCostWood(0);
                SetCostStone(0);
                SetCostSand(0);
                SetCostClay(0);
                // zwracam informacje o niepowodzeniu operacji
                return "Nie masz wystarczającej ilości materiałów. Wybudowanie chatki nie powiodło się.";
            }
        }
    }
}
