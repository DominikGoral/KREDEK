using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa kopalnia złota, dziedzicząca po klasie budynki
    /// </summary>
    class GoldMine : Buildings
    {
        /// <summary>
        /// zmienna przechowująca informację o możliwości ulepszenia
        /// </summary>
        bool isAbleToUpgrade = false;
        /// <summary>
        /// zmienna przechowująca informację o istnieniu
        /// </summary>
        bool isBuilt = false;
        /// <summary>
        /// zmienna przechowująca informację o szybkości produkcji
        /// </summary>
        int speedOfProduction = 0;
        /// <summary>
        /// Konstruktor domyślny kopalni złota
        /// </summary>
        public GoldMine()
        {
            name = "Kopalnia złota";
            isAbleToUpgrade = false;
            level = 0;
            isBuilt = false;
            speedOfProduction = 0;
            // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
            SetCostGoldOfNextOperation(0);
            SetCostWoodOfNextOperation(150);
            SetCostStoneOfNextOperation(150);
            SetCostSandOfNextOperation(200);
            SetCostClayOfNextOperation(0);
        }
        // Getery i Setery
        public int GetSpeedOfProduction()
        {
            return speedOfProduction;
        }

        public bool GetIsBuilt()
        {
            return isBuilt;
        }

        public bool GetIsAbleToUpgrade()
        {
            return isAbleToUpgrade;
        }

        public void SetSpeedOfProduction(int speedOfProduction)
        {
            this.speedOfProduction = speedOfProduction;
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
                if (gold >= 0 && wood >= 150 && stone >= 150 && sand >= 200 && clay >= 0)
                {
                    // ustawiam koszty wybudowania
                    SetCostGold(0);
                    SetCostWood(150);
                    SetCostStone(150);
                    SetCostSand(200);
                    SetCostClay(0);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(2000);
                    SetCostWoodOfNextOperation(2200);
                    SetCostStoneOfNextOperation(2800);
                    SetCostSandOfNextOperation(425);
                    SetCostClayOfNextOperation(2100);
                    isBuilt = true;
                    // ustawiam poziom budynku
                    level = 1;
                    speedOfProduction = 1;
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się wybudować kopalnie złota !";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Wybudowanie kopalni nie powiodło się.";
                }
            } else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Kopalnia już istnieje.";
            }

        }
        /// <summary>
        /// przesłonięcie metody upgrade dla kopalni złota
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
                if (gold >= 2000 && wood >= 2200 && stone >= 2800 && sand >= 425 && clay >= 2100)
                {
                    // ustawiam koszty ulepszenia na poziom II
                    SetCostGold(2000);
                    SetCostWood(2200);
                    SetCostStone(2800);
                    SetCostSand(425);
                    SetCostClay(2100);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(2500);
                    SetCostWoodOfNextOperation(2850);
                    SetCostStoneOfNextOperation(3200);
                    SetCostSandOfNextOperation(520);
                    SetCostClayOfNextOperation(2700);
                    // ustawiam poziom budynku
                    level = 2;
                    speedOfProduction = 2;
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
                if (gold >= 2500 && wood >= 2850 && stone >= 3200 && sand >= 520 && clay >= 2700)
                {
                    // ustawiam koszty ulepszenia na poziom III
                    SetCostGold(2500);
                    SetCostWood(2850);
                    SetCostStone(3200);
                    SetCostSand(520);
                    SetCostClay(2700);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(3000);
                    SetCostWoodOfNextOperation(3320);
                    SetCostStoneOfNextOperation(3500);
                    SetCostSandOfNextOperation(650);
                    SetCostClayOfNextOperation(3150);
                    // ustawiam poziom budynku
                    level = 3;
                    speedOfProduction = 3;
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
                if (gold >= 3000 && wood >= 3320 && stone >= 3500 && sand >= 650 && clay >= 3150)
                {
                    // ustawiam koszty ulepszenia na poziom IV
                    SetCostGold(3000);
                    SetCostWood(3320);
                    SetCostStone(3500);
                    SetCostSand(650);
                    SetCostClay(3150);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(3300);
                    SetCostWoodOfNextOperation(3600);
                    SetCostStoneOfNextOperation(3800);
                    SetCostSandOfNextOperation(800);
                    SetCostClayOfNextOperation(3400);
                    // ustawiam poziom budynku
                    level = 4;
                    speedOfProduction = 4;
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
                if (gold >= 3300 && wood >= 3600 && stone >= 3800 && sand >= 800 && clay >= 3400)
                {
                    // ustawiam koszty ulepszenia na poziom V
                    SetCostGold(3300);
                    SetCostWood(3600);
                    SetCostStone(3800);
                    SetCostSand(800);
                    SetCostClay(3400);
                    // ustawiam poziom budynku
                    level = 5;
                    speedOfProduction = 5;
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
                return "Kopalnia jest już maksymalnie rozwinięty.";
            }
        }
    }
}
