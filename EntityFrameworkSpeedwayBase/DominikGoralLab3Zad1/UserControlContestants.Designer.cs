namespace DominikGoralLab3Zad1
{
    partial class UserControlContestants
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
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonAddContestant = new System.Windows.Forms.Button();
            this.buttonUpdateContestant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(105, 187);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(746, 253);
            this.dataGridViewData.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(80, 33);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(171, 40);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Pokaż zawodników";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonAddContestant
            // 
            this.buttonAddContestant.Location = new System.Drawing.Point(708, 129);
            this.buttonAddContestant.Name = "buttonAddContestant";
            this.buttonAddContestant.Size = new System.Drawing.Size(171, 40);
            this.buttonAddContestant.TabIndex = 2;
            this.buttonAddContestant.Text = "Dodaj zawodnika";
            this.buttonAddContestant.UseVisualStyleBackColor = true;
            this.buttonAddContestant.Click += new System.EventHandler(this.buttonAddContestant_Click);
            // 
            // buttonUpdateContestant
            // 
            this.buttonUpdateContestant.Location = new System.Drawing.Point(393, 70);
            this.buttonUpdateContestant.Name = "buttonUpdateContestant";
            this.buttonUpdateContestant.Size = new System.Drawing.Size(171, 66);
            this.buttonUpdateContestant.TabIndex = 3;
            this.buttonUpdateContestant.Text = "Pokaż zawodników i ich kluby";
            this.buttonUpdateContestant.UseVisualStyleBackColor = true;
            this.buttonUpdateContestant.Click += new System.EventHandler(this.buttonUpdateTeam_Click);
            // 
            // UserControlContestants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.buttonUpdateContestant);
            this.Controls.Add(this.buttonAddContestant);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "UserControlContestants";
            this.Size = new System.Drawing.Size(958, 464);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonAddContestant;
        private System.Windows.Forms.Button buttonUpdateContestant;
    }
}
