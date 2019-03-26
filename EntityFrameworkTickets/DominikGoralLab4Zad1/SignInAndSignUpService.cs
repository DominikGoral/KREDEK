using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikGoralLab4Zad1
{
    class SignInAndSignUpService
    {
        /// <summary>
        /// zwraca wartość boolowską
        /// </summary>
        public bool IsTrue { get; set; }

        /// <summary>
        /// Rejestrowanie się do systemu
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="surnname"></param>
        /// <param name="studentIndex"></param>
        /// <param name="email"></param>
        public void SignUpToSystem(string firstName, string surname, string telephoneNumber, string login, string password)
        {
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                /// Zmienna pozwalająca na dodanie do bazy danych informacji o użytkowniku
                var registerPersonalData = context.Users.FirstOrDefault();
                registerPersonalData.FirstName = firstName;
                registerPersonalData.Surname = surname;
                registerPersonalData.telefonNumber = telephoneNumber;
                registerPersonalData.login = login;
                registerPersonalData.password = password;

                // sprawdzamy czy taka osoba istnieje już w bazie
                if (UserExist(login))
                {
                    // wyświetlenie komunikatu 
                    MessageBox.Show("Użytkownik o tym loginie istnieje w bazie.");
                }
                else
                {
                    // dodanie do bazy danych, które wpisaliśmy w textBoxy
                    context.Users.Add(registerPersonalData);
                    // zapisanie zmian
                    context.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Logowanie sie do systemu
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SingInToSystemForUsers(string login, string password)
        {
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                var signIn = context.Users.Where(x => x.login == login && x.password == password).Count();
                if (signIn >= 1 && login != "admin")
                {
                    IsTrue = true;
                }
                return IsTrue;
            }
        }
        /// <summary>
        /// Logowanie się do systemu przez admina
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SingInToSystemForAdmin(string login, string password)
        {
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                var signIn = context.Users.Where(x => x.login == login && x.password == password).Count();
                if (signIn >= 1)
                {
                    IsTrue = true;
                }
                return IsTrue;
            }
        }

        public bool UserExist(string login)
        {
            using(DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                var checkUserExist = context.Users.Where(x => x.login == login).Count();
                if(checkUserExist < 1)
                {
                    return false;
                } else
                {
                    return true;
                }
            }
        }
    }
}
