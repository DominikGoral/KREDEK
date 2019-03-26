namespace DominikGoralLab4Zad1
{
    partial class UserControlTicketsForUser
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.labelAvailableTickets = new System.Windows.Forms.Label();
            this.pictureBoxLoadTickets = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddToBasket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddToBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(30, 117);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(501, 284);
            this.dataGridViewTickets.TabIndex = 0;
            // 
            // labelAvailableTickets
            // 
            this.labelAvailableTickets.AutoSize = true;
            this.labelAvailableTickets.BackColor = System.Drawing.Color.Transparent;
            this.labelAvailableTickets.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvailableTickets.Location = new System.Drawing.Point(17, 20);
            this.labelAvailableTickets.Name = "labelAvailableTickets";
            this.labelAvailableTickets.Size = new System.Drawing.Size(417, 75);
            this.labelAvailableTickets.TabIndex = 1;
            this.labelAvailableTickets.Text = "Dostępne bilety";
            // 
            // pictureBoxLoadTickets
            // 
            this.pictureBoxLoadTickets.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoadTickets.Image = global::DominikGoralLab4Zad1.Properties.Resources.load;
            this.pictureBoxLoadTickets.Location = new System.Drawing.Point(600, 117);
            this.pictureBoxLoadTickets.Name = "pictureBoxLoadTickets";
            this.pictureBoxLoadTickets.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxLoadTickets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadTickets.TabIndex = 4;
            this.pictureBoxLoadTickets.TabStop = false;
            this.pictureBoxLoadTickets.Click += new System.EventHandler(this.pictureBoxLoadTickets_Click);
            // 
            // pictureBoxAddToBasket
            // 
            this.pictureBoxAddToBasket.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddToBasket.Image = global::DominikGoralLab4Zad1.Properties.Resources.Add_icon;
            this.pictureBoxAddToBasket.Location = new System.Drawing.Point(600, 265);
            this.pictureBoxAddToBasket.Name = "pictureBoxAddToBasket";
            this.pictureBoxAddToBasket.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxAddToBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddToBasket.TabIndex = 2;
            this.pictureBoxAddToBasket.TabStop = false;
            this.pictureBoxAddToBasket.Click += new System.EventHandler(this.pictureBoxAddToBasket_Click);
            // 
            // UserControlTicketsForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundCut;
            this.Controls.Add(this.pictureBoxLoadTickets);
            this.Controls.Add(this.pictureBoxAddToBasket);
            this.Controls.Add(this.labelAvailableTickets);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "UserControlTicketsForUser";
            this.Size = new System.Drawing.Size(800, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddToBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Label labelAvailableTickets;
        private System.Windows.Forms.PictureBox pictureBoxAddToBasket;
        private System.Windows.Forms.PictureBox pictureBoxLoadTickets;
    }
}
