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
    /// klasa userControla do zarządzania biletami, dostępna z pozycji pracownika ( admina)
    /// </summary>
    public partial class UserControlTicketEditor : UserControl
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public UserControlTicketEditor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do edytowania ceny biletów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEditTicketPrice_Click(object sender, EventArgs e)
        {
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // wybieramy który element chcemy edytować
                int ticketID = Int32.Parse(dataGridViewTickets.Rows[dataGridViewTickets.CurrentCell.RowIndex].Cells[0].Value.ToString());
                // określamy który element chcemy zaktualizować na podstawie wybranego wcześniej ID
                Tickets ticket = context.Tickets.Single(x => x.ID == ticketID);
                // ustawiamy nową wartość pobraną z textBoxa
                ticket.Price = Int32.Parse(textBoxNewPrice.Text);
                // zapisujemy zmiany
                context.SaveChanges();

            }
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do pobierania dostępnych biletów z bazy danych do dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            using(DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // wyświetlamy dane z bazy danych
                dataGridViewTickets.DataSource = context.Tickets.Select(x => new { x.ID, x.Departure, x.Arrival, x.Price }).ToList();
            }
        }
    }
}
