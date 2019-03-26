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
    /// klasa userControla do logowania się do systemu, dostępna z poziomu użytkownika ( klienta)
    /// </summary>
    public partial class UserControlUserLogIn : UserControl
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public UserControlUserLogIn()
        {
            InitializeComponent();
            // chowamy userControl do rejestrowania użytkowników
            userControlUserRegister1.Hide();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do rejestracji, po kliknięciu przenosimy się do userControla za pomocą którego możemy
        /// się zarejestrować
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxUserRegister_Click(object sender, EventArgs e)
        {
            // wyświetlenie userControla do rejestracji
            userControlUserRegister1.Show();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa, po kliknięciu logujemy się do systemu ( wyświetlamy komunikat o powodzeniu) ,
        /// lub zostaje nam wyświetlony komunikat o niepowodzeniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxApply_Click(object sender, EventArgs e)
        {
            // utworzenie obiektu 
            SignInAndSignUpService login = new SignInAndSignUpService();
            // sprawdzamy czy użytkownik o danym loginie istnieje
            if (login.SingInToSystemForUsers(textBoxUserLogin.Text, textBoxUserPassword.Text) == true)
            {
                // włączamy okienko dla użytkowników
                FormMainForUsers objFormMainForUsers = new FormMainForUsers();
                this.Hide();
                // ,, wyciągamy" sobie użytkownika o podanym loginie i przypisujemy zmiennej userID wartość ID tego uzytkownika
                using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
                {
                    // wskazujemy i pobieramy użytkownika o podanym loginie
                    var test1 = context.Users.Single(x => x.login == textBoxUserLogin.Text);
                    // przypisujemy wartość do zmiennej
                    objFormMainForUsers.userID = test1.ID;
                }
                // wyświetlamy okienko
                objFormMainForUsers.ShowDialog();
            }
            else
            {
                // komunikat o niepowodzeniu operacji
                MessageBox.Show("Error, najpierw utwórz konto.");
            }
        }
    }
}
