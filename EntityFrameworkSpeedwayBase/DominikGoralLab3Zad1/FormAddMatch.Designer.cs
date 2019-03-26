namespace DominikGoralLab3Zad1
{
    partial class FormAddMatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonApplyResult = new System.Windows.Forms.Button();
            this.labelFirstTeam = new System.Windows.Forms.Label();
            this.labelSecondTeam = new System.Windows.Forms.Label();
            this.labelResultHome = new System.Windows.Forms.Label();
            this.comboBoxFirstTeamID = new System.Windows.Forms.ComboBox();
            this.comboBoxSecondTeamID = new System.Windows.Forms.ComboBox();
            this.numericUpDownResultHome = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResultAway = new System.Windows.Forms.NumericUpDown();
            this.labelResultAway = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResultHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResultAway)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApplyResult
            // 
            this.buttonApplyResult.Location = new System.Drawing.Point(49, 163);
            this.buttonApplyResult.Name = "buttonApplyResult";
            this.buttonApplyResult.Size = new System.Drawing.Size(180, 55);
            this.buttonApplyResult.TabIndex = 0;
            this.buttonApplyResult.Text = "Potwierdź";
            this.buttonApplyResult.UseVisualStyleBackColor = true;
            this.buttonApplyResult.Click += new System.EventHandler(this.buttonApplyResult_Click);
            // 
            // labelFirstTeam
            // 
            this.labelFirstTeam.AutoSize = true;
            this.labelFirstTeam.Location = new System.Drawing.Point(34, 36);
            this.labelFirstTeam.Name = "labelFirstTeam";
            this.labelFirstTeam.Size = new System.Drawing.Size(78, 17);
            this.labelFirstTeam.TabIndex = 4;
            this.labelFirstTeam.Text = "Gospodarz";
            // 
            // labelSecondTeam
            // 
            this.labelSecondTeam.AutoSize = true;
            this.labelSecondTeam.Location = new System.Drawing.Point(71, 78);
            this.labelSecondTeam.Name = "labelSecondTeam";
            this.labelSecondTeam.Size = new System.Drawing.Size(41, 17);
            this.labelSecondTeam.TabIndex = 5;
            this.labelSecondTeam.Text = "Gość";
            // 
            // labelResultHome
            // 
            this.labelResultHome.AutoSize = true;
            this.labelResultHome.Location = new System.Drawing.Point(12, 118);
            this.labelResultHome.Name = "labelResultHome";
            this.labelResultHome.Size = new System.Drawing.Size(78, 17);
            this.labelResultHome.TabIndex = 6;
            this.labelResultHome.Text = "Gospodarz";
            // 
            // comboBoxFirstTeamID
            // 
            this.comboBoxFirstTeamID.FormattingEnabled = true;
            this.comboBoxFirstTeamID.Items.AddRange(new object[] {
            "Stal Gorzów",
            "Falubaz Zielona Góra",
            "Sparta Wrocław",
            "Unia Leszno",
            "Apator Toruń",
            "Włókniarz Częstochowa",
            "Motor Lublin",
            "GKM Grudziądz",
            "Unia Tarnów"});
            this.comboBoxFirstTeamID.Location = new System.Drawing.Point(118, 29);
            this.comboBoxFirstTeamID.Name = "comboBoxFirstTeamID";
            this.comboBoxFirstTeamID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFirstTeamID.TabIndex = 7;
            // 
            // comboBoxSecondTeamID
            // 
            this.comboBoxSecondTeamID.FormattingEnabled = true;
            this.comboBoxSecondTeamID.Items.AddRange(new object[] {
            "Stal Gorzów",
            "Falubaz Zielona Góra",
            "Sparta Wrocław",
            "Unia Leszno",
            "Apator Toruń",
            "Włókniarz Częstochowa",
            "Motor Lublin",
            "GKM Grudziądz",
            "Unia Tarnów"});
            this.comboBoxSecondTeamID.Location = new System.Drawing.Point(118, 71);
            this.comboBoxSecondTeamID.Name = "comboBoxSecondTeamID";
            this.comboBoxSecondTeamID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSecondTeamID.TabIndex = 8;
            // 
            // numericUpDownResultHome
            // 
            this.numericUpDownResultHome.Location = new System.Drawing.Point(96, 116);
            this.numericUpDownResultHome.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericUpDownResultHome.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownResultHome.Name = "numericUpDownResultHome";
            this.numericUpDownResultHome.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownResultHome.TabIndex = 9;
            this.numericUpDownResultHome.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numericUpDownResultAway
            // 
            this.numericUpDownResultAway.Location = new System.Drawing.Point(216, 113);
            this.numericUpDownResultAway.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericUpDownResultAway.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownResultAway.Name = "numericUpDownResultAway";
            this.numericUpDownResultAway.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownResultAway.TabIndex = 10;
            this.numericUpDownResultAway.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelResultAway
            // 
            this.labelResultAway.AutoSize = true;
            this.labelResultAway.Location = new System.Drawing.Point(150, 118);
            this.labelResultAway.Name = "labelResultAway";
            this.labelResultAway.Size = new System.Drawing.Size(41, 17);
            this.labelResultAway.TabIndex = 11;
            this.labelResultAway.Text = "Gość";
            // 
            // FormAddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 249);
            this.Controls.Add(this.labelResultAway);
            this.Controls.Add(this.numericUpDownResultAway);
            this.Controls.Add(this.numericUpDownResultHome);
            this.Controls.Add(this.comboBoxSecondTeamID);
            this.Controls.Add(this.comboBoxFirstTeamID);
            this.Controls.Add(this.labelResultHome);
            this.Controls.Add(this.labelSecondTeam);
            this.Controls.Add(this.labelFirstTeam);
            this.Controls.Add(this.buttonApplyResult);
            this.Name = "FormAddMatch";
            this.Text = "FormAddMatch";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResultHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResultAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApplyResult;
        private System.Windows.Forms.Label labelFirstTeam;
        private System.Windows.Forms.Label labelSecondTeam;
        private System.Windows.Forms.Label labelResultHome;
        private System.Windows.Forms.ComboBox comboBoxFirstTeamID;
        private System.Windows.Forms.ComboBox comboBoxSecondTeamID;
        private System.Windows.Forms.NumericUpDown numericUpDownResultHome;
        private System.Windows.Forms.NumericUpDown numericUpDownResultAway;
        private System.Windows.Forms.Label labelResultAway;
    }
}