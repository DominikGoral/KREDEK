using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa kościół, dziedzicząca po klasie budynki
    /// </summary>
    class Church : Buildings
    {
        /// <summary>
        /// Zmienna przechowująca informację o istnieniu kościoła
        /// </summary>
        bool isBuilt = false;
        /// <summary>
        /// Zmienna przechowująca informację o możliwości ulepszania kościoła ( Musi być wybudowany)
        /// </summary>
        bool isAbleToUpgrade = false;
        /// <summary>
        /// Zmienna przechowująca wartość bonusu do produkcji
        /// </summary>
        int bonusToSpeedProduction = 0;
        /// <summary>
        /// Konstruktor domyślny kościoła
        /// </summary>
        public Church()
        {
            name = "Kościół";
            isBuilt = false;
            isAbleToUpgrade = false;
            bonusToSpeedProduction = 0;
            level = 1;
            // ustawiam koszty następnej operacji ( będą wyświetlane pod przyciskiem info)
            SetCostGoldOfNextOperation(5000);
            SetCostWoodOfNextOperation(4500);
            SetCostStoneOfNextOperation(7500);
            SetCostSandOfNextOperation(2000);
            SetCostClayOfNextOperation(6000);
        }
        // Getery i Setery
        public bool GetIsBuilt()
        {
            return isBuilt;
        }

        public int GetBonusToSpeedProduction()
        {
            return bonusToSpeedProduction;
        }

        public bool GetIsAbleToUpgrade()
        {
            return isAbleToUpgrade;
        }

        public void SetIsBuilt(bool isBuilt)
        {
            this.isBuilt = isBuilt;
        }

        public void SetBonusToSpeedProduction(int bonusToSpeedProduction)
        {
            this.bonusToSpeedProduction = bonusToSpeedProduction;
        }

        public void SetIsAbleToUpgrade(bool isAbleToUpgrade)
        {
            this.isAbleToUpgrade = isAbleToUpgrade;
        }
        /// <summary>
        /// przesłonięcie funkcji Built dla kościoła
        /// </summary>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <returns></returns>
        public override string Built(int gold, int wood, int stone, int sand, int clay)
        {
            // sprawdzam czy budynek istnieje
            if(isBuilt == false)
            {
                // jesli nie to sprawdzam czy mamy wystarczającą ilość zasobów
                if (gold >= 5000 && wood >= 4500 && stone >= 7500 && sand >= 2000 && clay >= 6000)
                {
                    // ustawiam koszty wybudowania
                    SetCostGold(5000);
                    SetCostWood(4500);
                    SetCostStone(7500);
                    SetCostSand(2000);
                    SetCostClay(6000);
                    // ustawiam koszty następnej operacji ( będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(7500);
                    SetCostWoodOfNextOperation(6000);
                    SetCostStoneOfNextOperation(10000);
                    SetCostSandOfNextOperation(3500);
                    SetCostClayOfNextOperation(8000);
                    // zmieniam istnienie kościoła na true
                    isBuilt = true;
                    // ustawiam poziom budynku
                    level = 1;
                    // ustawiam bonus dodawany do produkcji
                    bonusToSpeedProduction = 10;
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się wybudować kościół !";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Wybudowanie kościoła nie powiodło się.";
                }
            }
            else
            {
                // zwracam informacje o niepowodzeniu operacji
                return "Kościół już istnieje.";
            }
        }
        /// <summary>
        /// przesłonięcie metody upgrade dla kościoła
        /// </summary>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        /// <returns></returns>
        public override string Upgrade(int gold, int wood, int stone, int sand, int clay)
        {
            // sprawdzam ktory poziom obecnie ma budynek
            if (level == 1)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 7500 && wood >= 6000 && stone >= 10000 && sand >= 3500 && clay >= 8000)
                {
                    // ustawiam koszty ulepszenia na poziom II
                    SetCostGold(7500);
                    SetCostWood(6000);
                    SetCostStone(10000);
                    SetCostSand(3500);
                    SetCostClay(8000);
                    // ustawiam koszty następnej operacji ( będą wyświetlane pod przyciskiem info)
                    SetCostGoldOfNextOperation(9000);
                    SetCostWoodOfNextOperation(7700);
                    SetCostStoneOfNextOperation(12500);
                    SetCostSandOfNextOperation(5200);
                    SetCostClayOfNextOperation(11000);
                    // ustawiam poziom budynku
                    level = 2;
                    // ustawiam bonus dodawany do produkcji
                    bonusToSpeedProduction = 25;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój kościół.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie kościoła nie powiodło się.";
                }
            }
            else if (level == 2)
            {
                // sprawdzam czy mam wystarczająco duże zasoby
                if (gold >= 9000 && wood >= 7700 && stone >= 12500 && sand >= 5200 && clay >= 11000)
                {
                    // ustawiam koszty ulepszenia na poziom III
                    SetCostGold(9000);
                    SetCostWood(7700);
                    SetCostStone(12500);
                    SetCostSand(5200);
                    SetCostClay(11000);
                    // ustawiam poziom budynku
                    level = 3;
                    // ustawiam bonus dodawany do produkcji
                    bonusToSpeedProduction = 60;
                    // umożliwiam ulepszanie budynku ( jeśli upgrade() może być wykonany- mamy zasoby- zmieniam na true-> wtedy mogę zmniejszyć zasoby o koszt
                    SetIsAbleToUpgrade(true);
                    // zwracam informacje o powodzeniu operacji
                    return "Udało Ci się ulepszyć twój kościół. Osiągnął on maksymalny poziom.";
                }
                else
                {
                    // zwracam informacje o niepowodzeniu operacji
                    return "Nie masz wystarczającej ilości materiałów. Ulepszenie kościoła nie powiodło się.";
                }
            }
            // zwracam informacje o niepowodzeniu operacji
            return "Kościół osiągnął maksymalny poziom.";
        }
    }
}
