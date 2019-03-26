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
    /// klasa okienko do dodawania zawodnikow
    /// </summary>
    public partial class FormAddContestant : Form
    {
        // inicjalizacja zmiennej do połączenia z bazą danych
        SqlConnection connection;
        /// <summary>
        /// konstruktor, zainicjowanie podstawowych wartości
        /// </summary>
        public FormAddContestant()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(181, 178, 175);
            // połączenie z bazą danych
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }
        /// <summary>
        /// oprogramowanie przycisku do dodawania zawodnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // wybranie na których danych pracujemy 
            SqlCommand command = new SqlCommand(@"INSERT INTO Contestants(FirstName, Surname, Age, Position, TeamID) VALUES (@FirstName, @Surname, @Age, @Position, @TeamID)", connection);
            // Dodanie wartości do kwerendy
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = textBoxSurname.Text;
            command.Parameters.Add("@Age", SqlDbType.Int).Value = Int32.Parse(textBoxAge.Text);
            command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = comboBoxPosition.Text;
            command.Parameters.Add("@TeamID", SqlDbType.Int).Value = Int32.Parse(comboBoxTeam.Text);
            // wykonanie komendy
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            // zamknięcie obecnego okienka
            this.Close();
        }
    }
}
