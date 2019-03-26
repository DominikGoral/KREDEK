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
    /// klasa okienko do aktualizowania wyników meczy
    /// </summary>
    public partial class FormUpdateMatch : Form
    {
        // inicjalizacja zmiennej do połączenia z bazą danych
        SqlConnection connection;
        int MatchID;
        public FormUpdateMatch(int ID)
        {
            InitializeComponent();
            MatchID = ID;
            // ustawienie koloru tła
            this.BackColor = Color.FromArgb(181, 178, 175);
            // konstruktor, inicjacja podstawowego stanu programu
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            // wybranie na których danych pracujemy 
            SqlCommand command = new SqlCommand(@"UPDATE Matches SET Result = @Result WHERE ID =" + MatchID, connection);
            command.Parameters.Add("@Result", SqlDbType.NVarChar).Value = numericUpDownResultHome.Value + "-" + numericUpDownResultAway.Value;
            // sprawdzamy czy suma punktów obu drużyn jest równa 90
            if ((numericUpDownResultAway.Value + numericUpDownResultHome.Value) != 90)
            {
                // komunikat, w przypadku wybrania złej ilości punktów
                MessageBox.Show("Suma punktów musi być równa 90.");
            }
            else
            {
                // wykonanie komendy
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.Hide();
            }

        }
    }
}
