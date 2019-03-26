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
    /// klasa userControla do logowania sie do systemu, dostępna z pozycji pracownika ( admina)
    /// </summary>
    public partial class UserControlEmployeeLogIn : UserControl
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public UserControlEmployeeLogIn()
        {
            InitializeComponent();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa, po kliknięciu logujemy się ( jeśli podaliśmy poprawne dane) lub nie; 
        /// wyświetlenie odpowiednich komunikatów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxApply_Click(object sender, EventArgs e)
        {
            // utworzenie obiektu 
            SignInAndSignUpService login = new SignInAndSignUpService();
            // sprawdzamy czy użytkownik o danym loginie istnieje
            if (login.SingInToSystemForAdmin(textBoxEmployeeLogin.Text, textBoxEmployeePassword.Text) == true)
            {
                // włączamy okienko dla użytkowników
                FormMainForEmployee objFormMainForEmployee = new FormMainForEmployee();
                objFormMainForEmployee.ShowDialog();
            }
            else
            {
                // wyświetlamy komunikat
                MessageBox.Show("Niepoprawne dane.");
            }
        }
    }
}
