using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DominikGoralLab3Zad1
{
    /// <summary>
    /// klasa okienko do dodawania wyników
    /// </summary>
    public partial class FormAddResults : Form
    {
        // inicjalizacja zmiennej do połączenia z bazą danych
        SqlConnection connection;
        // konstruktor, inicjacja podstawowego stamu programu
        public FormAddResults()
        {
            InitializeComponent();
            // ustawienie koloru tła
            this.BackColor = Color.FromArgb(181, 178, 175);
            // konstruktor, inicjacja podstawowego stanu programu
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }
        /// <summary>
        /// oprogramowanie przycisku potwierdź, który dodaje wyniki zawodników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // wybranie na których danych pracujemy 
            SqlCommand command = new SqlCommand(@"INSERT INTO ContestantsResult(MatchID, ContestantID, FirstHeat, SecondHeat, ThirdHeat, FourthHeat, FifthHeat) VALUES (@MatchID, @ContestantID, @FirstHeat, @SecondHeat, @ThirdHeat, @FourthHeat, @FifthHeat)", connection);
            // Dodanie parametrów kwerendy
            command.Parameters.Add("@MatchID", SqlDbType.Int).Value = Int32.Parse(textBoxMatchID.Text);
            command.Parameters.Add("@ContestantID", SqlDbType.Int).Value = Int32.Parse(textBoxContestantID.Text);
            command.Parameters.Add("@FirstHeat", SqlDbType.Int).Value = Int32.Parse(textBoxFirstHeat.Text);
            command.Parameters.Add("@SecondHeat", SqlDbType.Int).Value = Int32.Parse(textBoxSecondHeat.Text);
            command.Parameters.Add("@ThirdHeat", SqlDbType.Int).Value = Int32.Parse(textBoxThirdHeat.Text);
            command.Parameters.Add("@FourthHeat", SqlDbType.Int).Value = Int32.Parse(textBoxFourthHeat.Text);
            command.Parameters.Add("@FifthHeat", SqlDbType.Int).Value = Int32.Parse(textBoxFifthHeat.Text);
            // wykonanie komendy
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            // schowanie okienka
            this.Close();
        }
    }
}
