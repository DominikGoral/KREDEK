namespace DominikGoralLab4Zad1
{
    partial class UserControlBasket
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
            this.dataGridViewBasket = new System.Windows.Forms.DataGridView();
            this.labelBasket = new System.Windows.Forms.Label();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBasket
            // 
            this.dataGridViewBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBasket.Location = new System.Drawing.Point(30, 117);
            this.dataGridViewBasket.Name = "dataGridViewBasket";
            this.dataGridViewBasket.RowTemplate.Height = 24;
            this.dataGridViewBasket.Size = new System.Drawing.Size(501, 284);
            this.dataGridViewBasket.TabIndex = 0;
            // 
            // labelBasket
            // 
            this.labelBasket.AutoSize = true;
            this.labelBasket.BackColor = System.Drawing.Color.Transparent;
            this.labelBasket.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBasket.Location = new System.Drawing.Point(17, 20);
            this.labelBasket.Name = "labelBasket";
            this.labelBasket.Size = new System.Drawing.Size(201, 75);
            this.labelBasket.TabIndex = 1;
            this.labelBasket.Text = "Koszyk";
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUpdate.Image = global::DominikGoralLab4Zad1.Properties.Resources.load;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(600, 117);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 2;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.pictureBoxUpdate_Click);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDelete.Image = global::DominikGoralLab4Zad1.Properties.Resources.DeleteButton;
            this.pictureBoxDelete.Location = new System.Drawing.Point(600, 265);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelete.TabIndex = 3;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // UserControlBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundCut;
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.labelBasket);
            this.Controls.Add(this.dataGridViewBasket);
            this.Name = "UserControlBasket";
            this.Size = new System.Drawing.Size(800, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBasket;
        private System.Windows.Forms.Label labelBasket;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
    }
}
