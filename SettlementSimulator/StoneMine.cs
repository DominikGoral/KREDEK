using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa kopalnia kamienia, dziedzicząca po klasie budynki
    /// </summary>
    class StoneMine : Buildings
    {
        // zmienna przechowująca informację o możliwości ulepszenia
        bool isAbleToUpgrade = false;
        // zmienna przechowująca informację o istnieniu
        bool isBuilt = false;
        // zmienna przechowująca informację o szybkości produkcji
        int speedOfProduction = 0;
        // Konstruktor domyślny
        public StoneMine()
        {
            name = "Kopalnia kamienia";
            isAbleToUpgrade = false;
            level = 0;
            isBuilt = false;
            speedOfProduction = 0;
            // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
            SetCostGoldOfNextOperation(125);
            SetCostWoodOfNextOperation(200);
            SetCostStoneOfNextOperation(0);
            SetCostSandOfNextOperation(100);
            SetCostClayOfNextOperation(100);
        }
        // Getery i Setery
        public int GetSpeedOfProduction()
        {
            return speedOfProduction;
        }

        public bool GetIsAbleToUpgrade()
        {
            return isAbleToUpgrade;
        }

        public bool GetIsBuilt()
        {
            return isBuilt;
        }

        public void SetSpeedOfProduction(int speedOfProduction)
        {
            this.speedOfProduction = speedOfProduction;
        }

        public void SetIsAbleToUpgrade(bool isAbleToUpgrade)
        {
            this.isAbleToUpgrade = isAbleToUpgrade;
        }

        public void SetIsBuilt(bool isBuilt)
        {
            this.isBuilt = isBuilt;
        }
        /// <summary>
        /// przesłonięcie funkcji Built dla kopalni kamieni
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
                if (gold >= 125 && wood >= 200 && stone >= 0 && sand >= 100 && clay >= 100)
                {
                    // ustawiam koszty wybudowania
                    SetCostGold(125);
                    SetCostWood(200);
                    SetCostStone(0);
                    SetCostSand(100);
                    SetCostClay(100);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(1500);
                    SetCostWoodOfNextOperation(1000);
                    SetCostStoneOfNextOperation(2000);
                    SetCostSandOfNextOperation(300);
                    SetCostClayOfNextOperation(1700);
                    // ustawienie informacji o istnieniu budynku
                    isBuilt = true;
                    // ustawiam poziom budynku
                    level = 1;
                    speedOfProduction = 1;
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się wybudować kopalnię !";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Wybudowanie kopalni nie powiodło się.";
                }
            }
            else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Kopalnia już istnieje.";
            }
        }
        /// <summary>
        /// przesłonięcie metody upgrade dla kopalni kamieni
        /// </summary>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <returns></returns>
        public override string Upgrade(int gold, int wood, int stone, int sand, int clay)
        {
            if (level == 1)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 1500 && wood >= 1000 && stone >= 2000 && sand >= 300 && clay >= 1700)
                {
                    // ustawiam koszty ulepszenia na poziom II
                    SetCostGold(1500);
                    SetCostWood(1000);
                    SetCostStone(2000);
                    SetCostSand(300);
                    SetCostClay(1700);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(2000);
                    SetCostWoodOfNextOperation(1500);
                    SetCostStoneOfNextOperation(2500);
                    SetCostSandOfNextOperation(450);
                    SetCostClayOfNextOperation(2200);
                    // ustawiam poziom budynku
                    level = 2;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twoją kopalnię.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie kopalni nie powiodło się.";
                }
            }
            else if (level == 2)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 2000 && wood >= 1500 && stone >= 2500 && sand >= 450 && clay >= 2200)
                {
                    // ustawiam koszty ulepszenia na poziom III
                    SetCostGold(2000);
                    SetCostWood(1500);
                    SetCostStone(2500);
                    SetCostSand(450);
                    SetCostClay(2200);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(2500);
                    SetCostWoodOfNextOperation(2000);
                    SetCostStoneOfNextOperation(3000);
                    SetCostSandOfNextOperation(600);
                    SetCostClayOfNextOperation(2700);
                    // ustawiam poziom budynku
                    level = 3;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twoją kopalnię.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie kopalni nie powiodło się.";
                }
            }
            else if (level == 3)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 2500 && wood >= 2000 && stone >= 3000 && sand >= 600 && clay >= 2700)
                {
                    // ustawiam koszty ulepszenia na poziom IV
                    SetCostGold(2500);
                    SetCostWood(2000);
                    SetCostStone(3000);
                    SetCostSand(600);
                    SetCostClay(2700);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(3500);
                    SetCostWoodOfNextOperation(2500);
                    SetCostStoneOfNextOperation(3500);
                    SetCostSandOfNextOperation(700);
                    SetCostClayOfNextOperation(3200);
                    // ustawiam poziom budynku
                    level = 4;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twoją kopalnię.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie kopalni nie powiodło się.";
                }
            }
            else if (level == 4)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 3000 && wood >= 2500 && stone >= 3500 && sand >= 700 && clay >= 3200)
                {
                    // ustawiam koszty ulepszenia na poziom V
                    SetCostGold(3500);
                    SetCostWood(2500);
                    SetCostStone(3500);
                    SetCostSand(700);
                    SetCostClay(3200);
                    // ustawiam poziom budynku
                    level = 5;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twoją kopalnię. Osiągnęła ona maksymalny poziom";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie kopalni nie powiodło się.";
                }
            }
            else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Kopalnia jest już maksymalnie rozwinięta.";
            }
        }
    }
}
