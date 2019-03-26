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
    /// okno do logowania, wywołuje się jako pierwsze
    /// </summary>
    public partial class FormLogin : Form
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            // na początek nie wyświetlmay żadnego userControla, dopiero gdy wybierzemy 
            // czy jesteśmy pracownikiem ( adminem) lub użytkownikiem pojawia nam się widok userControla 
            userControlUserLogIn1.Hide();
            userControlEmployeeLogIn1.Hide();
            pictureBoxExit.Show();
            labelExit.Show();
        }
        /// <summary>
        /// oprogramowanie pictureboxa, po kliknięciu pokazuje nam się userControl do logowania się dla pracownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEmployee_Click(object sender, EventArgs e)
        {
            // pokazujemy / ukrywamy userControle
            labelExit.Hide();
            pictureBoxExit.Hide();
            userControlUserLogIn1.Hide();
            userControlEmployeeLogIn1.Show();
        }
        /// <summary>
        /// oprogramowanie pictureboxa, po kliknięciu pokazuje nam się userControl do logowania się dla klienta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            // pokazujemy/ ukrywamy userControle
            pictureBoxExit.Hide();
            labelExit.Hide();
            userControlEmployeeLogIn1.Hide();
            userControlUserLogIn1.Show();
        }
        /// <summary>
        /// oprogramowanie pictureboxa, po kliknięciu wyłączamy nasz program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
