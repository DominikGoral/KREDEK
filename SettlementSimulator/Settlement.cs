using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikGoralLab1
{
    /// <summary>
    /// klasa osada, posiadająca obiekty wszystkich pozostałych klas
    /// posiada także wartości wszystkich zasobów
    /// </summary>
    class Settlement
    {
        /// <summary>
        /// zmienna przechowująca ilość obecnych minuty
        /// </summary>
        public int minutes;
        /// <summary>
        /// zmienna przechowująca ilość obecnych godziny
        /// </summary>
        public int hours;
        /// <summary>
        /// zmienna przechowująca ilość obecnych dni
        /// </summary>
        public int days;
        /// <summary>
        /// zmienna przechowująca nazwe osady
        /// </summary>
        public string name;
        /// <summary>
        /// zmienna przechowująca ilość drewna
        /// </summary>
        public int wood = 500;
        /// <summary>
        /// zmienna przechowująca ilość złota
        /// </summary>
        public int gold = 500;
        /// <summary>
        /// zmienna przechowująca ilość kamieni
        /// </summary>
        public int stone = 500;
        /// <summary>
        /// zmienna przechowująca ilość piasku
        /// </summary>
        public int sand = 500;
        /// <summary>
        /// zmienna przechowująca ilość gliny
        /// </summary>
        public int clay = 500;
        /// <summary>
        /// zmienna przechowująca informacje o sile zniszczen katastrofy- I stopień
        /// </summary>
        public double extentOne = 0.9;
        /// <summary>
        /// zmienna przechowująca informacje o sile zniszczen katastrofy- II stopień
        /// </summary>
        public double extentTwo = 0.75;
        /// <summary>
        /// zmienna przechowująca informacje o sile zniszczen katastrofy- III stopień
        /// </summary>
        public double extentThree = 0.55;
        /// <summary>
        /// zmienna przechowująca informacje o sile zniszczen katastrofy- IV stopień
        /// </summary>
        public double extentFour = 0.45;
        /// <summary>
        /// zmienna przechowująca informacje o sile zniszczen katastrofy- V stopień
        /// </summary>
        public double extentFive = 0.2;
        /// <summary>
        /// zmienna przechowująca informację o wystąpieniu huraganu
        /// </summary>
        public bool ifHurricaneHappened = false;
        /// <summary>
        /// zmienna przechowująca informację o wystąpieniu choroby
        /// </summary>
        public bool ifPlagueHappened = false;
        /// <summary>
        /// zmienna przechowująca informację o wystąpieniu trzęsienia ziemi
        /// </summary>
        public bool ifEarthquakeHappened = false;
        // stworzenie obiektów klas budynków
        public Depot depot = new Depot();
        public GoldMine goldMine = new GoldMine();
        public StoneMine stoneMine = new StoneMine();
        public ClayMine clayMine = new ClayMine();
        public Sawmill sawmill = new Sawmill();
        public Gravel gravel = new Gravel();
        public Church church = new Church();
        public Hut hut = new Hut();
        /// <summary>
        /// Konstruktor domyślny osady
        /// </summary>
        public Settlement()
        {
            name = "Domyślna osada";
            wood = 700;
            gold = 700;
            stone = 700;
            sand = 700;
            clay = 700;
            ifHurricaneHappened = false;
            ifPlagueHappened = false;
            ifEarthquakeHappened = false;
    }
        /// <summary>
        /// Konstruktor parametryczny osady
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gold"></param>
        /// <param name="wood"></param>
        /// <param name="stone"></param>
        /// <param name="sand"></param>
        /// <param name="clay"></param>
        public Settlement(string name, int gold, int wood, int stone, int sand, int clay)
        {
            name = this.name;
            gold = this.gold;
            wood = this.wood;
            stone = this.stone;
            sand = this.sand;
            clay = this.clay;
        }
        // Getery i Setery
        public int GetMinutes()
        {
            return minutes;
        }

        public int GetHours()
        {
            return hours;
        }

        public int GetDays()
        {
            return days;
        }

        public string GetName()
        {
            return name;
        }

        public int GetWood()
        {
            return wood;
        }
        
        public int GetGold()
        {
            return gold;
        }
        
        public int GetStone()
        {
            return stone;
        }

        public int GetSand()
        {
            return sand;
        }

        public  int GetClay()
        {
            return clay;
        }

        public double GetExtentOne()
        {
            return extentOne;
        }

        public double GetExtentTwo()
        {
            return extentTwo;
        }

        public double GetExtentThree()
        {
            return extentThree;
        }

        public double GetExtentFour()
        {
            return extentFour;
        }

        public double GetExtentFive()
        {
            return extentFive;
        }

        public bool GetIfHurricaneHappened()
        {
            return ifHurricaneHappened;
        }

        public bool GetIfPlagueHappened()
        {
            return ifPlagueHappened;
        }

        public bool GetIfEarthquakeHappened()
        {
            return ifEarthquakeHappened;
        }

        public void SetMinutes(int minutes)
        {
            this.minutes = minutes;
        }

        public void SetHours(int hours)
        {
            this.hours = hours;
        }

        public void SetDays(int days)
        {
            this.days = days;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetWood(int wood)
        {
            this.wood = wood;
        }

        public void SetGold(int gold)
        {
            this.gold = gold;
        }

        public void SetStone(int stone)
        {
            this.stone = stone;
        }

        public void SetSand(int sand)
        {
            this.sand = sand;
        }

        public void SetClay(int clay)
        {
            this.clay = clay;
        }

        public void GetExtentOne(int extentOne)
        {
            this.extentOne = extentOne;
        }

        public void GetExtentTwo(int extentTwo)
        {
            this.extentTwo = extentTwo;
        }

        public void GetExtentThree(int extentThree)
        {
            this.extentThree = extentThree;
        }

        public void GetExtentFour(int extentFour)
        {
            this.extentFour = extentFour;
        }

        public void GetExtentFive(int extentFive)
        {
            this.extentFive = extentFive;
        }

        public void SetIfHurricaneHappened(bool ifHurricaneHappened)
        {
            this.ifHurricaneHappened = ifHurricaneHappened;
        }

        public void SetIfPlagueHappened(bool ifPlagueHappened)
        {
            this.ifPlagueHappened = ifPlagueHappened;
        }

        public void SetIfEarthquakeHappened(bool ifEarthquakeHappened)
        {
            this.ifEarthquakeHappened = ifEarthquakeHappened;
        }
        /// <summary>
        /// Funkcja okreslajaca szkody huraganu
        /// </summary>
        /// <returns></returns>
        public string DestroyByHurricane()
        {
            //losujemy stopien katastrofy. Mamy 45 % na I, 25 % na II, 15 % na III, 11 % na IV i 4 % na V stopień
            System.Random rand = new Random();
            int forceOfOccurrence = rand.Next(1, 100);
            // zmieniamy wartość na true, aby katastrofa nie odwiedziła nas ponownie
            ifHurricaneHappened = true;
            // określenie skali zniszczeń na podstawie stopnia siły katastrofy
            if (forceOfOccurrence < 46)
            {
                // zmniejszamy ilość mieszkańców i chat w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentOne));
                hut.SetQuantityOfHuts((int)(hut.GetQuantityOfHuts() * extentOne));
                // zwracam informacje o powodzeniu operacji
                return "Niestety twoją osadę odwiedził huragan I poziomu.\n Liczba twoich mieszkańców i chatek zmiejszyła się o 10 %";
            }
            else if (forceOfOccurrence > 45 && forceOfOccurrence < 71)
            {
                // zmniejszamy ilość mieszkańców i chat w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentTwo));
                hut.SetQuantityOfHuts((int)(hut.GetQuantityOfHuts() * extentTwo));
                return "Niestety twoją osadę odwiedził huragan II poziomu.\n Liczba twoich mieszkańców i chatek zmiejszyła się o 25 %";
            }
            else if (forceOfOccurrence > 70 && forceOfOccurrence < 86)
            {
                // zmniejszamy ilość mieszkańców i chat w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentThree));
                hut.SetQuantityOfHuts((int)(hut.GetQuantityOfHuts() * extentThree));
                return "Niestety twoją osadę odwiedził huragan III poziomu.\n Liczba twoich mieszkańców i chatek zmiejszyła się o 45 %";
            }
            else if (forceOfOccurrence > 85 && forceOfOccurrence < 97)
            {
                // zmniejszamy ilość mieszkańców i chat w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentFour));
                hut.SetQuantityOfHuts((int)(hut.GetQuantityOfHuts() * extentFour));
                return "Niestety twoją osadę odwiedził huragan IV poziomu.\n Liczba twoich mieszkańców i chatek zmiejszyła się o 55 %";
            }
            else
            {
                // zmniejszamy ilość mieszkańców i chat w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentFive));
                hut.SetQuantityOfHuts((int)(hut.GetQuantityOfHuts() * extentFive));
                return "Niestety twoją osadę odwiedził huragan V poziomu.\n Liczba twoich mieszkańców i chatek zmiejszyła się o 80 %";
            }
        }
        /// <summary>
        /// Funkcja okreslajaca szkody choroby
        /// </summary>
        /// <returns></returns>
        public string DestroyByPlague()
        {
            //losujemy stopien katastrofy. Mamy 45 % na I, 25 % na II, 15 % na III, 11 % na IV i 4 % na V stopień
            System.Random rand = new Random();
            int forceOfOccurrence = rand.Next(1, 100);
            // zmieniamy wartość na true, aby katastrofa nie odwiedziła nas ponownie
            ifPlagueHappened = true;
            // określenie skali zniszczeń na podstawie stopnia siły katastrofy
            if (forceOfOccurrence < 46)
            {
                // zmniejszamy ilość osób w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentOne));
                return "Niestety twoją osadę odwiedziła dżuma I poziomu.\n Liczba twoich mieszkańców zmiejszyła się o 10 %";
            }
            else if (forceOfOccurrence > 45 && forceOfOccurrence < 71)
            {
                // zmniejszamy ilość osób w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentTwo));
                return "Niestety twoją osadę odwiedziła dżuma II poziomu.\n Liczba twoich mieszkańców zmiejszyła się o 25 %";
            }
            else if (forceOfOccurrence > 70 && forceOfOccurrence < 86)
            {
                // zmniejszamy ilość osób w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentThree));
                return "Niestety twoją osadę odwiedziła dżuma III poziomu.\n Liczba twoich mieszkańców zmiejszyła się o 45 %";
            }
            else if (forceOfOccurrence > 85 && forceOfOccurrence < 97)
            {
                // zmniejszamy ilość osób w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentFour));
                return "Niestety twoją osadę odwiedziła dżuma IV poziomu.\n Liczba twoich mieszkańców zmiejszyła się o 55 %";
            }
            else
            {
                // zmniejszamy ilość osób w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentFive));
                return "Niestety twoją osadę odwiedziła dżuma V poziomu.\n Liczba twoich mieszkańców zmiejszyła się o 80 %";
            }
        }
        /// <summary>
        /// Funkcja okreslajaca szkody trzęsienia ziemi
        /// </summary>
        /// <returns></returns>
        public string DestroyByEarthquake()
        {
            // losujemy stopien katastrofy. Mamy 45 % na I, 25 % na II, 15 % na III, 11 % na IV i 4 % na V stopień
            System.Random rand = new Random();
            int forceOfOccurrence = rand.Next(1, 100);
            // zmieniamy wartość na true, aby katastrofa nie odwiedziła nas ponownie
            ifEarthquakeHappened = true;
            // określenie skali zniszczeń na podstawie stopnia siły katastrofy
            if (forceOfOccurrence < 46)
            {
                // zmniejszamy zasoby o szkody w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentOne));
                this.SetGold((int)(this.GetGold() * extentOne));
                this.SetWood((int)(this.GetWood() * extentOne));
                this.SetStone((int)(this.GetStone() * extentOne));
                this.SetSand((int)(this.GetSand() * extentOne));
                this.SetClay((int)(this.GetClay() * extentOne));
                return "Niestety twoją osadę odwiedziło trzęsienie ziemi I poziomu.\n Twoje zasoby i mieszkańcy zmiejszyły się o 10 %";
            } else if (forceOfOccurrence > 45 && forceOfOccurrence < 71)
            {
                // zmniejszamy zasoby o szkody w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentTwo));
                this.SetGold((int)(this.GetGold() * extentTwo));
                this.SetWood((int)(this.GetWood() * extentTwo));
                this.SetStone((int)(this.GetStone() * extentTwo));
                this.SetSand((int)(this.GetSand() * extentTwo));
                this.SetClay((int)(this.GetClay() * extentTwo));
                return "Niestety twoją osadę odwiedziło trzęsienie ziemi II poziomu.\n Twoje zasoby i mieszkańcy zmiejszyły się o 25 %";
            }
            else if(forceOfOccurrence > 70 && forceOfOccurrence < 86)
            {
                // zmniejszamy zasoby o szkody w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentThree));
                this.SetGold((int)(this.GetGold() * extentThree));
                this.SetWood((int)(this.GetWood() * extentThree));
                this.SetStone((int)(this.GetStone() * extentThree));
                this.SetSand((int)(this.GetSand() * extentThree));
                this.SetClay((int)(this.GetClay() * extentThree));
                return "Niestety twoją osadę odwiedziło trzęsienie ziemi III poziomu.\n Twoje zasoby i mieszkańcy zmiejszyły się o 45 %";
            }
            else if(forceOfOccurrence > 85 && forceOfOccurrence < 97)
            {
                // zmniejszamy zasoby o szkody w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentFour));
                this.SetGold((int)(this.GetGold() * extentFour));
                this.SetWood((int)(this.GetWood() * extentFour));
                this.SetStone((int)(this.GetStone() * extentFour));
                this.SetSand((int)(this.GetSand() * extentFour));
                this.SetClay((int)(this.GetClay() * extentFour));
                return "Niestety twoją osadę odwiedziło trzęsienie ziemi IV poziomu.\n Twoje zasoby i mieszkańcy zmiejszyły się o 55 %";
            }
            else
            {
                // zmniejszamy zasoby o szkody w zależności od stopnia katastrofy
                hut.SetQuantityOfPeople((int)(hut.GetQuantityOfPeople() * extentFive));
                this.SetGold((int)(this.GetGold() * extentFive));
                this.SetWood((int)(this.GetWood() * extentFive));
                this.SetStone((int)(this.GetStone() * extentFive));
                this.SetSand((int)(this.GetSand() * extentFive));
                this.SetClay((int)(this.GetClay() * extentFive));
                return "Niestety twoją osadę odwiedziło trzęsienie ziemi V poziomu.\n Twoje zasoby i mieszkańcy zmiejszyły się o 80 %";
            }
        }
        /// <summary>
        /// Funkcja aktualizująca zasoby 
        /// </summary>
        public void updateStock()
        {
            // sprawdzamy czy mieścimy się w magazynie
            if(this.GetGold() + goldMine.GetSpeedOfProduction() + church.GetBonusToSpeedProduction() > depot.GetMaxGold() == false)
            {
                // jeśli tak to dodajemy do zasobów w zależności od prędkości produkcji i tego czy mamy wybudowany kościół
                this.SetGold(this.GetGold() + goldMine.GetSpeedOfProduction() + church.GetBonusToSpeedProduction());
            }
            // sprawdzamy czy mieścimy się w magazynie
            if (this.GetWood() + sawmill.GetSpeedOfProduction() + church.GetBonusToSpeedProduction() > depot.GetMaxWood() == false)
            {
                // jeśli tak to dodajemy do zasobów w zależności od prędkości produkcji i tego czy mamy wybudowany kościół
                this.SetWood(this.GetWood() + sawmill.GetSpeedOfProduction() + church.GetBonusToSpeedProduction());
            }
            // sprawdzamy czy mieścimy się w magazynie
            if (this.GetClay() + clayMine.GetSpeedOfProduction() + church.GetBonusToSpeedProduction() > depot.GetMaxClay() == false)
            {
                // jeśli tak to dodajemy do zasobów w zależności od prędkości produkcji i tego czy mamy wybudowany kościół
                this.SetClay(this.GetClay() + clayMine.GetSpeedOfProduction() + church.GetBonusToSpeedProduction());
            }
            // sprawdzamy czy mieścimy się w magazynie
            if (this.GetSand() + gravel.GetSpeedOfProduction() + church.GetBonusToSpeedProduction() > depot.GetMaxSand() == false)
            {
                // jeśli tak to dodajemy do zasobów w zależności prędkości produkcji i tego czy mamy wybudowany kościół
                this.SetSand(this.GetSand() + gravel.GetSpeedOfProduction() + church.GetBonusToSpeedProduction());
            }
            // sprawdzamy czy mieścimy się w magazynie
            if (this.GetStone() + stoneMine.GetSpeedOfProduction() + church.GetBonusToSpeedProduction() > depot.GetMaxClay() == false)
            {
                // jeśli tak to dodajemy do zasobów w zależności od prędkości produkcji i tego czy mamy wybudowany kościół
                this.SetStone(this.GetStone() + stoneMine.GetSpeedOfProduction() + church.GetBonusToSpeedProduction());
            }
        }
    }
}
