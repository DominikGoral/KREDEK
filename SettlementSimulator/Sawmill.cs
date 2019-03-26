using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa tartak, dziedzicząca po klasie budynki
    /// </summary>
    class Sawmill : Buildings
    {
        /// <summary>
        /// zmienna przechowująca informację o możliwości ulepszenia
        /// </summary>
        bool isAbleToUpgrade = false;
        /// <summary>
        /// zmienna przechowująca informację o szybkości produkcji
        /// </summary>
        int speedOfProduction = 0;
        /// <summary>
        /// zmienna przechowująca informację o istnieniu
        /// </summary>
        bool isBuilt = false;
        /// <summary>
        /// Konstruktor domyślny tartaku
        /// </summary>
        public Sawmill()
        {
            name = "Tartak";
            isAbleToUpgrade = false;
            level = 0;
            speedOfProduction = 0;
            isBuilt = false;
            // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
            SetCostGoldOfNextOperation(200);
            SetCostWoodOfNextOperation(100);
            SetCostStoneOfNextOperation(0);
            SetCostSandOfNextOperation(50);
            SetCostClayOfNextOperation(0);
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
        /// przesłonięcie funkcji Built dla tartaku
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
                if (gold >= 200 && wood >= 100 && stone >= 0 && sand >= 50 && clay >= 0)
                {
                    // ustawiam koszty wybudowania
                    SetCostGold(200);
                    SetCostWood(100);
                    SetCostStone(0);
                    SetCostSand(50);
                    SetCostClay(0);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(1700);
                    SetCostWoodOfNextOperation(1250);
                    SetCostStoneOfNextOperation(2350);
                    SetCostSandOfNextOperation(320);
                    SetCostClayOfNextOperation(1800);
                    isBuilt = true;
                    // ustawiam poziom budynku
                    level = 1;
                    speedOfProduction = 1;
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się wybudować tartak !";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Wybudowanie tartaku nie powiodło się.";
                }
            }
            else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Tartak już istnieje.";
            }
        }
        /// <summary>
        /// przesłonięcie metody upgrade dla tartaku
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
                if (gold >= 1700 && wood >= 1250 && stone >= 2350 && sand >= 320 && clay >= 1800)
                {
                    // ustawiam koszty ulepszenia na poziom II
                    SetCostGold(1700);
                    SetCostWood(1250);
                    SetCostStone(2350);
                    SetCostSand(320);
                    SetCostClay(1800);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(2300);
                    SetCostWoodOfNextOperation(1600);
                    SetCostStoneOfNextOperation(2800);
                    SetCostSandOfNextOperation(470);
                    SetCostClayOfNextOperation(2500);
                    // ustawiam poziom budynku
                    level = 2;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój tartak.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie tartaku nie powiodło się.";
                }
            }
            else if (level == 2)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 2300 && wood >= 1600 && stone >= 2800 && sand >= 470 && clay >= 2500)
                {
                    // ustawiam koszty ulepszenia na poziom III
                    SetCostGold(2300);
                    SetCostWood(1600);
                    SetCostStone(2800);
                    SetCostSand(470);
                    SetCostClay(2500);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(2700);
                    SetCostWoodOfNextOperation(2075);
                    SetCostStoneOfNextOperation(3300);
                    SetCostSandOfNextOperation(630);
                    SetCostClayOfNextOperation(2900);
                    // ustawiam poziom budynku
                    level = 3;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój tartak.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie tartaku nie powiodło się.";
                }
            }
            else if (level == 3)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 2700 && wood >= 2075 && stone >= 3300 && sand >= 630 && clay >= 2900)
                {
                    // ustawiam koszty ulepszenia na poziom IV
                    SetCostGold(2700);
                    SetCostWood(2075);
                    SetCostStone(3300);
                    SetCostSand(630);
                    SetCostClay(2900);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(3270);
                    SetCostWoodOfNextOperation(2500);
                    SetCostStoneOfNextOperation(3800);
                    SetCostSandOfNextOperation(790);
                    SetCostClayOfNextOperation(3400);
                    // ustawiam poziom budynku
                    level = 4;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój tartak.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie tartaku nie powiodło się.";
                }
            }
            else if (level == 4)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 3270 && wood >= 2500 && stone >= 3800 && sand >= 790 && clay >= 3400)
                {
                    // ustawiam koszty ulepszenia na poziom V
                    SetCostGold(3270);
                    SetCostWood(2500);
                    SetCostStone(3800);
                    SetCostSand(790);
                    SetCostClay(3400);
                    // ustawiam poziom budynku
                    level = 5;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój tartak. Osiągnęła ona maksymalny poziom";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie tartak nie powiodło się.";
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
