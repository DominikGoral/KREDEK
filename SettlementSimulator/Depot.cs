using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa magazyn, dziedzicząca po klasie budynki
    /// </summary>
    class Depot : Buildings
    {
        /// <summary>
        /// zmienna przechowująca informację o istnieniu
        /// </summary>
        bool isBuilt = false;
        /// <summary>
        /// zmienna przechowująca informację o możliwości ulepszenia
        /// </summary>
        bool isAbleToUpgrade = false;
        /// <summary>
        /// zmienne przechowujące informacje o pojemności magazynu
        /// </summary>
        int maxWood = 500;
        int maxGold = 500;
        int maxStone = 500;
        int maxSand = 500;
        int maxClay = 500;
        /// <summary>
        /// Konstruktor domyślny magazynu
        /// </summary>
        public Depot()
        {
            name = "Magazyn I";
            isBuilt = false;
            isAbleToUpgrade = false;
            level = 0;
            maxWood = 0;
            maxGold = 0;
            maxStone = 0;
            maxSand = 0;
            maxClay = 0;
            // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
            SetCostGoldOfNextOperation(200);
            SetCostWoodOfNextOperation(250);
            SetCostStoneOfNextOperation(350);
            SetCostSandOfNextOperation(100);
            SetCostClayOfNextOperation(300);
        }
        // Getery i Setery
        public int GetMaxWood()
        {
            return maxWood;
        }

        public int GetMaxGold()
        {
            return maxGold;
        }

        public int GetMaxStone()
        {
            return maxStone;
        }

        public int GetMaxSand()
        {
            return maxSand;
        }

        public int GetMaxClay()
        {
            return maxClay;
        }

        public bool GetIsBuilt()
        {
            return isBuilt;
        }

        public bool GetIsAbleToUpgrade()
        {
            return isAbleToUpgrade;
        }

        public void SetMaxWood(int maxWood)
        {
            this.maxWood = maxWood;
        }

        public void SetMaxGold(int maxGold)
        {
            this.maxGold = maxGold;
        }

        public void SetMaxStone(int maxStone)
        {
            this.maxStone = maxStone;
        }

        public void SetMaxSand(int maxSand)
        {
            this.maxSand = maxSand;
        }

        public void SetMaxClay(int maxClay)
        {
            this.maxClay = maxClay;
        }

        public void SetIsBuilt(bool isBuilt)
        {
            this.isBuilt = isBuilt;
        }

        public void SetIsAbleToUpgrade(bool isAbleToUpgrade)
        {
            this.isAbleToUpgrade = isAbleToUpgrade;
        }
        /// <summary>
        /// przesłonięcie funkcji Built dla magazynu
        /// </summary>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <returns></returns>
        public override string Built(int gold, int wood, int stone, int sand, int clay)
        {
            if(isBuilt == false)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 200 && wood >= 250 && stone >= 350 && sand >= 100 && clay >= 300)
                {
                    // ustawienie pojemności magazynu
                    maxWood = 4000;
                    maxGold = 4000;
                    maxStone = 5000;
                    maxSand = 1000;
                    maxClay = 3500;
                    // ustawiam koszty ulepszenia na poziom I
                    SetCostGold(200);
                    SetCostWood(250);
                    SetCostStone(350);
                    SetCostSand(100);
                    SetCostClay(300);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(3500);
                    SetCostWoodOfNextOperation(3000);
                    SetCostStoneOfNextOperation(4000);
                    SetCostSandOfNextOperation(800);
                    SetCostClayOfNextOperation(3250);
                    isBuilt = true;
                    // ustawiam poziom budynku
                    level = 1;
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się wybudować magazyn !";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Wybudowanie magazynu nie powiodło się.";
                }
            }
            else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Magazyn już istnieje.";
            }
        }
        /// <summary>
        /// przesłonięcie metody upgrade dla magazynu
        /// </summary>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <returns></returns>
        public override string Upgrade(int gold, int wood, int stone, int sand, int clay)
        {
            if(level == 1)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 3500 && wood >= 3000 && stone >= 4000 && sand >= 800 && clay >= 3250)
                {
                    // ustawiam poziom budynku
                    level = 2;
                    // ustawienie pojemności magazynu
                    maxWood = 6500;
                    maxGold = 6000;
                    maxStone = 7000;
                    maxSand = 1400;
                    maxClay = 5500;
                    // ustawiam koszty ulepszenia na poziom II
                    SetCostGold(3500);
                    SetCostWood(3000);
                    SetCostStone(4000);
                    SetCostSand(800);
                    SetCostClay(3250);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(4500);
                    SetCostWoodOfNextOperation(5000);
                    SetCostStoneOfNextOperation(5500);
                    SetCostSandOfNextOperation(1100);
                    SetCostClayOfNextOperation(4400);
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój magazyn.";
                } else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie magazynu nie powiodło się.";
                }
            } else if(level == 2)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 4500 && wood >= 5000 && stone >= 5500 && sand >= 1100 && clay >= 4400)
                {
                    // ustawiam poziom budynku
                    level = 3;
                    // ustawienie pojemności magazynu
                    maxWood = 8000;
                    maxGold = 10000;
                    maxStone = 9000;
                    maxSand = 1800;
                    maxClay = 7500;
                    // ustawiam koszty ulepszenia na poziom III
                    SetCostGold(4500);
                    SetCostWood(5000);
                    SetCostStone(5500);
                    SetCostSand(1100);
                    SetCostClay(4400);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(5000);
                    SetCostWoodOfNextOperation(6000);
                    SetCostStoneOfNextOperation(6500);
                    SetCostSandOfNextOperation(1400);
                    SetCostClayOfNextOperation(5500);
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój magazyn.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie magazynu nie powiodło się.";
                }
            } else if(level == 3)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 5000 && wood >= 6000 && stone >= 6500 && sand >= 1400 && clay >= 5500)
                {
                    // ustawiam poziom budynku
                    level = 4;
                    // ustawienie pojemności magazynu
                    maxWood = 10000;
                    maxGold = 15000;
                    maxStone = 11000;
                    maxSand = 2200;
                    maxClay = 10000;
                    // ustawiam koszty ulepszenia na poziom IV
                    SetCostGold(5000);
                    SetCostWood(6000);
                    SetCostStone(6500);
                    SetCostSand(1400);
                    SetCostClay(5500);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(6000);
                    SetCostWoodOfNextOperation(7000);
                    SetCostStoneOfNextOperation(7700);
                    SetCostSandOfNextOperation(1700);
                    SetCostClayOfNextOperation(6300);
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój magazyn.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie magazynu nie powiodło się.";
                }
            }else if(level == 4)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 6000 && wood >= 7000 && stone >= 7700 && sand >= 1700 && clay >= 6300)
                {
                    // ustawiam poziom budynku
                    level = 5;
                    // ustawienie pojemności magazynu
                    maxWood = 15000;
                    maxGold = 25000;
                    maxStone = 17000;
                    maxSand = 3000;
                    maxClay = 15000;
                    // ustawiam koszty ulepszenia na poziom V
                    SetCostGold(6000);
                    SetCostWood(7000);
                    SetCostStone(7700);
                    SetCostSand(1700);
                    SetCostClay(6300);
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój magazyn. Osiągnął on maksymalny poziom";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie magazynu nie powiodło się.";
                }
            }else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Magazyn jest już maksymalnie rozwinięty.";
            }
        }

    }
}
