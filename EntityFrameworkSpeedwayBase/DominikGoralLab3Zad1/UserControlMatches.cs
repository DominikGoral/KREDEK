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
    /// klasa okienko kontroler, możemy dzięki niej wyświetlać wiele scen w jednym okienku, to wyświetla nam sekcje meczy
    /// </summary>
    public partial class UserControlMatches : UserControl
    {
        // zadeklarowanie zmiennej do łączenia z bazą danych
        SqlConnection connection;
        // zadeklarowanie zmiennej do przechowywania ID meczu, który chcemy zaktualizować
        int ID;
        // konstruktor, inicjacja podstawowego stamu programu
        public UserControlMatches()
        {
            InitializeComponent();
            // ustalenie koloru
            this.BackColor = Color.FromArgb(181, 178, 175);
            // połączenie z bazą
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }
        /// <summary>
        /// oprogramowanie przycisku do dodawania meczu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMatch_Click(object sender, EventArgs e)
        {
            // wyświetlenie okienka do dodawania meczu
            FormAddMatch objAddMatch = new FormAddMatch();
            this.Hide();
            objAddMatch.Show();
        }
        /// <summary>
        /// oprogramowanie przycisku służącego do wyświetlenia wszystkich wartości z tabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowMatches_Click(object sender, EventArgs e)
        {
            // ustalenie na których danych będziemy pracować
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Matches", connection);
            DataTable table = new DataTable();
            // wypełnienie tablicy
            dataAdapter.Fill(table);
            // wyświetlenie tabeli na ekranie
            dataGridViewMatches.DataSource = table;
        }
        
        /// <summary>
        /// oprogramowanie przycisku do modyfikowania wyniku, w momencie gdy się pomylimy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateMatch_Click(object sender, EventArgs e)
        {
            FormUpdateMatch objFormUpdateMatch = new FormUpdateMatch(ID);
            objFormUpdateMatch.Show();
        }
        /// <summary>
        /// metoda która przekazuje nam id wiersza który chcemy zaktualizować
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // id wiersza który chcemy usunąć
            ID = Int32.Parse(dataGridViewMatches.Rows[dataGridViewMatches.CurrentCell.RowIndex].Cells[0].Value.ToString());
        }
    }
}
