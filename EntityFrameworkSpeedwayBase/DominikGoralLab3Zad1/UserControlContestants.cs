using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DominikGoralLab3Zad1
{
    /// <summary>
    /// klasa okienko kontroler, możemy dzięki niej wyświetlać wiele scen w jednym okienku, to wyświetla nam sekcje zawodników
    /// </summary>
    public partial class UserControlContestants : UserControl
    {
        // zadeklarowanie zmiennej do łączenia z bazą
        SqlConnection connection;
        // konstruktor, inicjacja podstawowego stamu programu
        public UserControlContestants()
        {
            InitializeComponent();
            // ustawienie koloru tła
            this.BackColor = Color.FromArgb(181, 178, 175);
            // połączenie z bazą
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }
        /// <summary>
        /// oprogramowanie przycisku do pokazywania zawodnikow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            // ustalenie na których danych będziemy pracować
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT FirstName, Surname, Age, Position FROM Contestants", connection);
            // tworzymy tabele
            DataTable table = new DataTable();
            // wpisujemy dane do tabeli
            dataAdapter.Fill(table);
            // wyświetlenie tabeli na ekranie
            dataGridViewData.DataSource = table;
        }
        /// <summary>
        /// oprogramowanie przycisku służącego do wyświetlenia okienka w którym możemy dodąc zawodnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddContestant_Click(object sender, EventArgs e)
        {
            // ukrycie/ odkrycie komponentów
            FormAddContestant objFormAddContestant = new FormAddContestant();
            this.Hide();
            objFormAddContestant.Show();
        }
        /// <summary>
        /// oprogramowanie przycisku do wyświetlania zawodników wraz z ich klubami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateTeam_Click(object sender, EventArgs e)
        {
            // ustalenie na których danych będziemy pracować
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Contestants.FirstName, Contestants.Surname, Teams.Name FROM Contestants JOIN Teams ON Contestants.TeamID = Teams.ID", connection);
            // tworzymy tabele
            DataTable table = new DataTable();
            // wpisujemy dane do tabeli
            dataAdapter.Fill(table);
            // wyświetlenie tabeli na ekranie
            dataGridViewData.DataSource = table;
        }
    }
}
