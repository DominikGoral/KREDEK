using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikGoralLab4Zad1
{
    /// <summary>
    /// okno główne dla pracownika, mamy w nim funkcje dla pracowników, wyświetla się po zalogowaniu jako admin
    /// </summary>
    public partial class FormMainForEmployee : Form
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public FormMainForEmployee()
        {
            InitializeComponent();
            // nie wyświetlamy na początku żadnych userControli
            userControlDurationEditor1.Hide();
            userControlTicketEditor1.Hide();
            userControlUserEditor1.Hide();
            // wyświetlamy komunikat o powodzeniu
            MessageBox.Show("Zostałeś zalogowany");
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do edycji lotów, po kliknięciu pojawia nam się odpowiedni userControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDurationEditor_Click(object sender, EventArgs e)
        {
            userControlTicketEditor1.Hide();
            userControlUserEditor1.Hide();
            userControlDurationEditor1.Show();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do edycji użytkowników, po kliknięciu pojawia nam się odpowiedni userControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxUsersEditor_Click(object sender, EventArgs e)
        {
            // odpowiednie wyświetlanie/ chowanie userControli
            userControlTicketEditor1.Hide();
            userControlDurationEditor1.Hide();
            userControlUserEditor1.Show();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do edycji biletów, po kliknięciu pojawia nam się odpowiedni userControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTicketEditor_Click(object sender, EventArgs e)
        {
            // odpowiednie wyświetlanie/ chowanie userControli
            userControlDurationEditor1.Hide();
            userControlUserEditor1.Hide();
            userControlTicketEditor1.Show();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do wylogowywania, wracamy do okienka logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            // komunikat o powodzeniu 
            MessageBox.Show("Zostałeś wylogowany");
            // chowamy okno obsługi dla pracowników
            this.Hide();
        }
    }
}
