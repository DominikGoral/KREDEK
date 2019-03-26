namespace DominikGoralLab4Zad1
{
    partial class UserControlDurationEditor
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
            this.dataGridViewFlightDuration = new System.Windows.Forms.DataGridView();
            this.labelFlightDuration = new System.Windows.Forms.Label();
            this.pictureBoxEditDuration = new System.Windows.Forms.PictureBox();
            this.textBoxNewDuration = new System.Windows.Forms.TextBox();
            this.labelNewDuration = new System.Windows.Forms.Label();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightDuration
            // 
            this.dataGridViewFlightDuration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFlightDuration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightDuration.Location = new System.Drawing.Point(30, 117);
            this.dataGridViewFlightDuration.Name = "dataGridViewFlightDuration";
            this.dataGridViewFlightDuration.RowTemplate.Height = 24;
            this.dataGridViewFlightDuration.Size = new System.Drawing.Size(501, 284);
            this.dataGridViewFlightDuration.TabIndex = 0;
            // 
            // labelFlightDuration
            // 
            this.labelFlightDuration.AutoSize = true;
            this.labelFlightDuration.BackColor = System.Drawing.Color.Transparent;
            this.labelFlightDuration.Font = new System.Drawing.Font("Impact", 36F);
            this.labelFlightDuration.Location = new System.Drawing.Point(17, 20);
            this.labelFlightDuration.Name = "labelFlightDuration";
            this.labelFlightDuration.Size = new System.Drawing.Size(290, 75);
            this.labelFlightDuration.TabIndex = 1;
            this.labelFlightDuration.Text = "Czas lotów";
            // 
            // pictureBoxEditDuration
            // 
            this.pictureBoxEditDuration.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEditDuration.Image = global::DominikGoralLab4Zad1.Properties.Resources.EditButton;
            this.pictureBoxEditDuration.Location = new System.Drawing.Point(600, 117);
            this.pictureBoxEditDuration.Name = "pictureBoxEditDuration";
            this.pictureBoxEditDuration.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxEditDuration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditDuration.TabIndex = 4;
            this.pictureBoxEditDuration.TabStop = false;
            this.pictureBoxEditDuration.Click += new System.EventHandler(this.pictureBoxEditDuration_Click);
            // 
            // textBoxNewDuration
            // 
            this.textBoxNewDuration.Location = new System.Drawing.Point(600, 66);
            this.textBoxNewDuration.Name = "textBoxNewDuration";
            this.textBoxNewDuration.Size = new System.Drawing.Size(136, 22);
            this.textBoxNewDuration.TabIndex = 5;
            // 
            // labelNewDuration
            // 
            this.labelNewDuration.AutoSize = true;
            this.labelNewDuration.BackColor = System.Drawing.Color.Transparent;
            this.labelNewDuration.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewDuration.Location = new System.Drawing.Point(595, 29);
            this.labelNewDuration.Name = "labelNewDuration";
            this.labelNewDuration.Size = new System.Drawing.Size(124, 25);
            this.labelNewDuration.TabIndex = 6;
            this.labelNewDuration.Text = "Nowa długość";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRefresh.Image = global::DominikGoralLab4Zad1.Properties.Resources.load;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(600, 265);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 7;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // UserControlDurationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundCut;
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.labelNewDuration);
            this.Controls.Add(this.textBoxNewDuration);
            this.Controls.Add(this.pictureBoxEditDuration);
            this.Controls.Add(this.labelFlightDuration);
            this.Controls.Add(this.dataGridViewFlightDuration);
            this.Name = "UserControlDurationEditor";
            this.Size = new System.Drawing.Size(800, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFlightDuration;
        private System.Windows.Forms.Label labelFlightDuration;
        private System.Windows.Forms.PictureBox pictureBoxEditDuration;
        private System.Windows.Forms.TextBox textBoxNewDuration;
        private System.Windows.Forms.Label labelNewDuration;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
    }
}
