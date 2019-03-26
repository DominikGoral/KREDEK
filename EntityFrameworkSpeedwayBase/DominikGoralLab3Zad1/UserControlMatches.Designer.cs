namespace DominikGoralLab3Zad1
{
    partial class UserControlMatches
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
            this.dataGridViewMatches = new System.Windows.Forms.DataGridView();
            this.buttonAddMatch = new System.Windows.Forms.Button();
            this.buttonShowMatches = new System.Windows.Forms.Button();
            this.buttonUpdateMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatches
            // 
            this.dataGridViewMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatches.Location = new System.Drawing.Point(189, 220);
            this.dataGridViewMatches.Name = "dataGridViewMatches";
            this.dataGridViewMatches.RowTemplate.Height = 24;
            this.dataGridViewMatches.Size = new System.Drawing.Size(589, 221);
            this.dataGridViewMatches.TabIndex = 0;
            this.dataGridViewMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatches_CellClick);
            this.dataGridViewMatches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatches_CellClick);
            // 
            // buttonAddMatch
            // 
            this.buttonAddMatch.Location = new System.Drawing.Point(623, 64);
            this.buttonAddMatch.Name = "buttonAddMatch";
            this.buttonAddMatch.Size = new System.Drawing.Size(155, 94);
            this.buttonAddMatch.TabIndex = 1;
            this.buttonAddMatch.Text = "Dodaj mecz";
            this.buttonAddMatch.UseVisualStyleBackColor = true;
            this.buttonAddMatch.Click += new System.EventHandler(this.buttonAddMatch_Click);
            // 
            // buttonShowMatches
            // 
            this.buttonShowMatches.Location = new System.Drawing.Point(402, 64);
            this.buttonShowMatches.Name = "buttonShowMatches";
            this.buttonShowMatches.Size = new System.Drawing.Size(155, 94);
            this.buttonShowMatches.TabIndex = 2;
            this.buttonShowMatches.Text = "Pokaż mecze";
            this.buttonShowMatches.UseVisualStyleBackColor = true;
            this.buttonShowMatches.Click += new System.EventHandler(this.buttonShowMatches_Click);
            // 
            // buttonUpdateMatch
            // 
            this.buttonUpdateMatch.Location = new System.Drawing.Point(189, 64);
            this.buttonUpdateMatch.Name = "buttonUpdateMatch";
            this.buttonUpdateMatch.Size = new System.Drawing.Size(148, 94);
            this.buttonUpdateMatch.TabIndex = 4;
            this.buttonUpdateMatch.Text = "Zaktualizuj mecz";
            this.buttonUpdateMatch.UseVisualStyleBackColor = true;
            this.buttonUpdateMatch.Click += new System.EventHandler(this.buttonUpdateMatch_Click);
            // 
            // UserControlMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.buttonUpdateMatch);
            this.Controls.Add(this.buttonShowMatches);
            this.Controls.Add(this.buttonAddMatch);
            this.Controls.Add(this.dataGridViewMatches);
            this.Name = "UserControlMatches";
            this.Size = new System.Drawing.Size(958, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatches;
        private System.Windows.Forms.Button buttonAddMatch;
        private System.Windows.Forms.Button buttonShowMatches;
        private System.Windows.Forms.Button buttonUpdateMatch;
    }
}
