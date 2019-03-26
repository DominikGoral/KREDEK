namespace DominikGoralLab4Zad1
{
    partial class FormMainForEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainForEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxDurationEditor = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsersEditor = new System.Windows.Forms.PictureBox();
            this.pictureBoxTicketEditor = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogOut = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlUserEditor1 = new DominikGoralLab4Zad1.UserControlUserEditor();
            this.userControlTicketEditor1 = new DominikGoralLab4Zad1.UserControlTicketEditor();
            this.userControlDurationEditor1 = new DominikGoralLab4Zad1.UserControlDurationEditor();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDurationEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsersEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTicketEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundForPanel;
            this.panel1.Controls.Add(this.pictureBoxDurationEditor);
            this.panel1.Controls.Add(this.pictureBoxUsersEditor);
            this.panel1.Controls.Add(this.pictureBoxTicketEditor);
            this.panel1.Controls.Add(this.pictureBoxLogOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 129);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxDurationEditor
            // 
            this.pictureBoxDurationEditor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDurationEditor.Image = global::DominikGoralLab4Zad1.Properties.Resources.TimeButton;
            this.pictureBoxDurationEditor.Location = new System.Drawing.Point(279, 0);
            this.pictureBoxDurationEditor.Name = "pictureBoxDurationEditor";
            this.pictureBoxDurationEditor.Size = new System.Drawing.Size(125, 129);
            this.pictureBoxDurationEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDurationEditor.TabIndex = 4;
            this.pictureBoxDurationEditor.TabStop = false;
            this.pictureBoxDurationEditor.Click += new System.EventHandler(this.pictureBoxDurationEditor_Click);
            // 
            // pictureBoxUsersEditor
            // 
            this.pictureBoxUsersEditor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsersEditor.Image = global::DominikGoralLab4Zad1.Properties.Resources.UserIcon;
            this.pictureBoxUsersEditor.Location = new System.Drawing.Point(410, 0);
            this.pictureBoxUsersEditor.Name = "pictureBoxUsersEditor";
            this.pictureBoxUsersEditor.Size = new System.Drawing.Size(125, 129);
            this.pictureBoxUsersEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsersEditor.TabIndex = 3;
            this.pictureBoxUsersEditor.TabStop = false;
            this.pictureBoxUsersEditor.Click += new System.EventHandler(this.pictureBoxUsersEditor_Click);
            // 
            // pictureBoxTicketEditor
            // 
            this.pictureBoxTicketEditor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTicketEditor.Image = global::DominikGoralLab4Zad1.Properties.Resources.TicketButton;
            this.pictureBoxTicketEditor.Location = new System.Drawing.Point(541, 0);
            this.pictureBoxTicketEditor.Name = "pictureBoxTicketEditor";
            this.pictureBoxTicketEditor.Size = new System.Drawing.Size(125, 129);
            this.pictureBoxTicketEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTicketEditor.TabIndex = 2;
            this.pictureBoxTicketEditor.TabStop = false;
            this.pictureBoxTicketEditor.Click += new System.EventHandler(this.pictureBoxTicketEditor_Click);
            // 
            // pictureBoxLogOut
            // 
            this.pictureBoxLogOut.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogOut.Image = global::DominikGoralLab4Zad1.Properties.Resources.LogOutIcon;
            this.pictureBoxLogOut.Location = new System.Drawing.Point(672, 0);
            this.pictureBoxLogOut.Name = "pictureBoxLogOut";
            this.pictureBoxLogOut.Size = new System.Drawing.Size(125, 129);
            this.pictureBoxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogOut.TabIndex = 1;
            this.pictureBoxLogOut.TabStop = false;
            this.pictureBoxLogOut.Click += new System.EventHandler(this.pictureBoxLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edytor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControlUserEditor1);
            this.panel2.Controls.Add(this.userControlTicketEditor1);
            this.panel2.Controls.Add(this.userControlDurationEditor1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 448);
            this.panel2.TabIndex = 1;
            // 
            // userControlUserEditor1
            // 
            this.userControlUserEditor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlUserEditor1.BackgroundImage")));
            this.userControlUserEditor1.Location = new System.Drawing.Point(0, 0);
            this.userControlUserEditor1.Name = "userControlUserEditor1";
            this.userControlUserEditor1.Size = new System.Drawing.Size(800, 448);
            this.userControlUserEditor1.TabIndex = 2;
            // 
            // userControlTicketEditor1
            // 
            this.userControlTicketEditor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlTicketEditor1.BackgroundImage")));
            this.userControlTicketEditor1.Location = new System.Drawing.Point(0, 0);
            this.userControlTicketEditor1.Name = "userControlTicketEditor1";
            this.userControlTicketEditor1.Size = new System.Drawing.Size(800, 448);
            this.userControlTicketEditor1.TabIndex = 1;
            // 
            // userControlDurationEditor1
            // 
            this.userControlDurationEditor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlDurationEditor1.BackgroundImage")));
            this.userControlDurationEditor1.Location = new System.Drawing.Point(0, 0);
            this.userControlDurationEditor1.Name = "userControlDurationEditor1";
            this.userControlDurationEditor1.Size = new System.Drawing.Size(800, 448);
            this.userControlDurationEditor1.TabIndex = 0;
            // 
            // FormMainForEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainForEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainForEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDurationEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsersEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTicketEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogOut;
        private System.Windows.Forms.PictureBox pictureBoxTicketEditor;
        private System.Windows.Forms.PictureBox pictureBoxUsersEditor;
        private System.Windows.Forms.PictureBox pictureBoxDurationEditor;
        private UserControlUserEditor userControlUserEditor1;
        private UserControlTicketEditor userControlTicketEditor1;
        private UserControlDurationEditor userControlDurationEditor1;
    }
}