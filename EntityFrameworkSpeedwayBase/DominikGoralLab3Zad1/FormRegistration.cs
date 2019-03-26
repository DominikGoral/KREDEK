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
    /// klasa okienko rejestracji
    /// </summary>
    public partial class FormRegistration : Form
    {
        // utworzenie zmiennej do łączenia z bazą
        SqlConnection connection;
        // konstruktor, inicjacja podstawowego stamu programu
        public FormRegistration()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(181, 178, 175);
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");

        }
        /// <summary>
        /// oprogramowanie przycisku służącego do stworzenia profilu kibica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // wybranie na których danych pracujemy
            SqlCommand command = new SqlCommand(@"INSERT INTO Supporters(Login, Password, FirstName, Surname, FavouriteTeam, FavouriteContestant) VALUES (@Login, @Password, @FirstName,@Surname,@FavouriteTeam,@FavouriteContestant)", connection);
            // Dodanie parametrów kwerendy
            command.Parameters.Add("@Login", SqlDbType.NVarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = textBoxSurname.Text;
            command.Parameters.Add("@FavouriteTeam", SqlDbType.NVarChar).Value = textBoxFavouriteTeam.Text;
            command.Parameters.Add("@FavouriteContestant", SqlDbType.NVarChar).Value = textBoxFavouriteContestant.Text;
            // wykonanie komendy
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            // ukrycie/ odkrycie komponentów
            FormLogin objFormLogin = new FormLogin();
            this.Hide();
            objFormLogin.Show();
        }

    }
}
