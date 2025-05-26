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
            this.btnInfos = new System.Windows.Forms.Button();
            this.btnGenererPDF = new System.Windows.Forms.Button();
            this.lblMotifAppel = new System.Windows.Forms.Label();
            this.lblLNatureSinistre = new System.Windows.Forms.Label();
            this.pbAlarme = new System.Windows.Forms.PictureBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarme)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMission
            // 
            this.pnlMission.Controls.Add(this.btnInfos);
            this.pnlMission.Controls.Add(this.btnGenererPDF);
            this.pnlMission.Controls.Add(this.lblMotifAppel);
            this.pnlMission.Controls.Add(this.lblLNatureSinistre);
            this.pnlMission.Controls.Add(this.pbAlarme);
            this.pnlMission.Controls.Add(this.lblCaserne);
            this.pnlMission.Controls.Add(this.lblDateDebut);
            this.pnlMission.Controls.Add(this.lblID);
            this.pnlMission.Location = new System.Drawing.Point(4, 5);
            this.pnlMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMission.Name = "pnlMission";
            this.pnlMission.Size = new System.Drawing.Size(1066, 130);
            this.pnlMission.TabIndex = 0;
            // 
            // btnInfos
            // 
            this.btnInfos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfos.BackgroundImage")));
            this.btnInfos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfos.Location = new System.Drawing.Point(1013, 77);
            this.btnInfos.Name = "btnInfos";
            this.btnInfos.Size = new System.Drawing.Size(50, 50);
            this.btnInfos.TabIndex = 9;
            this.btnInfos.UseVisualStyleBackColor = true;
            this.btnInfos.Click += new System.EventHandler(this.btnInfos_Click);
            // 
            // btnGenererPDF
            // 
            this.btnGenererPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenererPDF.BackgroundImage")));
            this.btnGenererPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenererPDF.Location = new System.Drawing.Point(1013, 3);
            this.btnGenererPDF.Name = "btnGenererPDF";
            this.btnGenererPDF.Size = new System.Drawing.Size(50, 50);
            this.btnGenererPDF.TabIndex = 8;
            this.btnGenererPDF.UseVisualStyleBackColor = true;
            this.btnGenererPDF.Click += new System.EventHandler(this.btnGenererPDF_Click);
            // 
            // lblMotifAppel
            // 
            this.lblMotifAppel.AutoSize = true;
            this.lblMotifAppel.Location = new System.Drawing.Point(492, 65);
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
            this.lblLNatureSinistre.Size = new System.Drawing.Size(32, 20);
            this.lblLNatureSinistre.TabIndex = 4;
            this.lblLNatureSinistre.Text = "--> ";
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
            this.lblCaserne.Location = new System.Drawing.Point(492, 9);
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
            this.lblID.Size = new System.Drawing.Size(95, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Mission : ";
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.pnlMission);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(1074, 140);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.pnlMission.ResumeLayout(false);
            this.pnlMission.PerformLayout();
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
        private System.Windows.Forms.Button btnGenererPDF;
        private System.Windows.Forms.Button btnInfos;
    }
}
