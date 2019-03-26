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
    /// klasa okienko do dodawania meczy
    /// </summary>
    public partial class FormAddMatch : Form
    {

        // zadeklarowanie zmiennej do połączenia z bazą danych
        SqlConnection connection;
        // konstruktor, inicjacja podstawowego stamu programu
        public FormAddMatch()
        {
            InitializeComponent();
            // ustawienie koloru tła
            this.BackColor = Color.FromArgb(181, 178, 175);
            // łączymy się z bazą danych
            connection = new SqlConnection(@"Data Source=DESKTOP-AUI2L1O; database=DominikGoralLab3Zadanie1_2; Trusted_Connection=yes");
        }
        /// <summary>
        /// oprogramowanie przycisku do zatwierdzania wyników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApplyResult_Click(object sender, EventArgs e)
        {
            // wybranie na których danych pracujemy 
            SqlCommand command = new SqlCommand(@"INSERT INTO Matches(FirstTeamID, SecondTeamID, Result) VALUES (@FirstTeamID, @SecondTeamID, @Result)", connection);
            // Dodanie parametrów kwerendy; +2 jest z powodu tego, że ID drużyn jest nadawane od dwójki, a pierwszy selectedindex to 0
            command.Parameters.Add("@FirstTeamID", SqlDbType.Int).Value = comboBoxFirstTeamID.SelectedIndex+2;
            command.Parameters.Add("@SecondTeamID", SqlDbType.Int).Value = comboBoxSecondTeamID.SelectedIndex + 2;
            command.Parameters.Add("@Result", SqlDbType.NVarChar).Value = numericUpDownResultHome.Value + "-" + numericUpDownResultAway.Value;
            // warunek sprawdzający czy drużyna nie jedzie z samą Sobą
            if(comboBoxFirstTeamID.Text == comboBoxSecondTeamID.Text)
            {
                MessageBox.Show("Gospodarz i gość nie może być tą samą drużyną");
            } else if(numericUpDownResultAway.Value + numericUpDownResultHome.Value != 90)
            {
                MessageBox.Show("Suma punktów musi być 90.");
            } else
            {
                // wykonanie komendy
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                // schowanie okienka
                this.Close();
            }
        }
    }
}
