using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikGoralLab4Zad1
{
    /// <summary>
    /// klasa userControla do edytowania użytkowników, dostępna z pozycji pracownika ( admina)
    /// </summary>
    public partial class UserControlUserEditor : UserControl
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public UserControlUserEditor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do pobierania użytkowników z bazy danych do dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // ładujemy dane z bazy danych
                dataGridViewUsersEditor.DataSource = context.Users.Select(x => new { x.FirstName, x.Surname, x.telefonNumber, x.login, x.password }).ToList();
            }
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do edytowania numeru telefonu wybranego z dataGridView użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEditUserTelephoneNumber_Click(object sender, EventArgs e)
        {
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // wybieramy który numer telefonu z dataGridView chcemy edytować
                String telephoneNumber = dataGridViewUsersEditor.Rows[dataGridViewUsersEditor.CurrentCell.RowIndex].Cells[2].Value.ToString();
                // definiujemy obiekt który chcemy edytować
                Users user = context.Users.Single(x => x.telefonNumber == telephoneNumber);
                // ustawiamy nową wartość numeru na wartość z textBoxa
                user.telefonNumber = textBoxNewUserTelephoneNumber.Text;
                // zapisujemy zmiany
                context.SaveChanges();
                
            }
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do usuwania wybranego z dataGridView użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDeleteUser_Click(object sender, EventArgs e)
        {
            using(DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // zapisujemy login użytkownika którego chcemy usunąć
                String login = dataGridViewUsersEditor.Rows[dataGridViewUsersEditor.CurrentCell.RowIndex].Cells[3].Value.ToString();
                // usuwamy wybranego użytkownika
                context.Users.Remove(context.Users.Single(x => x.login == login));
                // zapisujemy zmiany
                context.SaveChanges();
            }
        }
    }
}
