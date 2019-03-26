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
    /// klasa userControla do obsługi koszyka, dostępna z poziomu użytkownika ( klienta)
    /// </summary>
    public partial class UserControlBasket : UserControl
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public UserControlBasket()
        {
            InitializeComponent();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do aktualizowania koszyka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            // pokazujemy, której bazy używamy
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // pobieramy dane z bazy i przekazujemy je do dataGridView
                dataGridViewBasket.DataSource = context.Basket.Select(x => new { x.UserID, x.TicketID, x.sum}).ToList();
            }
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do usuwania elementów z naszego koszyka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // wybieramy ID koszyka ( transakcji) którą chcemy usunąć
                int userID = Int32.Parse(dataGridViewBasket.Rows[dataGridViewBasket.CurrentCell.RowIndex].Cells[0].Value.ToString());
                // usuwamy wybrany element
                context.Basket.Remove(context.Basket.Single(x => x.UserID == userID));
                // zapisujemy zmiany
                context.SaveChanges();
            }
        }
    }
}
