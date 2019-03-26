using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa żwirownia, dziedzicząca po klasie budynki
    /// </summary>
    class Gravel : Buildings
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
        /// Konstruktor domyślny żwirowni
        /// </summary>
        public Gravel()
        {
            name = "Żwirownia";
            isAbleToUpgrade = false;
            speedOfProduction = 0;
            level = 0;
            isBuilt = false;
            // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
            SetCostGoldOfNextOperation(175);
            SetCostWoodOfNextOperation(280);
            SetCostStoneOfNextOperation(320);
            SetCostSandOfNextOperation(50);
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
        /// przesłonięcie funkcji Built dla żwirowni
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
                if (gold >= 175 && wood >= 280 && stone >= 320 && sand >= 50 && clay >= 100)
                {
                    // ustawiam koszty wybudowania
                    SetCostGold(175);
                    SetCostWood(280);
                    SetCostStone(320);
                    SetCostSand(50);
                    SetCostClay(100);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(1600);
                    SetCostWoodOfNextOperation(2250);
                    SetCostStoneOfNextOperation(3000);
                    SetCostSandOfNextOperation(220);
                    SetCostClayOfNextOperation(2600);
                    isBuilt = true;
                    // ustawiam poziom budynku
                    level = 1;
                    speedOfProduction = 1;
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się wybudować żwirownię !";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Wybudowanie żwirowni nie powiodło się.";
                }
            }
            else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Żwirownia już istnieje.";
            }   
        }
        /// <summary>
        /// przesłonięcie metody upgrade dla żwirowni
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
                if (gold >= 1600 && wood >= 2250 && stone >= 3000 && sand >= 220 && clay >= 2600)
                {
                    // ustawiam koszty ulepszenia na poziom II
                    SetCostGold(1600);
                    SetCostWood(2250);
                    SetCostStone(3000);
                    SetCostSand(220);
                    SetCostClay(2600);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(2100);
                    SetCostWoodOfNextOperation(2700);
                    SetCostStoneOfNextOperation(3700);
                    SetCostSandOfNextOperation(300);
                    SetCostClayOfNextOperation(3000);
                    // ustawiam poziom budynku
                    level = 2;
                    speedOfProduction = 2;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twoją żwirownię.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie żwirowni nie powiodło się.";
                }
            }
            else if (level == 2)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 2100 && wood >= 2700 && stone >= 3700 && sand >= 300 && clay >= 3000)
                {
                    // ustawiam koszty ulepszenia na poziom III
                    SetCostGold(2100);
                    SetCostWood(2700);
                    SetCostStone(3700);
                    SetCostSand(300);
                    SetCostClay(3000);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(2500);
                    SetCostWoodOfNextOperation(3200);
                    SetCostStoneOfNextOperation(4400);
                    SetCostSandOfNextOperation(500);
                    SetCostClayOfNextOperation(3900);
                    // ustawiam poziom budynku
                    level = 3;
                    speedOfProduction = 3;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twoją żwirownię.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie żwirowni nie powiodło się.";
                }
            }
            else if (level == 3)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 2500 && wood >= 3200 && stone >= 4400 && sand >= 500 && clay >= 3900)
                {
                    // ustawiam koszty ulepszenia na poziom IV
                    SetCostGold(2500);
                    SetCostWood(3200);
                    SetCostStone(4400);
                    SetCostSand(500);
                    SetCostClay(3900);
                    // ustawiam koszty następnej operacji (będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(3000);
                    SetCostWoodOfNextOperation(3800);
                    SetCostStoneOfNextOperation(5100);
                    SetCostSandOfNextOperation(730);
                    SetCostClayOfNextOperation(4350);
                    // ustawiam poziom budynku
                    level = 4;
                    speedOfProduction = 4;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twoją żwirownię.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie żwirowni nie powiodło się.";
                }
            }
            else if (level == 4)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 3000 && wood >= 3800 && stone >= 5100 && sand >= 730 && clay >= 4350)
                {
                    // ustawiam koszty ulepszenia na poziom V
                    SetCostGold(3000);
                    SetCostWood(3800);
                    SetCostStone(5100);
                    SetCostSand(730);
                    SetCostClay(4350);
                    // ustawiam poziom budynku
                    level = 5;
                    speedOfProduction = 5;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twoją żwirownię. Osiągnęła ona maksymalny poziom";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie żwirowni nie powiodło się.";
                }
            }
            else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Żwirownia jest już maksymalnie rozwinięty.";
            }
        }
    }
}
