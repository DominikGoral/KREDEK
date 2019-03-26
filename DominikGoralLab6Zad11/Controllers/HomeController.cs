using DominikGoralLab6Zad11.Models;
using DominikGoralLab6Zad11.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DominikGoralLab6Zad11.Controllers
{
    public class HomeController : Controller
    {
        // określenie na której bazie danych będziemy pracować
        DominikGoralLab6Zad1_1Entities database = new DominikGoralLab6Zad1_1Entities();
        // widok strony głównej
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Pobieranie wszystkich mebli
        /// </summary>
        /// <returns></returns>
        public ActionResult GetAllFurnitures()
        {
            List<Furniture> allFurnitures = database.Furniture.ToList();

            List<FurnitureVM> viewFurnitures = new List<FurnitureVM>();
            foreach (var furniture in allFurnitures)
            {
                FurnitureVM viewFurniture = new FurnitureVM(furniture.Name, furniture.Manufacturer, furniture.Type, Convert.ToInt32(furniture.Price), furniture.Photo);
                viewFurnitures.Add(viewFurniture);
            }
            return View(viewFurnitures);
        }
        /// <summary>
        /// Wyświetlanie listy modeli mebli
        /// </summary>
        /// <returns></returns>
        public ActionResult GetListOfNames()
        {
            List<Furniture> allFurnitures = database.Furniture.ToList();
            List<string> allNames = new List<string>();
            foreach (var furniture in allFurnitures)
            {
                allNames.Add(furniture.Name);
            }
            return View(allNames);
        }
        /// <summary>
        /// Wyświetlanie mebli po nazwie
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult GetFurnitureByName(string name)
        {
            List<Furniture> allFurnitures = database.Furniture.ToList();
            // filtracja listy
            var furniture = allFurnitures.Where(a => a.Name.ToLower() == name.ToLower()).FirstOrDefault();
            FurnitureVM viewCar = new FurnitureVM(furniture.Name, furniture.Manufacturer, furniture.Type, Convert.ToInt32(furniture.Price), furniture.Photo);

            return View(viewCar);
        }
        /// <summary>
        /// Rejestracja użytkownika
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        /// <summary>
        /// Rejestracja użytkownika ( dodanie użytkownika do bazy), przechwycenie danych
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Users user)
        {
            if (ModelState.IsValid)
            {
                database.Users.Add(user);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        /// <summary>
        /// Logowanie użytkownika
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// Logowanie użytkownika ( sprawdzanie czy użytkownik o podanych danych istnieje), przechwycenie danych
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users user)
        {
            if (ModelState.IsValid)
            {
                var details = (from userlist in database.Users
                               where userlist.Login == user.Login && userlist.Password == user.Password
                               select new
                               {
                                   userlist.ID,
                                   userlist.Login
                               }).ToList();
                if(details.FirstOrDefault() != null)
                {
                    Session["ID"] = details.FirstOrDefault().ID;
                    Session["Login"] = details.FirstOrDefault().Login;
                    return RedirectToAction("Welcome", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid Credentials");
            }
            return View(user);
        }
        /// <summary>
        /// Widok wyświetlany po zalogowaniu
        /// </summary>
        /// <returns></returns>
        public ActionResult Welcome()
        {
            return View();
        }
        /// <summary>
        /// Formularz kontaktowy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ContactForm()
        {
            return View();
        }
        /// <summary>
        /// Przechwycenie danych z formularza kontaktowego
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ContactForm(ContactForm userData)
        {
            string fullName = userData.Name + " " + userData.Surname;
            ViewBag.UserName = fullName;

            return View("ContactFormGreetings");
        }
    }
}