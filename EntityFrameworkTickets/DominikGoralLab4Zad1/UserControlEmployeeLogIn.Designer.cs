namespace DominikGoralLab4Zad1
{
    partial class UserControlEmployeeLogIn
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
            this.labelEmployeeLogin = new System.Windows.Forms.Label();
            this.labelEmployeePassword = new System.Windows.Forms.Label();
            this.textBoxEmployeeLogin = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.pictureBoxApply = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmployeeIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployeeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmployeeLogin
            // 
            this.labelEmployeeLogin.AutoSize = true;
            this.labelEmployeeLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeLogin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmployeeLogin.Location = new System.Drawing.Point(180, 170);
            this.labelEmployeeLogin.Name = "labelEmployeeLogin";
            this.labelEmployeeLogin.Size = new System.Drawing.Size(167, 25);
            this.labelEmployeeLogin.TabIndex = 0;
            this.labelEmployeeLogin.Text = "Nazwa użytkownika";
            // 
            // labelEmployeePassword
            // 
            this.labelEmployeePassword.AutoSize = true;
            this.labelEmployeePassword.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeePassword.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmployeePassword.Location = new System.Drawing.Point(302, 239);
            this.labelEmployeePassword.Name = "labelEmployeePassword";
            this.labelEmployeePassword.Size = new System.Drawing.Size(57, 25);
            this.labelEmployeePassword.TabIndex = 1;
            this.labelEmployeePassword.Text = "Hasło";
            // 
            // textBoxEmployeeLogin
            // 
            this.textBoxEmployeeLogin.Location = new System.Drawing.Point(401, 174);
            this.textBoxEmployeeLogin.Name = "textBoxEmployeeLogin";
            this.textBoxEmployeeLogin.Size = new System.Drawing.Size(159, 22);
            this.textBoxEmployeeLogin.TabIndex = 2;
            // 
            // textBoxEmployeePassword
            // 
            this.textBoxEmployeePassword.Location = new System.Drawing.Point(401, 243);
            this.textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            this.textBoxEmployeePassword.PasswordChar = '*';
            this.textBoxEmployeePassword.Size = new System.Drawing.Size(159, 22);
            this.textBoxEmployeePassword.TabIndex = 3;
            // 
            // pictureBoxApply
            // 
            this.pictureBoxApply.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxApply.Image = global::DominikGoralLab4Zad1.Properties.Resources.LogInButton;
            this.pictureBoxApply.Location = new System.Drawing.Point(334, 298);
            this.pictureBoxApply.Name = "pictureBoxApply";
            this.pictureBoxApply.Size = new System.Drawing.Size(120, 50);
            this.pictureBoxApply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxApply.TabIndex = 5;
            this.pictureBoxApply.TabStop = false;
            this.pictureBoxApply.Click += new System.EventHandler(this.pictureBoxApply_Click);
            // 
            // pictureBoxEmployeeIcon
            // 
            this.pictureBoxEmployeeIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEmployeeIcon.Image = global::DominikGoralLab4Zad1.Properties.Resources.admin3;
            this.pictureBoxEmployeeIcon.Location = new System.Drawing.Point(334, 28);
            this.pictureBoxEmployeeIcon.Name = "pictureBoxEmployeeIcon";
            this.pictureBoxEmployeeIcon.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxEmployeeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmployeeIcon.TabIndex = 4;
            this.pictureBoxEmployeeIcon.TabStop = false;
            // 
            // UserControlEmployeeLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundCut;
            this.Controls.Add(this.pictureBoxApply);
            this.Controls.Add(this.pictureBoxEmployeeIcon);
            this.Controls.Add(this.textBoxEmployeePassword);
            this.Controls.Add(this.textBoxEmployeeLogin);
            this.Controls.Add(this.labelEmployeePassword);
            this.Controls.Add(this.labelEmployeeLogin);
            this.Name = "UserControlEmployeeLogIn";
            this.Size = new System.Drawing.Size(800, 414);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployeeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployeeLogin;
        private System.Windows.Forms.Label labelEmployeePassword;
        private System.Windows.Forms.TextBox textBoxEmployeeLogin;
        private System.Windows.Forms.TextBox textBoxEmployeePassword;
        private System.Windows.Forms.PictureBox pictureBoxEmployeeIcon;
        private System.Windows.Forms.PictureBox pictureBoxApply;
    }
}
