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
    /// klasa okienko kontroler, możemy dzięki niej wyświetlać wiele scen w jednym okienku, to wyświetla nam sekcje wyników zawodników
    /// </summary>
    public partial class UserControlContestantResult : UserControl
    {
        // zadeklarowane zmiennej do łączenia z bazą 
        SqlConnection connection;
        // konstruktor, inicjacja podstawowego stamu programu
        public UserControlContestantResult()
        {
            InitializeComponent();
            // połączenie z bazą
            this.BackColor = Color.FromArgb(181, 178, 175);
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }

        private void buttonAddResults_Click(object sender, EventArgs e)
        {
            // ukrycie/ odkrycie komponentów
            FormAddResults objAddResults = new FormAddResults();
            objAddResults.Show();
            this.Hide();
        }
        /// <summary>
        /// oprogramowanie przycisku służącego do wyświetlenia wszystkich wartości z tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowContestantResult_Click(object sender, EventArgs e)
        {
            // ustalenie na których danych będziemy pracować
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Contestants.FirstName, Contestants.Surname, ContestantsResult.FirstHeat, ContestantsResult.SecondHeat, ContestantsResult.ThirdHeat, ContestantsResult.FourthHeat, ContestantsResult.FifthHeat FROM ContestantsResult JOIN Contestants ON ContestantsResult.ContestantID = Contestants.ID", connection);
            DataTable table = new DataTable();
            // wypełnienie tablicy
            dataAdapter.Fill(table);
            // wyświetlenie tabeli na ekranie
            dataGridViewContestantsResult.DataSource = table;
        }
    }
}
