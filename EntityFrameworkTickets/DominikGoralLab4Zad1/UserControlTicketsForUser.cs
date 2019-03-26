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
    /// klasa userControla do korzystania z biletów, dostępna z poziomu użytkownika ( klienta)
    /// </summary>
    public partial class UserControlTicketsForUser : UserControl
    {
        public int userID;
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public UserControlTicketsForUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do pobierania biletów z bazy do dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxLoadTickets_Click(object sender, EventArgs e)
        {
            // pokazujemy, której bazy używamy
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // ładujemy dane z bazy danych
                dataGridViewTickets.DataSource = context.Tickets.Select(x => new { x.ID, x.Departure, x.Arrival, x.Price }).ToList();
            }
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do dodawania wybranych biletów do koszyka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAddToBasket_Click(object sender, EventArgs e)
        {
            using(DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // tworzymy obiekt który będziemy dodawali do bazy danych
                Basket basket = new Basket();
                // przypisujemy koszykowi parametry pobrane z textBox'ów
                basket.UserID = userID;
                basket.TicketID = Int32.Parse(dataGridViewTickets.Rows[dataGridViewTickets.CurrentCell.RowIndex].Cells[0].Value.ToString());
                basket.sum = Int32.Parse(dataGridViewTickets.Rows[dataGridViewTickets.CurrentCell.RowIndex].Cells[3].Value.ToString());
                // dodajemy nasz koszyk
                context.Basket.Add(basket);
                // zapisujemy dane
                context.SaveChanges();
            }
        }
    }
}
