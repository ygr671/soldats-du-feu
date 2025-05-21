namespace UC_Mission
{
    partial class Mission
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mission));
            this.pnlMission = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbGenererPDF = new System.Windows.Forms.PictureBox();
            this.lblMotifAppel = new System.Windows.Forms.Label();
            this.lblLNatureSinistre = new System.Windows.Forms.Label();
            this.pbAlarme = new System.Windows.Forms.PictureBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenererPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarme)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMission
            // 
            this.pnlMission.Controls.Add(this.pictureBox2);
            this.pnlMission.Controls.Add(this.pbGenererPDF);
            this.pnlMission.Controls.Add(this.lblMotifAppel);
            this.pnlMission.Controls.Add(this.lblLNatureSinistre);
            this.pnlMission.Controls.Add(this.pbAlarme);
            this.pnlMission.Controls.Add(this.lblCaserne);
            this.pnlMission.Controls.Add(this.lblDateDebut);
            this.pnlMission.Controls.Add(this.lblID);
            this.pnlMission.Location = new System.Drawing.Point(4, 5);
            this.pnlMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(742, 130);
            this.pnlMission.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(689, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pbGenererPDF
            // 
            this.pbGenererPDF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbGenererPDF.Image = ((System.Drawing.Image)(resources.GetObject("pbGenererPDF.Image")));
            this.pbGenererPDF.Location = new System.Drawing.Point(689, 3);
            this.pbGenererPDF.Name = "pbGenererPDF";
            this.pbGenererPDF.Size = new System.Drawing.Size(50, 50);
            this.pbGenererPDF.TabIndex = 6;
            this.pbGenererPDF.TabStop = false;
            this.pbGenererPDF.Click += new System.EventHandler(this.pbGenererPDF_Click);
            // 
            // lblMotifAppel
            // 
            this.lblMotifAppel.AutoSize = true;
            this.lblMotifAppel.Location = new System.Drawing.Point(375, 65);
            this.lblMotifAppel.Name = "lblMotifAppel";
            this.lblMotifAppel.Size = new System.Drawing.Size(32, 20);
            this.lblMotifAppel.TabIndex = 5;
            this.lblMotifAppel.Text = "--> ";
            // 
            // lblLNatureSinistre
            // 
            this.lblLNatureSinistre.AutoSize = true;
            this.lblLNatureSinistre.Location = new System.Drawing.Point(140, 65);
            this.lblLNatureSinistre.Name = "lblLNatureSinistre";
            this.lblLNatureSinistre.Size = new System.Drawing.Size(28, 20);
            this.lblLNatureSinistre.TabIndex = 4;
            this.lblLNatureSinistre.Text = "-->";
            // 
            // pbAlarme
            // 
            this.pbAlarme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbAlarme.Image = ((System.Drawing.Image)(resources.GetObject("pbAlarme.Image")));
            this.pbAlarme.Location = new System.Drawing.Point(8, 32);
            this.pbAlarme.Name = "pbAlarme";
            this.pbAlarme.Size = new System.Drawing.Size(90, 90);
            this.pbAlarme.TabIndex = 3;
            this.pbAlarme.TabStop = false;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(375, 9);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(81, 20);
            this.lblCaserne.TabIndex = 2;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(140, 9);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(73, 20);
            this.lblDateDebut.TabIndex = 1;
            this.lblDateDebut.Text = "Début le ";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 9);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Mission :";
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlMission);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(750, 140);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.pnlMission.ResumeLayout(false);
            this.pnlMission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenererPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMission;
        private System.Windows.Forms.PictureBox pbAlarme;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMotifAppel;
        private System.Windows.Forms.Label lblLNatureSinistre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbGenererPDF;
    }
}
