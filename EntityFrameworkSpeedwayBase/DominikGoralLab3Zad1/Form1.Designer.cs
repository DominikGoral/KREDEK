namespace DominikGoralLab3Zad1
{
    partial class FormMain
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
            this.panelUp = new System.Windows.Forms.Panel();
            this.labelInformation = new System.Windows.Forms.Label();
            this.pictureBoxTeams = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatches = new System.Windows.Forms.PictureBox();
            this.pictureBoxContestantsResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxSupporters = new System.Windows.Forms.PictureBox();
            this.pictureBoxContestants = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.userControlTeams1 = new DominikGoralLab3Zad1.UserControlTeams();
            this.userControlSupporters1 = new DominikGoralLab3Zad1.UserControlSupporters();
            this.userControlMatches1 = new DominikGoralLab3Zad1.UserControlMatches();
            this.userControlContestantResult1 = new DominikGoralLab3Zad1.UserControlContestantResult();
            this.userControlContestants1 = new DominikGoralLab3Zad1.UserControlContestants();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelContestants = new System.Windows.Forms.Label();
            this.labelTeams = new System.Windows.Forms.Label();
            this.labelMatches = new System.Windows.Forms.Label();
            this.labelSupporters = new System.Windows.Forms.Label();
            this.labelContestantsResult = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContestantsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupporters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContestants)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.DarkGray;
            this.panelUp.Controls.Add(this.labelContestantsResult);
            this.panelUp.Controls.Add(this.labelSupporters);
            this.panelUp.Controls.Add(this.labelMatches);
            this.panelUp.Controls.Add(this.labelTeams);
            this.panelUp.Controls.Add(this.labelContestants);
            this.panelUp.Controls.Add(this.labelInformation);
            this.panelUp.Controls.Add(this.pictureBoxTeams);
            this.panelUp.Controls.Add(this.pictureBoxMatches);
            this.panelUp.Controls.Add(this.pictureBoxContestantsResult);
            this.panelUp.Controls.Add(this.pictureBoxSupporters);
            this.panelUp.Controls.Add(this.pictureBoxContestants);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(958, 121);
            this.panelUp.TabIndex = 0;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Impact", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInformation.Location = new System.Drawing.Point(254, 23);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(326, 72);
            this.labelInformation.TabIndex = 6;
            this.labelInformation.Text = "Skarb kibica";
            // 
            // pictureBoxTeams
            // 
            this.pictureBoxTeams.Image = global::DominikGoralLab3Zad1.Properties.Resources.Polonia_Warsaw;
            this.pictureBoxTeams.Location = new System.Drawing.Point(127, 0);
            this.pictureBoxTeams.Name = "pictureBoxTeams";
            this.pictureBoxTeams.Size = new System.Drawing.Size(121, 121);
            this.pictureBoxTeams.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeams.TabIndex = 5;
            this.pictureBoxTeams.TabStop = false;
            this.pictureBoxTeams.Click += new System.EventHandler(this.pictureBoxTeams_Click);
            // 
            // pictureBoxMatches
            // 
            this.pictureBoxMatches.Image = global::DominikGoralLab3Zad1.Properties.Resources.finish;
            this.pictureBoxMatches.Location = new System.Drawing.Point(582, 0);
            this.pictureBoxMatches.Name = "pictureBoxMatches";
            this.pictureBoxMatches.Size = new System.Drawing.Size(121, 121);
            this.pictureBoxMatches.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatches.TabIndex = 4;
            this.pictureBoxMatches.TabStop = false;
            this.pictureBoxMatches.Click += new System.EventHandler(this.pictureBoxMatches_Click);
            // 
            // pictureBoxContestantsResult
            // 
            this.pictureBoxContestantsResult.Image = global::DominikGoralLab3Zad1.Properties.Resources.book;
            this.pictureBoxContestantsResult.Location = new System.Drawing.Point(837, 0);
            this.pictureBoxContestantsResult.Name = "pictureBoxContestantsResult";
            this.pictureBoxContestantsResult.Size = new System.Drawing.Size(121, 121);
            this.pictureBoxContestantsResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContestantsResult.TabIndex = 3;
            this.pictureBoxContestantsResult.TabStop = false;
            this.pictureBoxContestantsResult.Click += new System.EventHandler(this.pictureBoxContestantsResult_Click);
            // 
            // pictureBoxSupporters
            // 
            this.pictureBoxSupporters.Image = global::DominikGoralLab3Zad1.Properties.Resources.supporter;
            this.pictureBoxSupporters.Location = new System.Drawing.Point(709, 0);
            this.pictureBoxSupporters.Name = "pictureBoxSupporters";
            this.pictureBoxSupporters.Size = new System.Drawing.Size(121, 121);
            this.pictureBoxSupporters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSupporters.TabIndex = 2;
            this.pictureBoxSupporters.TabStop = false;
            this.pictureBoxSupporters.Click += new System.EventHandler(this.pictureBoxSupporters_Click);
            // 
            // pictureBoxContestants
            // 
            this.pictureBoxContestants.Image = global::DominikGoralLab3Zad1.Properties.Resources.helmet;
            this.pictureBoxContestants.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxContestants.Name = "pictureBoxContestants";
            this.pictureBoxContestants.Size = new System.Drawing.Size(121, 121);
            this.pictureBoxContestants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContestants.TabIndex = 1;
            this.pictureBoxContestants.TabStop = false;
            this.pictureBoxContestants.Click += new System.EventHandler(this.pictureBoxContestants_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.userControlTeams1);
            this.panelCentral.Controls.Add(this.userControlSupporters1);
            this.panelCentral.Controls.Add(this.userControlMatches1);
            this.panelCentral.Controls.Add(this.userControlContestantResult1);
            this.panelCentral.Controls.Add(this.userControlContestants1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 121);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(958, 505);
            this.panelCentral.TabIndex = 2;
            // 
            // userControlTeams1
            // 
            this.userControlTeams1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.userControlTeams1.Location = new System.Drawing.Point(0, 0);
            this.userControlTeams1.Name = "userControlTeams1";
            this.userControlTeams1.Size = new System.Drawing.Size(958, 506);
            this.userControlTeams1.TabIndex = 4;
            // 
            // userControlSupporters1
            // 
            this.userControlSupporters1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.userControlSupporters1.Location = new System.Drawing.Point(0, 0);
            this.userControlSupporters1.Name = "userControlSupporters1";
            this.userControlSupporters1.Size = new System.Drawing.Size(958, 505);
            this.userControlSupporters1.TabIndex = 3;
            // 
            // userControlMatches1
            // 
            this.userControlMatches1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.userControlMatches1.Location = new System.Drawing.Point(0, 0);
            this.userControlMatches1.Name = "userControlMatches1";
            this.userControlMatches1.Size = new System.Drawing.Size(958, 505);
            this.userControlMatches1.TabIndex = 2;
            // 
            // userControlContestantResult1
            // 
            this.userControlContestantResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.userControlContestantResult1.Location = new System.Drawing.Point(0, 0);
            this.userControlContestantResult1.Name = "userControlContestantResult1";
            this.userControlContestantResult1.Size = new System.Drawing.Size(958, 505);
            this.userControlContestantResult1.TabIndex = 1;
            // 
            // userControlContestants1
            // 
            this.userControlContestants1.BackColor = System.Drawing.Color.LightGray;
            this.userControlContestants1.Location = new System.Drawing.Point(0, 0);
            this.userControlContestants1.Name = "userControlContestants1";
            this.userControlContestants1.Size = new System.Drawing.Size(955, 496);
            this.userControlContestants1.TabIndex = 0;
            // 
            // labelContestants
            // 
            this.labelContestants.AutoSize = true;
            this.labelContestants.Location = new System.Drawing.Point(60, 101);
            this.labelContestants.Name = "labelContestants";
            this.labelContestants.Size = new System.Drawing.Size(75, 17);
            this.labelContestants.TabIndex = 7;
            this.labelContestants.Text = "Zawodnicy";
            // 
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.Location = new System.Drawing.Point(227, 101);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(60, 17);
            this.labelTeams.TabIndex = 8;
            this.labelTeams.Text = "Drużyny";
            // 
            // labelMatches
            // 
            this.labelMatches.AutoSize = true;
            this.labelMatches.Location = new System.Drawing.Point(635, 101);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(49, 17);
            this.labelMatches.TabIndex = 9;
            this.labelMatches.Text = "Mecze";
            // 
            // labelSupporters
            // 
            this.labelSupporters.AutoSize = true;
            this.labelSupporters.Location = new System.Drawing.Point(796, 101);
            this.labelSupporters.Name = "labelSupporters";
            this.labelSupporters.Size = new System.Drawing.Size(46, 17);
            this.labelSupporters.TabIndex = 10;
            this.labelSupporters.Text = "Kibice";
            // 
            // labelContestantsResult
            // 
            this.labelContestantsResult.AutoSize = true;
            this.labelContestantsResult.Location = new System.Drawing.Point(885, 101);
            this.labelContestantsResult.Name = "labelContestantsResult";
            this.labelContestantsResult.Size = new System.Drawing.Size(70, 17);
            this.labelContestantsResult.TabIndex = 11;
            this.labelContestantsResult.Text = "Zdobycze";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(958, 626);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelUp);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContestantsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupporters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContestants)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.PictureBox pictureBoxTeams;
        private System.Windows.Forms.PictureBox pictureBoxMatches;
        private System.Windows.Forms.PictureBox pictureBoxContestantsResult;
        private System.Windows.Forms.PictureBox pictureBoxSupporters;
        private System.Windows.Forms.PictureBox pictureBoxContestants;
        private System.Windows.Forms.Panel panelCentral;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControlTeams userControlTeams1;
        private UserControlSupporters userControlSupporters1;
        private UserControlMatches userControlMatches1;
        private UserControlContestantResult userControlContestantResult1;
        private UserControlContestants userControlContestants1;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label labelContestantsResult;
        private System.Windows.Forms.Label labelSupporters;
        private System.Windows.Forms.Label labelMatches;
        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.Label labelContestants;
    }
}

