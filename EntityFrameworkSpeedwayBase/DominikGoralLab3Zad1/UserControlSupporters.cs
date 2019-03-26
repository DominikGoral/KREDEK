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
    /// klasa okienko kontroler, możemy dzięki niej wyświetlać wiele scen w jednym okienku, to wyświetla nam sekcje kibiców
    /// </summary>
    public partial class UserControlSupporters : UserControl
    {
        // zadeklarowanie zmiennej do łączenia z bazą
        SqlConnection connection;
        // zadeklarowanie zmiennej do przechowywania loginu kibica, którego chcemy usunąć
        String login;
        // konstruktor, inicjacja podstawowego stamu programu
        public UserControlSupporters()
        {
            InitializeComponent();
            // ustalenie koloru tła
            this.BackColor = Color.FromArgb(181, 178, 175);
            // połączenie z bazą
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }
        /// <summary>
        /// oprogramowanie przycisku służącego do wyświetlenia wszystkich wartości z tabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowSupporters_Click(object sender, EventArgs e)
        {
            // ustalenie na których danych będziemy pracować
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Login, FirstName, Surname, FavouriteTeam, FavouriteContestant FROM Supporters", connection);
            DataTable table = new DataTable();
            // wypełnienie tablicy
            dataAdapter.Fill(table);
            // wyświetlenie tabeli na ekranie
            dataGridViewSupporters.DataSource = table;
        }
        /// <summary>
        /// oprogramowanie przycisku do usuwania kibiców
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteSupporters_Click(object sender, EventArgs e)
        {
            // wybrany wiersz z gridview
            login = dataGridViewSupporters.Rows[dataGridViewSupporters.CurrentCell.RowIndex].Cells[0].Value.ToString();
            // ustalenie jaką komendę wykonamy
            SqlCommand command = new SqlCommand($"DELETE FROM Supporters WHERE Login='" + login + "'", connection);
            // wykonanie komendy
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
