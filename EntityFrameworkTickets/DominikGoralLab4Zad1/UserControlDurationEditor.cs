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
    /// klasa userControla do edytowania lotów, dostępna z pozycji pracownika ( admina)
    /// </summary>
    public partial class UserControlDurationEditor : UserControl
    {
        /// <summary>
        /// konstruktor domyślny
        /// </summary>
        public UserControlDurationEditor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// oprogramowanie pictureBoxa do odświeżania ( ponowne pobranie z bazy danych do dataGridView)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            // pokazujemy, której bazy używamy
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // łączymy tabele lot i samoloty
                dataGridViewFlightDuration.DataSource = context.Flight.Join(context.Planes, x => x.PlaneID, y => y.ID, (x, y) => new { x.Duration, y.Name, y.Capacity }).ToList();
            }
        }
        /// <summary>
        /// oprogramowanie pictureBoxa za pomocą którego możemy edytować czas lotu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEditDuration_Click(object sender, EventArgs e)
        {
            using (DominikGoralLab4Zadanie1Entities context = new DominikGoralLab4Zadanie1Entities())
            {
                // wybieramy z dataGridView który wiersz chcemy aktualizować
                String flightDuration = dataGridViewFlightDuration.Rows[dataGridViewFlightDuration.CurrentCell.RowIndex].Cells[0].Value.ToString();
                // wybieramy w bazie danych który wiersz chcemy zaktualizować
                Flight duration = context.Flight.Single(x => x.Duration == flightDuration);
                // ustawiamy nową wartość pobraną z textBoxa
                duration.Duration = textBoxNewDuration.Text;
                // zapisujemy zmiany
                context.SaveChanges();
            }
        }
    }
}
