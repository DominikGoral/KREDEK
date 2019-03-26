namespace DominikGoralLab3Zad1
{
    partial class FormUpdateMatch
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
            this.labelMatchResultHome = new System.Windows.Forms.Label();
            this.numericUpDownResultHome = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResultAway = new System.Windows.Forms.NumericUpDown();
            this.labelMatchResultAway = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResultHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResultAway)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMatchResultHome
            // 
            this.labelMatchResultHome.AutoSize = true;
            this.labelMatchResultHome.Location = new System.Drawing.Point(25, 83);
            this.labelMatchResultHome.Name = "labelMatchResultHome";
            this.labelMatchResultHome.Size = new System.Drawing.Size(78, 17);
            this.labelMatchResultHome.TabIndex = 1;
            this.labelMatchResultHome.Text = "Gospodarz";
            // 
            // numericUpDownResultHome
            // 
            this.numericUpDownResultHome.Location = new System.Drawing.Point(139, 78);
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
            this.numericUpDownResultHome.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownResultHome.TabIndex = 4;
            this.numericUpDownResultHome.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numericUpDownResultAway
            // 
            this.numericUpDownResultAway.Location = new System.Drawing.Point(311, 78);
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
            this.numericUpDownResultAway.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownResultAway.TabIndex = 5;
            this.numericUpDownResultAway.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelMatchResultAway
            // 
            this.labelMatchResultAway.AutoSize = true;
            this.labelMatchResultAway.Location = new System.Drawing.Point(224, 83);
            this.labelMatchResultAway.Name = "labelMatchResultAway";
            this.labelMatchResultAway.Size = new System.Drawing.Size(41, 17);
            this.labelMatchResultAway.TabIndex = 6;
            this.labelMatchResultAway.Text = "Gość";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(139, 129);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(113, 36);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Potwierdź";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FormUpdateMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 180);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelMatchResultAway);
            this.Controls.Add(this.numericUpDownResultAway);
            this.Controls.Add(this.numericUpDownResultHome);
            this.Controls.Add(this.labelMatchResultHome);
            this.Name = "FormUpdateMatch";
            this.Text = "FormUpdateMatch";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResultHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResultAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMatchResultHome;
        private System.Windows.Forms.NumericUpDown numericUpDownResultHome;
        private System.Windows.Forms.NumericUpDown numericUpDownResultAway;
        private System.Windows.Forms.Label labelMatchResultAway;
        private System.Windows.Forms.Button buttonApply;
    }
}