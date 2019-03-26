namespace DominikGoralLab4Zad1
{
    partial class UserControlUserEditor
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
            this.dataGridViewUsersEditor = new System.Windows.Forms.DataGridView();
            this.labelPlanes = new System.Windows.Forms.Label();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBoxEditUserTelephoneNumber = new System.Windows.Forms.PictureBox();
            this.labelNewCapacity = new System.Windows.Forms.Label();
            this.textBoxNewUserTelephoneNumber = new System.Windows.Forms.TextBox();
            this.pictureBoxDeleteUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditUserTelephoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsersEditor
            // 
            this.dataGridViewUsersEditor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsersEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersEditor.Location = new System.Drawing.Point(30, 117);
            this.dataGridViewUsersEditor.Name = "dataGridViewUsersEditor";
            this.dataGridViewUsersEditor.RowTemplate.Height = 24;
            this.dataGridViewUsersEditor.Size = new System.Drawing.Size(501, 284);
            this.dataGridViewUsersEditor.TabIndex = 0;
            // 
            // labelPlanes
            // 
            this.labelPlanes.AutoSize = true;
            this.labelPlanes.BackColor = System.Drawing.Color.Transparent;
            this.labelPlanes.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlanes.Location = new System.Drawing.Point(17, 20);
            this.labelPlanes.Name = "labelPlanes";
            this.labelPlanes.Size = new System.Drawing.Size(335, 75);
            this.labelPlanes.TabIndex = 1;
            this.labelPlanes.Text = "Użytkownicy";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRefresh.Image = global::DominikGoralLab4Zad1.Properties.Resources.load;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(433, 13);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(98, 98);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 8;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // pictureBoxEditUserTelephoneNumber
            // 
            this.pictureBoxEditUserTelephoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEditUserTelephoneNumber.Image = global::DominikGoralLab4Zad1.Properties.Resources.EditButton;
            this.pictureBoxEditUserTelephoneNumber.Location = new System.Drawing.Point(600, 117);
            this.pictureBoxEditUserTelephoneNumber.Name = "pictureBoxEditUserTelephoneNumber";
            this.pictureBoxEditUserTelephoneNumber.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxEditUserTelephoneNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditUserTelephoneNumber.TabIndex = 9;
            this.pictureBoxEditUserTelephoneNumber.TabStop = false;
            this.pictureBoxEditUserTelephoneNumber.Click += new System.EventHandler(this.pictureBoxEditUserTelephoneNumber_Click);
            // 
            // labelNewCapacity
            // 
            this.labelNewCapacity.AutoSize = true;
            this.labelNewCapacity.BackColor = System.Drawing.Color.Transparent;
            this.labelNewCapacity.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNewCapacity.Location = new System.Drawing.Point(595, 29);
            this.labelNewCapacity.Name = "labelNewCapacity";
            this.labelNewCapacity.Size = new System.Drawing.Size(111, 25);
            this.labelNewCapacity.TabIndex = 10;
            this.labelNewCapacity.Text = "Nowy numer";
            // 
            // textBoxNewUserTelephoneNumber
            // 
            this.textBoxNewUserTelephoneNumber.Location = new System.Drawing.Point(600, 66);
            this.textBoxNewUserTelephoneNumber.Name = "textBoxNewUserTelephoneNumber";
            this.textBoxNewUserTelephoneNumber.Size = new System.Drawing.Size(136, 22);
            this.textBoxNewUserTelephoneNumber.TabIndex = 11;
            // 
            // pictureBoxDeleteUser
            // 
            this.pictureBoxDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDeleteUser.Image = global::DominikGoralLab4Zad1.Properties.Resources.CancelButton;
            this.pictureBoxDeleteUser.Location = new System.Drawing.Point(600, 265);
            this.pictureBoxDeleteUser.Name = "pictureBoxDeleteUser";
            this.pictureBoxDeleteUser.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxDeleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeleteUser.TabIndex = 12;
            this.pictureBoxDeleteUser.TabStop = false;
            this.pictureBoxDeleteUser.Click += new System.EventHandler(this.pictureBoxDeleteUser_Click);
            // 
            // UserControlUserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DominikGoralLab4Zad1.Properties.Resources.BackgroundCut;
            this.Controls.Add(this.pictureBoxDeleteUser);
            this.Controls.Add(this.textBoxNewUserTelephoneNumber);
            this.Controls.Add(this.labelNewCapacity);
            this.Controls.Add(this.pictureBoxEditUserTelephoneNumber);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.labelPlanes);
            this.Controls.Add(this.dataGridViewUsersEditor);
            this.Name = "UserControlUserEditor";
            this.Size = new System.Drawing.Size(800, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditUserTelephoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsersEditor;
        private System.Windows.Forms.Label labelPlanes;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.PictureBox pictureBoxEditUserTelephoneNumber;
        private System.Windows.Forms.Label labelNewCapacity;
        private System.Windows.Forms.TextBox textBoxNewUserTelephoneNumber;
        private System.Windows.Forms.PictureBox pictureBoxDeleteUser;
    }
}
