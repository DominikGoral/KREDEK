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
    /// klasa okienko kontroler, możemy dzięki niej wyświetlać wiele scen w jednym okienku, to wyświetla nam sekcje drużyn
    /// </summary>
    public partial class UserControlTeams : UserControl
    {
        // zadeklarowanie zmiennej do łączenia z bazą
        SqlConnection connection;
        // konstruktor, inicjacja podstawowego stanu programu
        public UserControlTeams()
        {
            InitializeComponent();
            // ustawienie koloru tła
            this.BackColor = Color.FromArgb(181, 178, 175);
            // łączymy się z bazą
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }
        /// <summary>
        /// oprogramowanie przycisku służącego do wyświetlenia wszystkich wartości z tabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonView_Click(object sender, EventArgs e)
        {
            // wybieramy które wartosci chcemy zobaczyc
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Teams.ID, Teams.Name, Teams.ManagerName, League.LeagueName FROM Teams JOIN League ON League.Tier = Teams.LeagueTier", connection);
            // utworzenie tabeli do przechowywania danych z bazy
            DataTable table = new DataTable();
            // zapisujemy je do tabeli
            dataAdapter.Fill(table);
            // pokazujemy tabele
            dataGridViewTeams.DataSource = table;
        }
    }
}
