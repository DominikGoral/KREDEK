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
    /// klasa userControla do rejestrowania się do systemu, dostępna z poziomu użytkownika ( klienta)
    /// </summary>
    public partial class UserControlUserRegister : UserControl
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public UserControlUserRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa za pomocą którego możemy anulować chęć rejestracji i wrócić do okna logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do potwierdzania, że cchemy być zarejestrowani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxApply_Click(object sender, EventArgs e)
        {
            // tworzymy obiekt klasy
            SignInAndSignUpService register = new SignInAndSignUpService();
            // wykonujemy metode rejestrowania do bazy danych
            register.SignUpToSystem(textBoxFirstName.Text, textBoxSurname.Text, textBoxTelephoneNumber.Text, textBoxLogin.Text, textBoxPassword.Text);
            // chowanie okna z rejestracją
            this.Hide();
        }
    }
}
