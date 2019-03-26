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
    /// okno główne dla pracownika, mamy w nim funkcje dla pracowników, wyświetla się po zalogowaniu jako użytkownik
    /// </summary>
    public partial class FormMainForUsers : Form
    {
        public int userID;
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public FormMainForUsers()
        {
            InitializeComponent();
            // na początku nie wyświetlamy żadnego z userControli
            userControlBasket1.Hide();
            userControlTicketsForUser1.Hide();
            // wyświetlamy komunikat o powodzeniu
            MessageBox.Show("Zostałeś zalogowany"); 
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do wyświetlania koszyka, po kliknięciu pojawia nam się odpowiedni userControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxBasket_Click(object sender, EventArgs e)
        {
            // odpowiednio chowamy/ wyświetlamy userControle
            userControlTicketsForUser1.Hide();
            userControlBasket1.Show();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do wyświetlania dostępnych biletów, po kliknięciu pojawia nam się odpowiedni userControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPlane_Click(object sender, EventArgs e)
        {
            // odpowiednio chowamy/ wyświetlamy userControle
            userControlBasket1.Hide();
            userControlTicketsForUser1.userID = this.userID;
            userControlTicketsForUser1.Show();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do wylogowywania się
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            // chowamy okno obsługi dla użytkowników
            this.Hide();
            // wyświetlam komunikat
            MessageBox.Show("Zostałeś wylogowany.");
        }
    }
}
