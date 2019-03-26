using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominikGoralLab3Zad1
{
    /// <summary>
    /// klasa okienko główne
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// konstruktor, zainicjowanie podstawowych wartości
        /// </summary>
        public FormMain()
        {
            // ustawienie koloru tła i początkowych warunków okna
            InitializeComponent();
            panelUp.BackColor = Color.FromArgb(181, 178, 175);
            panelCentral.BackColor = Color.FromArgb(181, 178, 175);
            // ukrycie/ ukazanie userControli
            userControlContestantResult1.Hide();
            userControlMatches1.Hide();
            userControlTeams1.Hide();
            userControlSupporters1.Hide();
            userControlContestants1.Hide();

        }
        /// <summary>
        /// pictureBox- przycisk- pokazanie userControl zawodników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxContestants_Click(object sender, EventArgs e)
        {
            // ukrycie/ ukazanie userControli
            userControlContestantResult1.Hide();
            userControlMatches1.Hide();
            userControlTeams1.Hide();
            userControlSupporters1.Hide();
            userControlContestants1.Show();
            userControlContestants1.BringToFront();
        }
        /// <summary>
        /// pictureBox- przycisk- pokazanie userControl drużyn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTeams_Click(object sender, EventArgs e)
        {
            // ukrycie/ ukazanie userControli
            userControlContestantResult1.Hide();
            userControlMatches1.Hide();
            userControlSupporters1.Hide();
            userControlContestants1.Hide();
            userControlTeams1.Show();
            userControlTeams1.BringToFront();
        }
        /// <summary>
        /// pictureBox- przycisk- pokazanie userControl meczy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMatches_Click(object sender, EventArgs e)
        {
            // ukrycie/ ukazanie userControli
            userControlContestantResult1.Hide();
            userControlSupporters1.Hide();
            userControlContestants1.Hide();
            userControlTeams1.Hide();
            userControlMatches1.Show();
            userControlMatches1.BringToFront();
        }
        /// <summary>
        /// pictureBox- przycisk- pokazanie userControl kibiców
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSupporters_Click(object sender, EventArgs e)
        {
            // ukrycie/ ukazanie userControli
            userControlContestantResult1.Hide();
            userControlContestants1.Hide();
            userControlTeams1.Hide();
            userControlMatches1.Hide();
            userControlSupporters1.Show();
            userControlSupporters1.BringToFront();
        }
        /// <summary>
        /// pictureBox- przycisk- pokazanie userControl wyników zawodników
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxContestantsResult_Click(object sender, EventArgs e)
        {
            // ukrycie/ ukazanie userControli
            userControlContestants1.Hide();
            userControlTeams1.Hide();
            userControlMatches1.Hide();
            userControlSupporters1.Hide();
            userControlContestantResult1.Show();
            userControlContestantResult1.BringToFront();
        }
    }
}
