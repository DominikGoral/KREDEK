using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikGoralLab1
{
    public partial class MainForm : Form
    {
        // zmienna przechowująca ilość wybudowanych chatek( potrzebna do uruchomienia przycisku BudujMagazyn
        //( jeśli utworzymy 2 chatki))
        public int counterHut = 0;
        // zmienne przechowujące informacje o czasie, w którym mają wykonać się katastrofy ( są losowane za pomocą funkcji)
        public int hurricaneMinute = 0;
        public int hurricaneHour = 0;
        public int hurricaneDay = 0;
        public int plagueMinute = 0;
        public int plagueHour = 0;
        public int plagueDay = 0;
        public int earthquakeMinute = 0;
        public int earthquakeHour = 0;
        public int earthquakeDay = 0;

        Settlement mySettlement = new Settlement();
        public MainForm()
        {
            // ustawienie warunkow poczatkowych programu (np. ustawienie statusu przycisków, ustawienie labeli)
            InitializeComponent();
            buttonBuildDepot.Enabled = false;
            buttonBuildChurch.Enabled = false;
            buttonBuildGoldMine.Enabled = false;
            buttonBuildSawmill.Enabled = false;
            buttonBuildStoneMine.Enabled = false;
            buttonBuildGravel.Enabled = false;
            buttonBuildClayMine.Enabled = false;
            buttonBuildHut.Enabled = false;
            buttonUpgradeDepot.Enabled = false;
            buttonUpgradeChurch.Enabled = false;
            buttonUpgradeGoldMine.Enabled = false;
            buttonUpgradeSawmill.Enabled = false;
            buttonUpgradeStoneMine.Enabled = false;
            buttonUpgradeGravel.Enabled = false;
            buttonUpgradeClayMine.Enabled = false;
            buttonInfoDepot.Enabled = false;
            buttonInfoChurch.Enabled = false;
            buttonInfoGoldMine.Enabled = false;
            buttonInfoSawmill.Enabled = false;
            buttonInfoStoneMine.Enabled = false;
            buttonInfoGravel.Enabled = false;
            buttonInfoClayMine.Enabled = false;
            buttonInfoHut.Enabled = false;
            pictureBoxDepotOnImage.Visible = false;
            pictureBoxChurchOnImage.Visible = false;
            pictureBoxSawmillOnImage.Visible = false;
            pictureBoxHutOnImage.Visible = false;
            panelCenter.BackColor = Color.Yellow;
            // wyświetlany komunikat
            labelHelper.Text = "Kliknij ,,Start'' aby rozpocząć";
            labelGold.Text = mySettlement.GetGold().ToString() + "/" + mySettlement.depot.GetMaxGold();
            labelWood.Text = mySettlement.GetWood().ToString() + "/" + mySettlement.depot.GetMaxWood();
            labelStone.Text = mySettlement.GetStone().ToString() + "/" + mySettlement.depot.GetMaxStone();
            labelSand.Text = mySettlement.GetSand().ToString() + "/" + mySettlement.depot.GetMaxSand();
            labelClay.Text = mySettlement.GetClay().ToString() + "/" + mySettlement.depot.GetMaxClay();
            labelQuantityOfInhabitants.Text = "Mieszkańcy: " + mySettlement.hut.GetQuantityOfPeople().ToString();
            labelQuantityOfHuts.Text = "Ilość chat: " + mySettlement.hut.GetQuantityOfHuts().ToString();
            labelMinutes.Text = mySettlement.GetMinutes().ToString();
            labelHours.Text = mySettlement.GetHours().ToString();
            labelDays.Text = mySettlement.GetDays().ToString();
            randTimeForHurricane();
            randTimeForPlague();
            randTimeForEarthquake();
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Start"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // aktywacja zegara
            timerCounter.Start();
            // aktywacja/ dezaktywacja przycisków
            buttonBuildHut.Enabled = true;
            buttonStart.Enabled = false;
            buttonInfoDepot.Enabled = true;
            buttonInfoChurch.Enabled = true;
            buttonInfoGoldMine.Enabled = true;
            buttonInfoSawmill.Enabled = true;
            buttonInfoStoneMine.Enabled = true;
            buttonInfoGravel.Enabled = true;
            buttonInfoClayMine.Enabled = true;
            buttonInfoHut.Enabled = true;
            // ustawienie nowej sugestii
            labelHelper.Text = "Wybuduj 2 chatki dla mieszkańców!\nNastępnie zajmij się resztą budynków.";
        }
        /// <summary>
        /// Funkcja aktualizująca wartości w labelach
        /// </summary>
        public void updateValueInLabel()
        {
            // aktualizowanie wartosci zasobow
            labelGold.Text = mySettlement.GetGold().ToString() + "/" + mySettlement.depot.GetMaxGold().ToString();
            labelWood.Text = mySettlement.GetWood().ToString() + "/" + mySettlement.depot.GetMaxWood().ToString();
            labelStone.Text = mySettlement.GetStone().ToString() + "/" + mySettlement.depot.GetMaxStone().ToString();
            labelSand.Text = mySettlement.GetSand().ToString() + "/" + mySettlement.depot.GetMaxSand().ToString();
            labelClay.Text = mySettlement.GetClay().ToString() + "/" + mySettlement.depot.GetMaxClay().ToString();
            // aktualizowanie czasu
            labelMinutes.Text = "Minute: " + mySettlement.GetMinutes().ToString();
            labelHours.Text = "Hour: " + mySettlement.GetHours().ToString();
            labelDays.Text = "Day: " + mySettlement.GetDays().ToString();
            // aktualizowanie liczby chat i mieszkańców
            labelQuantityOfInhabitants.Text = "Mieszkańcy: " + mySettlement.hut.GetQuantityOfPeople().ToString();
            labelQuantityOfHuts.Text = "Ilość chat: " + mySettlement.hut.GetQuantityOfHuts().ToString();
        }
        // ustawienie koloru paneli
        private void panelUp_Paint(object sender, PaintEventArgs e)
        {
            panelUp.BackColor = Color.FromArgb(188, 169, 116);
        }

        private void panelDown_Paint(object sender, PaintEventArgs e)
        {
            panelDown.BackColor = Color.FromArgb(188, 169, 116);
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
            panelRight.BackColor = Color.FromArgb(188, 169, 116);
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
            panelLeft.BackColor = Color.FromArgb(188, 169, 116);
        }
        /// <summary>
        /// Funkcja losująca czas w którym ma wystąpić huragan
        /// </summary>
        public void randTimeForHurricane()
        {
            System.Random rand = new Random();
            // ustawienie czasu dla huraganu
            hurricaneMinute= rand.Next(0, 60);
            hurricaneHour = rand.Next(0, 24);
            hurricaneDay = rand.Next(3, 6);
        }
        /// <summary>
        /// Funkcja losująca czas w którym ma wystąpić choroba
        /// </summary>
        public void randTimeForPlague()
        {
            System.Random rand = new Random();
            // ustawienie czasu dla choroby
            plagueMinute = rand.Next(0, 60);
            plagueHour = rand.Next(0, 24);
            plagueDay = rand.Next(6, 9);
        }
        /// <summary>
        /// Funkcja losująca czas w którym ma wystąpić trzęsienie ziemi
        /// </summary>
        public void randTimeForEarthquake()
        {
            System.Random rand = new Random();
            // ustawienie czasu dla trzęsienia ziemi
            earthquakeMinute = rand.Next(0, 60);
            earthquakeHour = rand.Next(0, 24);
            earthquakeDay = rand.Next(8, 15);
        }
        /// <summary>
        /// Funkcja zawierająca zegar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            // ustawienie czasu tykniecia zegara
            timerCounter.Interval = 50;
            mySettlement.minutes++;
            // dodawanie godzin i dni w zależności od minut i godzin
            if(mySettlement.minutes > 59)
            {
                mySettlement.minutes = 0;
                mySettlement.hours++;
            }
            if(mySettlement.hours > 23)
            {
                mySettlement.hours = 0;
                mySettlement.days++;
            }
            // wywolanie huraganu, jesli czas obecny zgadza sie z wylosowanymi wartosciami
            if(mySettlement.minutes == hurricaneMinute && mySettlement.hours == hurricaneHour && mySettlement.days == hurricaneDay)
            {
                // wyświetlenie informacji o katastrofie ( jakie szkody)
                MessageBox.Show(mySettlement.DestroyByHurricane());
            }
            // wywolanie choroby, jesli czas obecny zgadza sie z wylosowanymi wartosciami
            if (mySettlement.minutes == plagueMinute && mySettlement.hours == plagueHour && mySettlement.days == plagueDay)
            {
                // wyświetlenie informacji o katastrofie ( jakie szkody)
                MessageBox.Show(mySettlement.DestroyByPlague());
            }
            // wywolanie trzęsienia ziemi, jesli czas obecny zgadza sie z wylosowanymi wartosciami
            if (mySettlement.minutes == earthquakeMinute && mySettlement.hours == earthquakeHour && mySettlement.days == earthquakeDay)
            {
                // wyświetlenie informacji o katastrofie ( jakie szkody)
                MessageBox.Show(mySettlement.DestroyByEarthquake());
            }
            // zaktualizowanie zasobow w magazynie
            mySettlement.updateStock();
            // zaktualizowanie labeli
            updateValueInLabel();

        }
        /// <summary>
        /// wyświetlenie informacji o budynkach ( nazwie, poziomie, zasobach potrzebnych do wybudowania lub ulepszenia)
        /// </summary>
        /// <param name="building"></param>
        public void ShowInfo(Buildings building)
        {
            MessageBox.Show("Nazwa: " + building.GetName() + "\n" + "Poziom: " + building.GetLevel() + "\n" + "Koszt ulepszenia w:\n- złocie: " + building.GetCostGoldOfNextOperation() + "\n- drewnie: " + building.GetCostWoodOfNextOperation() + "\n- kamieniu: " + building.GetCostStoneOfNextOperation() + "\n- piasku: " + building.GetCostSandOfNextOperation() + "\n- glinie: " + building.GetCostClayOfNextOperation());
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Buduj"-> budowanie magazynu,
        /// aktualizowanie wartości zasobów, wyświetlenie komunikatu, aktywacja/ dezaktywacja przyciskow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildDepot_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.depot.Built(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            // poniesienie kosztów operacji
            mySettlement.SetGold(mySettlement.GetGold() - mySettlement.depot.GetCostGold());
            mySettlement.SetWood(mySettlement.GetWood() - mySettlement.depot.GetCostWood());
            mySettlement.SetStone(mySettlement.GetStone() - mySettlement.depot.GetCostStone());
            mySettlement.SetSand(mySettlement.GetSand() - mySettlement.depot.GetCostSand());
            mySettlement.SetClay(mySettlement.GetClay() - mySettlement.depot.GetCostClay());
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // wyświetlenie budynku w osadzie
            pictureBoxDepotOnImage.Visible = true;
            // aktywacja/ dezaktywacja przycisków
            buttonBuildDepot.Enabled = false;
            buttonUpgradeDepot.Enabled = true;
            buttonBuildChurch.Enabled = true;
            buttonBuildGoldMine.Enabled = true;
            // zwiększenie licznika aby móc budować kolejne chaty
            counterHut++;
            // ustawienie nowej sugestii
            labelHelper.Text = "Wybuduj kopalnię złota, by wydobywać złoto!";
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Buduj"-> budowanie kościoła, 
        /// aktualizowanie wartości zasobów, wyświetlenie komunikatu, aktywacja/ dezaktywacja przyciskow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildChurch_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.church.Built(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            // poniesienie kosztów operacji
            mySettlement.SetGold(mySettlement.GetGold() - mySettlement.church.GetCostGold());
            mySettlement.SetWood(mySettlement.GetWood() - mySettlement.church.GetCostWood());
            mySettlement.SetStone(mySettlement.GetStone() - mySettlement.church.GetCostStone());
            mySettlement.SetSand(mySettlement.GetSand() - mySettlement.church.GetCostSand());
            mySettlement.SetClay(mySettlement.GetClay() - mySettlement.church.GetCostClay());
            // sprawdzenie czy budynek istnieje, aby móc aktywować/ dezaktywować przyciski
            if(mySettlement.church.GetIsBuilt() == true)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonBuildChurch.Enabled = false;
                buttonUpgradeChurch.Enabled = true;
                // wyświetlenie budynku w osadzie
                pictureBoxChurchOnImage.Visible = true;
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Buduj"-> budowanie kopalni złota,
        /// aktualizowanie wartości zasobów, wyświetlenie komunikatu, aktywacja/ dezaktywacja przyciskow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildGoldMine_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.goldMine.Built(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            // poniesienie kosztów operacji
            mySettlement.SetGold(mySettlement.GetGold() - mySettlement.goldMine.GetCostGold());
            mySettlement.SetWood(mySettlement.GetWood() - mySettlement.goldMine.GetCostWood());
            mySettlement.SetStone(mySettlement.GetStone() - mySettlement.goldMine.GetCostStone());
            mySettlement.SetSand(mySettlement.GetSand() - mySettlement.goldMine.GetCostSand());
            mySettlement.SetClay(mySettlement.GetClay() - mySettlement.goldMine.GetCostClay());
            // sprawdzenie czy budynek istnieje, aby móc aktywować/ dezaktywować przyciski
            if (mySettlement.goldMine.GetIsBuilt() == true)
            {
                // ustawienie nowej sugestii
                labelHelper.Text = "Wybuduj tartak, by zdobywać drewno!";
                // aktywacja/ dezaktywacja przycisków
                buttonBuildGoldMine.Enabled = false;
                buttonUpgradeGoldMine.Enabled = true;
                buttonBuildSawmill.Enabled = true;
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Buduj"-> budowanie kopalni kamienia,
        /// aktualizowanie wartości zasobów, wyświetlenie komunikatu, aktywacja/ dezaktywacja przyciskow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildStoneMine_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.stoneMine.Built(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            // poniesienie kosztów operacji
            mySettlement.SetGold(mySettlement.GetGold() - mySettlement.stoneMine.GetCostGold());
            mySettlement.SetWood(mySettlement.GetWood() - mySettlement.stoneMine.GetCostWood());
            mySettlement.SetStone(mySettlement.GetStone() - mySettlement.stoneMine.GetCostStone());
            mySettlement.SetSand(mySettlement.GetSand() - mySettlement.stoneMine.GetCostSand());
            mySettlement.SetClay(mySettlement.GetClay() - mySettlement.stoneMine.GetCostClay());
            // sprawdzenie czy budynek istnieje, aby móc aktywować/ dezaktywować przyciski
            if (mySettlement.stoneMine.GetIsBuilt() == true)
            {
                // ustawienie nowej sugestii
                labelHelper.Text = "Wybuduj żwirownię, by wydobywać piasek!";
                // aktywacja/ dezaktywacja przycisków
                buttonBuildStoneMine.Enabled = false;
                buttonUpgradeStoneMine.Enabled = true;
                buttonBuildGravel.Enabled = true;
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Buduj"-> budowanie tartaku,
        /// aktualizowanie wartości zasobów, wyświetlenie komunikatu, aktywacja/ dezaktywacja przyciskow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildSawmill_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.sawmill.Built(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            // poniesienie kosztów operacji
            mySettlement.SetGold(mySettlement.GetGold() - mySettlement.sawmill.GetCostGold());
            mySettlement.SetWood(mySettlement.GetWood() - mySettlement.sawmill.GetCostWood());
            mySettlement.SetStone(mySettlement.GetStone() - mySettlement.sawmill.GetCostStone());
            mySettlement.SetSand(mySettlement.GetSand() - mySettlement.sawmill.GetCostSand());
            mySettlement.SetClay(mySettlement.GetClay() - mySettlement.sawmill.GetCostClay());
            // sprawdzenie czy budynek istnieje, aby móc aktywować/ dezaktywować przyciski
            if (mySettlement.sawmill.GetIsBuilt() == true)
            {
                // wyświetlenie budynku w osadzie
                pictureBoxSawmillOnImage.Visible = true;
                // ustawienie nowej sugestii
                labelHelper.Text = "Wybuduj kopalnię kamieni, by wydobywać kamień!";
                // aktywacja/ dezaktywacja przycisków
                buttonBuildSawmill.Enabled = false;
                buttonUpgradeSawmill.Enabled = true;
                buttonBuildStoneMine.Enabled = true;
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Buduj"-> budowanie kopalni gliny,
        /// aktualizowanie wartości zasobów, wyświetlenie komunikatu, aktywacja/ dezaktywacja przyciskow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildClayMine_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.clayMine.Built(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            // poniesienie kosztów operacji
            mySettlement.SetGold(mySettlement.GetGold() - mySettlement.clayMine.GetCostGold());
            mySettlement.SetWood(mySettlement.GetWood() - mySettlement.clayMine.GetCostWood());
            mySettlement.SetStone(mySettlement.GetStone() - mySettlement.clayMine.GetCostStone());
            mySettlement.SetSand(mySettlement.GetSand() - mySettlement.clayMine.GetCostSand());
            mySettlement.SetClay(mySettlement.GetClay() - mySettlement.clayMine.GetCostClay());
            // sprawdzenie czy budynek istnieje, aby móc aktywować/ dezaktywować przyciski
            if (mySettlement.clayMine.GetIsBuilt() == true)
            {
                // ustawienie nowej sugestii
                labelHelper.Text = "Prawie wszystko jest już wybudowane!\nTeraz może spróbuj coś ulepszyć...";
                // aktywacja/ dezaktywacja przycisków
                buttonBuildClayMine.Enabled = false;
                buttonUpgradeClayMine.Enabled = true;
                buttonBuildHut.Enabled = true;
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Buduj"-> budowanie żwirowni,
        /// aktualizowanie wartości zasobów, wyświetlenie komunikatu, aktywacja/ dezaktywacja przyciskow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildGravel_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.gravel.Built(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            // poniesienie kosztów operacji
            mySettlement.SetGold(mySettlement.GetGold() - mySettlement.gravel.GetCostGold());
            mySettlement.SetWood(mySettlement.GetWood() - mySettlement.gravel.GetCostWood());
            mySettlement.SetStone(mySettlement.GetStone() - mySettlement.gravel.GetCostStone());
            mySettlement.SetSand(mySettlement.GetSand() - mySettlement.gravel.GetCostSand());
            mySettlement.SetClay(mySettlement.GetClay() - mySettlement.gravel.GetCostClay());
            // sprawdzenie czy budynek istnieje, aby móc aktywować/ dezaktywować przyciski
            if (mySettlement.gravel.GetIsBuilt() == true)
            {
                // ustawienie nowej sugestii
                labelHelper.Text = "Wybuduj kopalnię gliny, by wydobywać glinę!";
                // aktywacja/ dezaktywacja przycisków
                buttonBuildGravel.Enabled = false;
                buttonUpgradeGravel.Enabled = true;
                buttonBuildClayMine.Enabled = true;
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Buduj"-> budowanie chatki,
        /// aktualizowanie wartości zasobów, wyświetlenie komunikatu, aktywacja/ dezaktywacja przyciskow, wyswietlenie chatki na srodkowym panelu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildHut_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.hut.Built(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            // poniesienie kosztów operacji
            mySettlement.SetGold(mySettlement.GetGold() - mySettlement.hut.GetCostGold());
            mySettlement.SetWood(mySettlement.GetWood() - mySettlement.hut.GetCostWood());
            mySettlement.SetStone(mySettlement.GetStone() - mySettlement.hut.GetCostStone());
            mySettlement.SetSand(mySettlement.GetSand() - mySettlement.hut.GetCostSand());
            mySettlement.SetClay(mySettlement.GetClay() - mySettlement.hut.GetCostClay());
            // wyświetlenie budynku w osadzie
            pictureBoxHutOnImage.Visible = true;
            // zwiększenie licznika chat
            counterHut++;
            // potrzebujemy mieszkańców do pracy, więc dopiero po wybudowaniu chat( z mieszkańcami) możemy budować inne obiekty
            if(counterHut > 1 && counterHut < 3)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonBuildHut.Enabled = false;
                buttonBuildDepot.Enabled = true;
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // ustawienie nowej sugestii
            labelHelper.Text = "Wybuduj magazyn, będziesz mógł przechowywać w nim swoje zasoby.";
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Info"-> wyswietlenie informacji o obiekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoDepot_Click(object sender, EventArgs e)
        {
            ShowInfo(mySettlement.depot);
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Info"-> wyswietlenie informacji o obiekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoChurch_Click(object sender, EventArgs e)
        {
            ShowInfo(mySettlement.church);
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Info"-> wyswietlenie informacji o obiekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoGoldMine_Click(object sender, EventArgs e)
        {
            ShowInfo(mySettlement.goldMine);
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Info"-> wyswietlenie informacji o obiekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoStoneMine_Click(object sender, EventArgs e)
        {
            ShowInfo(mySettlement.stoneMine);
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Info"-> wyswietlenie informacji o obiekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoSawmill_Click(object sender, EventArgs e)
        {
            ShowInfo(mySettlement.sawmill);
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Info"-> wyswietlenie informacji o obiekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoClayMine_Click(object sender, EventArgs e)
        {
            ShowInfo(mySettlement.clayMine);
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Info"-> wyswietlenie informacji o obiekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoGravel_Click(object sender, EventArgs e)
        {
            ShowInfo(mySettlement.gravel);
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Info"-> wyswietlenie informacji o obiekcie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfoHut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wybuduj chatki dla mieszkańców!\nAby to zrobić potrzebujesz:\n- złoto: " + mySettlement.hut.GetCostGold() + "\n- drewno: " + mySettlement.hut.GetCostWood() + "\n- kamień: " + mySettlement.hut.GetCostStone() + "\n- piasek: " + mySettlement.hut.GetCostSand() + "\n- glina: " + mySettlement.hut.GetCostClay());
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Upgrade"-> ulepszenie budynku,
        /// aktualizacja zasobów, wyświetlenie komunikatu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeDepot_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.depot.Upgrade(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            /* Metoda powyżej jeśli się wywoła ( zależy czy mamy odpowiednią ilość zasobów) zmienia nam wartość
            * zmiennej isAbleToUpgrade na true. Wówczas warunek poniżej odejmuje nam od naszych zasobów
            * koszty poniesienia operacji. Po poniesieniu kosztów operacji ustawiamy wartość zmiennej isAbleToUpgrade na false,
            * przygotowując ją na jej ewentualne kolejne wywołanie.
            */
            if (mySettlement.depot.GetIsAbleToUpgrade() == true)
            {
                // poniesienie kosztów operacji
                mySettlement.SetGold(mySettlement.GetGold() - mySettlement.depot.GetCostGold());
                mySettlement.SetWood(mySettlement.GetWood() - mySettlement.depot.GetCostWood());
                mySettlement.SetStone(mySettlement.GetStone() - mySettlement.depot.GetCostStone());
                mySettlement.SetSand(mySettlement.GetSand() - mySettlement.depot.GetCostSand());
                mySettlement.SetClay(mySettlement.GetClay() - mySettlement.depot.GetCostClay());
                // ustawienie nowej sugestii
                labelHelper.Text = "Udało się ! Jesteś już gotowy na samodzielną rozgrywkę.\nPowodzenia!";
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // ustawiamy wartość zmiennej isAbleToUpgrade na false, przygotowując ją na jej ewentualne kolejne wywołanie
            mySettlement.depot.SetIsAbleToUpgrade(false);
            // sprawdzenie czy budynek jest maksymalnie ulepszony-> można wtedy dezaktywować przycisk ,, Ulepsz"
            if (mySettlement.depot.GetLevel() > 4)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonUpgradeDepot.Enabled = false;
            }
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Upgrade"-> ulepszenie budynku,
        /// aktualizacja zasobów, wyświetlenie komunikatu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeChurch_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.church.Upgrade(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            /* Metoda powyżej jeśli się wywoła ( zależy czy mamy odpowiednią ilość zasobów) zmienia nam wartość
            * zmiennej isAbleToUpgrade na true. Wówczas warunek poniżej odejmuje nam od naszych zasobów
            * koszty poniesienia operacji. Po poniesieniu kosztów operacji ustawiamy wartość zmiennej isAbleToUpgrade na false,
            * przygotowując ją na jej ewentualne kolejne wywołanie.
            */
            if (mySettlement.church.GetIsAbleToUpgrade() == true)
            {
                // poniesienie kosztów operacji
                mySettlement.SetGold(mySettlement.GetGold() - mySettlement.church.GetCostGold());
                mySettlement.SetWood(mySettlement.GetWood() - mySettlement.church.GetCostWood());
                mySettlement.SetStone(mySettlement.GetStone() - mySettlement.church.GetCostStone());
                mySettlement.SetSand(mySettlement.GetSand() - mySettlement.church.GetCostSand());
                mySettlement.SetClay(mySettlement.GetClay() - mySettlement.church.GetCostClay());
                // ustawienie nowej sugestii
                labelHelper.Text = "Udało się ! Jesteś już gotowy na samodzielną rozgrywkę.\nPowodzenia!";
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // ustawiamy wartość zmiennej isAbleToUpgrade na false, przygotowując ją na jej ewentualne kolejne wywołanie
            mySettlement.church.SetIsAbleToUpgrade(false);
            // sprawdzenie czy budynek jest maksymalnie ulepszony-> można wtedy dezaktywować przycisk ,, Ulepsz"
            if (mySettlement.church.GetLevel() > 4)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonUpgradeChurch.Enabled = false;
            }
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Upgrade"-> ulepszenie budynku,
        /// aktualizacja zasobów, wyświetlenie komunikatu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeGoldMine_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.goldMine.Upgrade(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            /* Metoda powyżej jeśli się wywoła ( zależy czy mamy odpowiednią ilość zasobów) zmienia nam wartość
            * zmiennej isAbleToUpgrade na true. Wówczas warunek poniżej odejmuje nam od naszych zasobów
            * koszty poniesienia operacji. Po poniesieniu kosztów operacji ustawiamy wartość zmiennej isAbleToUpgrade na false,
            * przygotowując ją na jej ewentualne kolejne wywołanie.
            */
            if (mySettlement.goldMine.GetIsAbleToUpgrade() == true)
            {
                // poniesienie kosztów operacji
                mySettlement.SetGold(mySettlement.GetGold() - mySettlement.goldMine.GetCostGold());
                mySettlement.SetWood(mySettlement.GetWood() - mySettlement.goldMine.GetCostWood());
                mySettlement.SetStone(mySettlement.GetStone() - mySettlement.goldMine.GetCostStone());
                mySettlement.SetSand(mySettlement.GetSand() - mySettlement.goldMine.GetCostSand());
                mySettlement.SetClay(mySettlement.GetClay() - mySettlement.goldMine.GetCostClay());
                // ustawienie nowej sugestii
                labelHelper.Text = "Udało się ! Jesteś już gotowy na samodzielną rozgrywkę.\nPowodzenia!";
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // ustawiamy wartość zmiennej isAbleToUpgrade na false, przygotowując ją na jej ewentualne kolejne wywołanie
            mySettlement.goldMine.SetIsAbleToUpgrade(false);
            // sprawdzenie czy budynek jest maksymalnie ulepszony-> można wtedy dezaktywować przycisk ,, Ulepsz"
            if (mySettlement.goldMine.GetLevel() > 4)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonUpgradeGoldMine.Enabled = false;
            }
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Upgrade"-> ulepszenie budynku,
        /// aktualizacja zasobów, wyświetlenie komunikatu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeStoneMine_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.stoneMine.Upgrade(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            /* Metoda powyżej jeśli się wywoła ( zależy czy mamy odpowiednią ilość zasobów) zmienia nam wartość
            * zmiennej isAbleToUpgrade na true. Wówczas warunek poniżej odejmuje nam od naszych zasobów
            * koszty poniesienia operacji. Po poniesieniu kosztów operacji ustawiamy wartość zmiennej isAbleToUpgrade na false,
            * przygotowując ją na jej ewentualne kolejne wywołanie.
            */
            if (mySettlement.stoneMine.GetIsAbleToUpgrade() == true)
            {
                // poniesienie kosztów operacji
                mySettlement.SetGold(mySettlement.GetGold() - mySettlement.stoneMine.GetCostGold());
                mySettlement.SetWood(mySettlement.GetWood() - mySettlement.stoneMine.GetCostWood());
                mySettlement.SetStone(mySettlement.GetStone() - mySettlement.stoneMine.GetCostStone());
                mySettlement.SetSand(mySettlement.GetSand() - mySettlement.stoneMine.GetCostSand());
                mySettlement.SetClay(mySettlement.GetClay() - mySettlement.stoneMine.GetCostClay());
                // ustawienie nowej sugestii
                labelHelper.Text = "Udało się ! Jesteś już gotowy na samodzielną rozgrywkę.\nPowodzenia!";
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // ustawiamy wartość zmiennej isAbleToUpgrade na false, przygotowując ją na jej ewentualne kolejne wywołanie
            mySettlement.stoneMine.SetIsAbleToUpgrade(false);
            // sprawdzenie czy budynek jest maksymalnie ulepszony-> można wtedy dezaktywować przycisk ,, Ulepsz"
            if (mySettlement.stoneMine.GetLevel() > 4)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonUpgradeStoneMine.Enabled = false;
            }
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Upgrade"-> ulepszenie budynku,
        /// aktualizacja zasobów, wyświetlenie komunikatu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeSawmill_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.sawmill.Upgrade(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            /* Metoda powyżej jeśli się wywoła ( zależy czy mamy odpowiednią ilość zasobów) zmienia nam wartość
            * zmiennej isAbleToUpgrade na true. Wówczas warunek poniżej odejmuje nam od naszych zasobów
            * koszty poniesienia operacji. Po poniesieniu kosztów operacji ustawiamy wartość zmiennej isAbleToUpgrade na false,
            * przygotowując ją na jej ewentualne kolejne wywołanie.
            */
            if (mySettlement.sawmill.GetIsAbleToUpgrade() == true)
            {
                // poniesienie kosztów operacji
                mySettlement.SetGold(mySettlement.GetGold() - mySettlement.sawmill.GetCostGold());
                mySettlement.SetWood(mySettlement.GetWood() - mySettlement.sawmill.GetCostWood());
                mySettlement.SetStone(mySettlement.GetStone() - mySettlement.sawmill.GetCostStone());
                mySettlement.SetSand(mySettlement.GetSand() - mySettlement.sawmill.GetCostSand());
                mySettlement.SetClay(mySettlement.GetClay() - mySettlement.sawmill.GetCostClay());
                // ustawienie nowej sugestii
                labelHelper.Text = "Udało się ! Jesteś już gotowy na samodzielną rozgrywkę.\nPowodzenia!";
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // ustawiamy wartość zmiennej isAbleToUpgrade na false, przygotowując ją na jej ewentualne kolejne wywołanie
            mySettlement.sawmill.SetIsAbleToUpgrade(false);
            // sprawdzenie czy budynek jest maksymalnie ulepszony-> można wtedy dezaktywować przycisk ,, Ulepsz"
            if (mySettlement.sawmill.GetLevel() > 4)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonUpgradeSawmill.Enabled = false;
            }
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Upgrade"-> ulepszenie budynku,
        /// aktualizacja zasobów, wyświetlenie komunikatu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeClayMine_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.clayMine.Upgrade(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            /* Metoda powyżej jeśli się wywoła ( zależy czy mamy odpowiednią ilość zasobów) zmienia nam wartość
            * zmiennej isAbleToUpgrade na true. Wówczas warunek poniżej odejmuje nam od naszych zasobów
            * koszty poniesienia operacji. Po poniesieniu kosztów operacji ustawiamy wartość zmiennej isAbleToUpgrade na false,
            * przygotowując ją na jej ewentualne kolejne wywołanie.
            */
            if (mySettlement.clayMine.GetIsAbleToUpgrade() == true)
            {
                // poniesienie kosztów operacji
                mySettlement.SetGold(mySettlement.GetGold() - mySettlement.clayMine.GetCostGold());
                mySettlement.SetWood(mySettlement.GetWood() - mySettlement.clayMine.GetCostWood());
                mySettlement.SetStone(mySettlement.GetStone() - mySettlement.clayMine.GetCostStone());
                mySettlement.SetSand(mySettlement.GetSand() - mySettlement.clayMine.GetCostSand());
                mySettlement.SetClay(mySettlement.GetClay() - mySettlement.clayMine.GetCostClay());
                // ustawienie nowej sugestii
                labelHelper.Text = "Udało się ! Jesteś już gotowy na samodzielną rozgrywkę.\nPowodzenia!";
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // ustawiamy wartość zmiennej isAbleToUpgrade na false, przygotowując ją na jej ewentualne kolejne wywołanie
            mySettlement.clayMine.SetIsAbleToUpgrade(false);
            // sprawdzenie czy budynek jest maksymalnie ulepszony-> można wtedy dezaktywować przycisk ,, Ulepsz"
            if (mySettlement.clayMine.GetLevel() > 4)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonUpgradeClayMine.Enabled = false;
            }
        }
        /// <summary>
        /// Ustawienie zadań wykonujących się po kliknięciu przycisku ,, Upgrade"-> ulepszenie budynku,
        /// aktualizacja zasobów, wyświetlenie komunikatu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeGravel_Click(object sender, EventArgs e)
        {
            // wyświetlenie informacji o powodzeniu lub niepowodzeniu działania
            MessageBox.Show(mySettlement.gravel.Upgrade(mySettlement.GetGold(), mySettlement.GetWood(), mySettlement.GetStone(), mySettlement.GetSand(), mySettlement.GetClay()));
            /* Metoda powyżej jeśli się wywoła ( zależy czy mamy odpowiednią ilość zasobów) zmienia nam wartość
            * zmiennej isAbleToUpgrade na true. Wówczas warunek poniżej odejmuje nam od naszych zasobów
            * koszty poniesienia operacji. Po poniesieniu kosztów operacji ustawiamy wartość zmiennej isAbleToUpgrade na false,
            * przygotowując ją na jej ewentualne kolejne wywołanie.
            */ 
            if (mySettlement.gravel.GetIsAbleToUpgrade() == true)
            {
                // poniesienie kosztów operacji
                mySettlement.SetGold(mySettlement.GetGold() - mySettlement.gravel.GetCostGold());
                mySettlement.SetWood(mySettlement.GetWood() - mySettlement.gravel.GetCostWood());
                mySettlement.SetStone(mySettlement.GetStone() - mySettlement.gravel.GetCostStone());
                mySettlement.SetSand(mySettlement.GetSand() - mySettlement.gravel.GetCostSand());
                mySettlement.SetClay(mySettlement.GetClay() - mySettlement.gravel.GetCostClay());
                // ustawienie nowej sugestii
                labelHelper.Text = "Udało się ! Jesteś już gotowy na samodzielną rozgrywkę.\nPowodzenia!";
            }
            // aktualizowanie zasobów w labelach
            updateValueInLabel();
            // ustawiamy wartość zmiennej isAbleToUpgrade na false, przygotowując ją na jej ewentualne kolejne wywołanie
            mySettlement.gravel.SetIsAbleToUpgrade(false);
            // sprawdzenie czy budynek jest maksymalnie ulepszony-> można wtedy dezaktywować przycisk ,, Ulepsz"
            if (mySettlement.gravel.GetLevel() > 4)
            {
                // aktywacja/ dezaktywacja przycisków
                buttonUpgradeGravel.Enabled = false;
            }
        }
    }
}
