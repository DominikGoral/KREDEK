namespace DominikGoralLab3Zad1
{
    partial class UserControlSupporters
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
            this.dataGridViewSupporters = new System.Windows.Forms.DataGridView();
            this.buttonShowSupporters = new System.Windows.Forms.Button();
            this.buttonDeleteSupporters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupporters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupporters
            // 
            this.dataGridViewSupporters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupporters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupporters.Location = new System.Drawing.Point(118, 169);
            this.dataGridViewSupporters.Name = "dataGridViewSupporters";
            this.dataGridViewSupporters.RowTemplate.Height = 24;
            this.dataGridViewSupporters.Size = new System.Drawing.Size(724, 200);
            this.dataGridViewSupporters.TabIndex = 0;
            // 
            // buttonShowSupporters
            // 
            this.buttonShowSupporters.Location = new System.Drawing.Point(118, 65);
            this.buttonShowSupporters.Name = "buttonShowSupporters";
            this.buttonShowSupporters.Size = new System.Drawing.Size(169, 63);
            this.buttonShowSupporters.TabIndex = 2;
            this.buttonShowSupporters.Text = "Pokaż kibiców";
            this.buttonShowSupporters.UseVisualStyleBackColor = true;
            this.buttonShowSupporters.Click += new System.EventHandler(this.buttonShowSupporters_Click);
            // 
            // buttonDeleteSupporters
            // 
            this.buttonDeleteSupporters.Location = new System.Drawing.Point(673, 65);
            this.buttonDeleteSupporters.Name = "buttonDeleteSupporters";
            this.buttonDeleteSupporters.Size = new System.Drawing.Size(169, 63);
            this.buttonDeleteSupporters.TabIndex = 3;
            this.buttonDeleteSupporters.Text = "Usuń kibica";
            this.buttonDeleteSupporters.UseVisualStyleBackColor = true;
            this.buttonDeleteSupporters.Click += new System.EventHandler(this.buttonDeleteSupporters_Click);
            // 
            // UserControlSupporters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.buttonDeleteSupporters);
            this.Controls.Add(this.buttonShowSupporters);
            this.Controls.Add(this.dataGridViewSupporters);
            this.Name = "UserControlSupporters";
            this.Size = new System.Drawing.Size(958, 396);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupporters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupporters;
        private System.Windows.Forms.Button buttonShowSupporters;
        private System.Windows.Forms.Button buttonDeleteSupporters;
    }
}
