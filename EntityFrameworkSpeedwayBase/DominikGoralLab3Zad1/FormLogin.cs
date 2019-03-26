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
    /// klasa okienko logowania
    /// </summary>
    public partial class FormLogin : Form
    {
        // zadeklarowanie zmiennej do łączenia się z bazą
        SqlConnection connection;
        // konstruktor, inicjacja podstawowego stamu programu
        public FormLogin()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(181, 178, 175);
            // laczymy sie z baza danych
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }
        /// <summary>
        /// oprogramowanie przycisku login. loguje nas jesli to mozliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            // wybranie na których danych pracujemy
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Supporters WHERE Login = '" + textBoxLogin.Text.Trim() + "' AND Password = '" + textBoxPassword.Text.Trim() + "'", connection);
            // stworzenie tabeli do której wpiszemy dane z naszej bazy
            DataTable table = new DataTable();
            // przypisjemy do tabeli dane z tabeli ( 1- jeśli istnieje, 0- jeśli nie istnieje)
            dataAdapter.Fill(table);
            // jeśli istnieje to się logujemy
            if(table.Rows.Count == 1)
            {
                //odsłonięcie/ przysłonięcie obiektów
                FormMain objectFormMain = new FormMain();
                this.Hide();
                objectFormMain.Show();
            // jeśli nie to mamy komunikat żeby się zalogować
            } else
            {
                // komunikat
                MessageBox.Show("Wprowadź poprawne dane, lub zarejestruj się.");
            }
        }
        /// <summary>
        /// oprogramowanie przycisku zarejestruj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //odsłonięcie/ przysłonięcie obiektów
            FormRegistration objRegistrationForm = new FormRegistration();
            this.Hide();
            objRegistrationForm.Show();
        }
    }
}
