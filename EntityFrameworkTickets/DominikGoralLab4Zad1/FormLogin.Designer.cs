namespace DominikGoralLab4Zad1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelUp = new System.Windows.Forms.Panel();
            this.pictureBoxInfoUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfoEmployee = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelDown = new System.Windows.Forms.Panel();
            this.userControlUserLogIn1 = new DominikGoralLab4Zad1.UserControlUserLogIn();
            this.userControlEmployeeLogIn1 = new DominikGoralLab4Zad1.UserControlEmployeeLogIn();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.pictureBoxInfoUser);
            this.panelUp.Controls.Add(this.pictureBoxInfoEmployee);
            this.panelUp.Controls.Add(this.pictureBoxEmployee);
            this.panelUp.Controls.Add(this.pictureBoxUser);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(800, 130);
            this.panelUp.TabIndex = 0;
            // 
            // pictureBoxInfoUser
            // 
            this.pictureBoxInfoUser.Image = global::DominikGoralLab4Zad1.Properties.Resources.UserInfo;
            this.pictureBoxInfoUser.Location = new System.Drawing.Point(401, 0);
            this.pictureBoxInfoUser.Name = "pictureBoxInfoUser";
            this.pictureBoxInfoUser.Size = new System.Drawing.Size(136, 130);
            this.pictureBoxInfoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfoUser.TabIndex = 3;
            this.pictureBoxInfoUser.TabStop = false;
            // 
            // pictureBoxInfoEmployee
            // 
            this.pictureBoxInfoEmployee.Image = global::DominikGoralLab4Zad1.Properties.Resources.EmployeeInfo;
            this.pictureBoxInfoEmployee.Location = new System.Drawing.Point(263, 0);
            this.pictureBoxInfoEmployee.Name = "pictureBoxInfoEmployee";
            this.pictureBoxInfoEmployee.Size = new System.Drawing.Size(136, 130);
            this.pictureBoxInfoEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfoEmployee.TabIndex = 2;
            this.pictureBoxInfoEmployee.TabStop = false;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Image = global::DominikGoralLab4Zad1.Properties.Resources.admin3;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(257, 130);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmployee.TabIndex = 1;
            this.pictureBoxEmployee.TabStop = false;
            this.pictureBoxEmployee.Click += new System.EventHandler(this.pictureBoxEmployee_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::DominikGoralLab4Zad1.Properties.Resources.UserIcon;
            this.pictureBoxUser.Location = new System.Drawing.Point(543, 0);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(257, 130);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.labelExit);
            this.panelDown.Controls.Add(this.pictureBoxExit);
            this.panelDown.Controls.Add(this.userControlUserLogIn1);
            this.panelDown.Controls.Add(this.userControlEmployeeLogIn1);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDown.Location = new System.Drawing.Point(0, 130);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(800, 414);
            this.panelDown.TabIndex = 1;
            // 
            // userControlUserLogIn1
            // 
            this.userControlUserLogIn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlUserLogIn1.BackgroundImage")));
            this.userControlUserLogIn1.Location = new System.Drawing.Point(0, 0);
            this.userControlUserLogIn1.Name = "userControlUserLogIn1";
            this.userControlUserLogIn1.Size = new System.Drawing.Size(800, 414);
            this.userControlUserLogIn1.TabIndex = 1;
            // 
            // userControlEmployeeLogIn1
            // 
            this.userControlEmployeeLogIn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlEmployeeLogIn1.BackgroundImage")));
            this.userControlEmployeeLogIn1.Location = new System.Drawing.Point(0, 0);
            this.userControlEmployeeLogIn1.Name = "userControlEmployeeLogIn1";
            this.userControlEmployeeLogIn1.Size = new System.Drawing.Size(800, 414);
            this.userControlEmployeeLogIn1.TabIndex = 0;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.Image = global::DominikGoralLab4Zad1.Properties.Resources.CancelButton;
            this.pictureBoxExit.Location = new System.Drawing.Point(717, 38);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExit.Location = new System.Drawing.Point(726, 3);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(62, 35);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "EXIT";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.Panel panelDown;
        private UserControlEmployeeLogIn userControlEmployeeLogIn1;
        private UserControlUserLogIn userControlUserLogIn1;
        private System.Windows.Forms.PictureBox pictureBoxInfoUser;
        private System.Windows.Forms.PictureBox pictureBoxInfoEmployee;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}