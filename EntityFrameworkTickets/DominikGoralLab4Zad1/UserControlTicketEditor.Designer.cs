namespace DominikGoralLab4Zad1
{
    partial class UserControlTicketEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNewPrice = new System.Windows.Forms.Label();
            this.textBoxNewPrice = new System.Windows.Forms.TextBox();
            this.pictureBoxEditTicketPrice = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditTicketPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilety";
            // 
            // labelNewPrice
            // 
            this.labelNewPrice.AutoSize = true;
            this.labelNewPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPrice.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewPrice.Location = new System.Drawing.Point(595, 29);
            this.labelNewPrice.Name = "labelNewPrice";
            this.labelNewPrice.Size = new System.Drawing.Size(100, 25);
            this.labelNewPrice.TabIndex = 2;
            this.labelNewPrice.Text = "Nowa cena";
            // 
            // textBoxNewPrice
            // 
            this.textBoxNewPrice.Location = new System.Drawing.Point(600, 66);
            this.textBoxNewPrice.Name = "textBoxNewPrice";
            this.textBoxNewPrice.Size = new System.Drawing.Size(136, 22);
            this.textBoxNewPrice.TabIndex = 3;
            // 
            // pictureBoxEditTicketPrice
            // 
            this.pictureBoxEditTicketPrice.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEditTicketPrice.Image = global::DominikGoralLab4Zad1.Properties.Resources.EditButton;
            this.pictureBoxEditTicketPrice.Location = new System.Drawing.Point(600, 117);
            this.pictureBoxEditTicketPrice.Name = "pictureBoxEditTicketPrice";
            this.pictureBoxEditTicketPrice.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxEditTicketPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditTicketPrice.TabIndex = 10;
            this.pictureBoxEditTicketPrice.TabStop = false;
            this.pictureBoxEditTicketPrice.Click += new System.EventHandler(this.pictureBoxEditTicketPrice_Click);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRefresh.Image = global::DominikGoralLab4Zad1.Properties.Resources.load;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(600, 265);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 11;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // UserControlTicketEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundCut;
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.pictureBoxEditTicketPrice);
            this.Controls.Add(this.textBoxNewPrice);
            this.Controls.Add(this.labelNewPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTickets);
            this.Name = "UserControlTicketEditor";
            this.Size = new System.Drawing.Size(800, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditTicketPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.TextBox textBoxNewPrice;
        private System.Windows.Forms.PictureBox pictureBoxEditTicketPrice;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
    }
}
