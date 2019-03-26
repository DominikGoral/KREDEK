using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominikGoralLab6Zad11.Models
{
    public class ContactForm
    {
        /// <summary>
        /// Imię
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Description { get; set; }
    }
}