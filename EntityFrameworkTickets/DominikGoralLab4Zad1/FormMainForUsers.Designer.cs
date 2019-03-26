namespace DominikGoralLab4Zad1
{
    partial class FormMainForUsers
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainForUsers));
            this.panelDown = new System.Windows.Forms.Panel();
            this.userControlTicketsForUser1 = new DominikGoralLab4Zad1.UserControlTicketsForUser();
            this.userControlBasket1 = new DominikGoralLab4Zad1.UserControlBasket();
            this.panelUp = new System.Windows.Forms.Panel();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBoxBasket = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.panelDown.SuspendLayout();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.userControlTicketsForUser1);
            this.panelDown.Controls.Add(this.userControlBasket1);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDown.Location = new System.Drawing.Point(0, 129);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(800, 448);
            this.panelDown.TabIndex = 1;
            // 
            // userControlTicketsForUser1
            // 
            this.userControlTicketsForUser1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlTicketsForUser1.BackgroundImage")));
            this.userControlTicketsForUser1.Location = new System.Drawing.Point(0, 0);
            this.userControlTicketsForUser1.Name = "userControlTicketsForUser1";
            this.userControlTicketsForUser1.Size = new System.Drawing.Size(800, 448);
            this.userControlTicketsForUser1.TabIndex = 1;
            // 
            // userControlBasket1
            // 
            this.userControlBasket1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlBasket1.BackgroundImage")));
            this.userControlBasket1.Location = new System.Drawing.Point(0, 0);
            this.userControlBasket1.Name = "userControlBasket1";
            this.userControlBasket1.Size = new System.Drawing.Size(800, 448);
            this.userControlBasket1.TabIndex = 0;
            // 
            // panelUp
            // 
            this.panelUp.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundForPanel;
            this.panelUp.Controls.Add(this.pictureBoxPlane);
            this.panelUp.Controls.Add(this.labelInfo);
            this.panelUp.Controls.Add(this.pictureBoxBasket);
            this.panelUp.Controls.Add(this.pictureBoxLogOut);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(800, 129);
            this.panelUp.TabIndex = 0;
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlane.Image = global::DominikGoralLab4Zad1.Properties.Resources.PlaneIcon;
            this.pictureBoxPlane.Location = new System.Drawing.Point(353, 12);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(174, 95);
            this.pictureBoxPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlane.TabIndex = 3;
            this.pictureBoxPlane.TabStop = false;
            this.pictureBoxPlane.Click += new System.EventHandler(this.pictureBoxPlane_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(335, 98);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "KUPBILET";
            // 
            // pictureBoxBasket
            // 
            this.pictureBoxBasket.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBasket.Image = global::DominikGoralLab4Zad1.Properties.Resources.BasketIcon;
            this.pictureBoxBasket.Location = new System.Drawing.Point(541, 0);
            this.pictureBoxBasket.Name = "pictureBoxBasket";
            this.pictureBoxBasket.Size = new System.Drawing.Size(125, 129);
            this.pictureBoxBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBasket.TabIndex = 1;
            this.pictureBoxBasket.TabStop = false;
            this.pictureBoxBasket.Click += new System.EventHandler(this.pictureBoxBasket_Click);
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogOut.Image = global::DominikGoralLab4Zad1.Properties.Resources.LogOutIcon;
            this.pictureBoxLogOut.Location = new System.Drawing.Point(672, 0);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(125, 129);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogOut.TabIndex = 0;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // FormMainForUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainForUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelDown.ResumeLayout(false);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.PictureBox pictureBoxBasket;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
        private System.Windows.Forms.Panel panelDown;
        private UserControlTicketsForUser userControlTicketsForUser1;
        private UserControlBasket userControlBasket1;
    }
}

