namespace DominikGoralLab4Zad1
{
    partial class UserControlUserLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUserLogIn));
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.pictureBoxUserRegister = new System.Windows.Forms.PictureBox();
            this.pictureBoxApply = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserIcon = new System.Windows.Forms.PictureBox();
            this.userControlUserRegister1 = new DominikGoralLab4Zad1.UserControlUserRegister();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(402, 242);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.PasswordChar = '*';
            this.textBoxUserPassword.Size = new System.Drawing.Size(159, 22);
            this.textBoxUserPassword.TabIndex = 9;
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Location = new System.Drawing.Point(402, 173);
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(159, 22);
            this.textBoxUserLogin.TabIndex = 8;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelUserPassword.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserPassword.Location = new System.Drawing.Point(303, 237);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(57, 25);
            this.labelUserPassword.TabIndex = 7;
            this.labelUserPassword.Text = "Hasło";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelUserLogin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserLogin.Location = new System.Drawing.Point(193, 168);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(167, 25);
            this.labelUserLogin.TabIndex = 6;
            this.labelUserLogin.Text = "Nazwa użytkownika";
            // 
            // pictureBoxUserRegister
            // 
            this.pictureBoxUserRegister.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUserRegister.Image = global::DominikGoralLab4Zad1.Properties.Resources.RegisterButton;
            this.pictureBoxUserRegister.Location = new System.Drawing.Point(640, 3);
            this.pictureBoxUserRegister.Name = "pictureBoxUserRegister";
            this.pictureBoxUserRegister.Size = new System.Drawing.Size(157, 81);
            this.pictureBoxUserRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserRegister.TabIndex = 12;
            this.pictureBoxUserRegister.TabStop = false;
            this.pictureBoxUserRegister.Click += new System.EventHandler(this.pictureBoxUserRegister_Click);
            // 
            // pictureBoxApply
            // 
            this.pictureBoxApply.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxApply.Image = global::DominikGoralLab4Zad1.Properties.Resources.LogInButton;
            this.pictureBoxApply.Location = new System.Drawing.Point(335, 297);
            this.pictureBoxApply.Name = "pictureBoxApply";
            this.pictureBoxApply.Size = new System.Drawing.Size(120, 50);
            this.pictureBoxApply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxApply.TabIndex = 11;
            this.pictureBoxApply.TabStop = false;
            this.pictureBoxApply.Click += new System.EventHandler(this.pictureBoxApply_Click);
            // 
            // pictureBoxUserIcon
            // 
            this.pictureBoxUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUserIcon.Image = global::DominikGoralLab4Zad1.Properties.Resources.UserIcon;
            this.pictureBoxUserIcon.Location = new System.Drawing.Point(335, 27);
            this.pictureBoxUserIcon.Name = "pictureBoxUserIcon";
            this.pictureBoxUserIcon.Size = new System.Drawing.Size(120, 100);
            this.pictureBoxUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserIcon.TabIndex = 10;
            this.pictureBoxUserIcon.TabStop = false;
            // 
            // userControlUserRegister1
            // 
            this.userControlUserRegister1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlUserRegister1.BackgroundImage")));
            this.userControlUserRegister1.Location = new System.Drawing.Point(0, 0);
            this.userControlUserRegister1.Name = "userControlUserRegister1";
            this.userControlUserRegister1.Size = new System.Drawing.Size(800, 414);
            this.userControlUserRegister1.TabIndex = 13;
            // 
            // UserControlUserLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundCut;
            this.Controls.Add(this.userControlUserRegister1);
            this.Controls.Add(this.pictureBoxUserRegister);
            this.Controls.Add(this.pictureBoxApply);
            this.Controls.Add(this.pictureBoxUserIcon);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUserLogin);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserLogin);
            this.Name = "UserControlUserLogIn";
            this.Size = new System.Drawing.Size(800, 414);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxApply;
        private System.Windows.Forms.PictureBox pictureBoxUserIcon;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.PictureBox pictureBoxUserRegister;
        private UserControlUserRegister userControlUserRegister1;
    }
}
