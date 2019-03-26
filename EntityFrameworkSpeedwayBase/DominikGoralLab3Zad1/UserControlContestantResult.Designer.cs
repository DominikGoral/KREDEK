namespace DominikGoralLab3Zad1
{
    partial class UserControlContestantResult
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
            this.dataGridViewContestantsResult = new System.Windows.Forms.DataGridView();
            this.buttonAddResults = new System.Windows.Forms.Button();
            this.buttonShowContestantResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContestantsResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContestantsResult
            // 
            this.dataGridViewContestantsResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContestantsResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContestantsResult.Location = new System.Drawing.Point(66, 220);
            this.dataGridViewContestantsResult.Name = "dataGridViewContestantsResult";
            this.dataGridViewContestantsResult.RowTemplate.Height = 24;
            this.dataGridViewContestantsResult.Size = new System.Drawing.Size(824, 206);
            this.dataGridViewContestantsResult.TabIndex = 0;
            // 
            // buttonAddResults
            // 
            this.buttonAddResults.Location = new System.Drawing.Point(622, 55);
            this.buttonAddResults.Name = "buttonAddResults";
            this.buttonAddResults.Size = new System.Drawing.Size(165, 93);
            this.buttonAddResults.TabIndex = 1;
            this.buttonAddResults.Text = "Dodaj rezultaty";
            this.buttonAddResults.UseVisualStyleBackColor = true;
            this.buttonAddResults.Click += new System.EventHandler(this.buttonAddResults_Click);
            // 
            // buttonShowContestantResult
            // 
            this.buttonShowContestantResult.Location = new System.Drawing.Point(173, 55);
            this.buttonShowContestantResult.Name = "buttonShowContestantResult";
            this.buttonShowContestantResult.Size = new System.Drawing.Size(165, 93);
            this.buttonShowContestantResult.TabIndex = 2;
            this.buttonShowContestantResult.Text = "Pokaż zdobycze zawodników";
            this.buttonShowContestantResult.UseVisualStyleBackColor = true;
            this.buttonShowContestantResult.Click += new System.EventHandler(this.buttonShowContestantResult_Click);
            // 
            // UserControlContestantResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.buttonShowContestantResult);
            this.Controls.Add(this.buttonAddResults);
            this.Controls.Add(this.dataGridViewContestantsResult);
            this.Name = "UserControlContestantResult";
            this.Size = new System.Drawing.Size(958, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContestantsResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContestantsResult;
        private System.Windows.Forms.Button buttonAddResults;
        private System.Windows.Forms.Button buttonShowContestantResult;
    }
}
