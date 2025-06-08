namespace prjSoldatsDuFeu
{
    partial class UC_CreerMission
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
            this.cbNatureSinistre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMobilisation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPompiers = new System.Windows.Forms.DataGridView();
            this.dgvEngins = new System.Windows.Forms.DataGridView();
            this.flpPompiers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpEngins = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePostale = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.lblAdresseSinistre = new System.Windows.Forms.Label();
            this.btnMAJ = new System.Windows.Forms.Button();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnConstituerEquipe = new System.Windows.Forms.Button();
            this.cbCaserneImmobiliser = new System.Windows.Forms.ComboBox();
            this.gbDecisionRegulateur = new System.Windows.Forms.GroupBox();
            this.gbInformationsUsager = new System.Windows.Forms.GroupBox();
            this.lblDateDeclanchee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdMission = new System.Windows.Forms.Label();
            this.gbMobilisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).BeginInit();
            this.gbDecisionRegulateur.SuspendLayout();
            this.gbInformationsUsager.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNatureSinistre
            // 
            this.cbNatureSinistre.FormattingEnabled = true;
            this.cbNatureSinistre.Location = new System.Drawing.Point(267, 65);
            this.cbNatureSinistre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNatureSinistre.Name = "cbNatureSinistre";
            this.cbNatureSinistre.Size = new System.Drawing.Size(473, 37);
            this.cbNatureSinistre.TabIndex = 18;
            this.cbNatureSinistre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNatureSinistre_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Caserne Immobiliser : ";
            // 
            // gbMobilisation
            // 
            this.gbMobilisation.Controls.Add(this.label4);
            this.gbMobilisation.Controls.Add(this.label5);
            this.gbMobilisation.Controls.Add(this.dgvPompiers);
            this.gbMobilisation.Controls.Add(this.dgvEngins);
            this.gbMobilisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMobilisation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbMobilisation.Location = new System.Drawing.Point(803, 952);
            this.gbMobilisation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMobilisation.Name = "gbMobilisation";
            this.gbMobilisation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMobilisation.Size = new System.Drawing.Size(11, 12);
            this.gbMobilisation.TabIndex = 29;
            this.gbMobilisation.TabStop = false;
            this.gbMobilisation.Text = "Mobilisation des engins et des pompiers";
            this.gbMobilisation.Visible = false;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(170, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Engins Mobilisés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1020, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pompiers Mobilisés";
            // 
            // dgvPompiers
            // 
            this.dgvPompiers.AllowUserToAddRows = false;
            this.dgvPompiers.AllowUserToDeleteRows = false;
            this.dgvPompiers.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPompiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompiers.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPompiers.Location = new System.Drawing.Point(764, 79);
            this.dgvPompiers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPompiers.Name = "dgvPompiers";
            this.dgvPompiers.ReadOnly = true;
            this.dgvPompiers.RowHeadersWidth = 51;
            this.dgvPompiers.RowTemplate.Height = 24;
            this.dgvPompiers.Size = new System.Drawing.Size(684, 264);
            this.dgvPompiers.TabIndex = 1;
            // 
            // dgvEngins
            // 
            this.dgvEngins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngins.Location = new System.Drawing.Point(12, 79);
            this.dgvEngins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEngins.Name = "dgvEngins";
            this.dgvEngins.ReadOnly = true;
            this.dgvEngins.RowHeadersWidth = 51;
            this.dgvEngins.RowTemplate.Height = 24;
            this.dgvEngins.Size = new System.Drawing.Size(703, 264);
            this.dgvEngins.TabIndex = 0;
            this.dgvEngins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEngins_CellContentClick_1);
            // 
            // flpPompiers
            // 
            this.flpPompiers.AutoScroll = true;
            this.flpPompiers.BackColor = System.Drawing.Color.DarkGray;
            this.flpPompiers.Location = new System.Drawing.Point(803, 520);
            this.flpPompiers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpPompiers.Name = "flpPompiers";
            this.flpPompiers.Size = new System.Drawing.Size(784, 264);
            this.flpPompiers.TabIndex = 20;
            // 
            // flpEngins
            // 
            this.flpEngins.AutoScroll = true;
            this.flpEngins.BackColor = System.Drawing.Color.DarkGray;
            this.flpEngins.Location = new System.Drawing.Point(65, 520);
            this.flpEngins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpEngins.Name = "flpEngins";
            this.flpEngins.Size = new System.Drawing.Size(703, 264);
            this.flpEngins.TabIndex = 19;
            this.flpEngins.Paint += new System.Windows.Forms.PaintEventHandler(this.flpEngins_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nature du Sinistre : ";
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(214, 240);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(426, 125);
            this.txtMotif.TabIndex = 14;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(214, 179);
            this.txtVille.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(426, 35);
            this.txtVille.TabIndex = 13;
            // 
            // txtCodePostale
            // 
            this.txtCodePostale.Location = new System.Drawing.Point(214, 129);
            this.txtCodePostale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodePostale.Name = "txtCodePostale";
            this.txtCodePostale.Size = new System.Drawing.Size(426, 35);
            this.txtCodePostale.TabIndex = 12;
            this.txtCodePostale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePostale_KeyPress);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(214, 82);
            this.txtRue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(426, 35);
            this.txtRue.TabIndex = 10;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(46, 185);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(72, 29);
            this.lblVille.TabIndex = 9;
            this.lblVille.Text = "Ville :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(46, 86);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(69, 29);
            this.lblRue.TabIndex = 8;
            this.lblRue.Text = "Rue :";
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Location = new System.Drawing.Point(46, 135);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(171, 29);
            this.lblCodePostale.TabIndex = 7;
            this.lblCodePostale.Text = "Code Postale :";
            // 
            // lblAdresseSinistre
            // 
            this.lblAdresseSinistre.AutoSize = true;
            this.lblAdresseSinistre.Location = new System.Drawing.Point(309, 32);
            this.lblAdresseSinistre.Name = "lblAdresseSinistre";
            this.lblAdresseSinistre.Size = new System.Drawing.Size(189, 29);
            this.lblAdresseSinistre.TabIndex = 6;
            this.lblAdresseSinistre.Text = "Adresse Sinistre";
            // 
            // btnMAJ
            // 
            this.btnMAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAJ.Location = new System.Drawing.Point(1276, 906);
            this.btnMAJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMAJ.Name = "btnMAJ";
            this.btnMAJ.Size = new System.Drawing.Size(312, 78);
            this.btnMAJ.TabIndex = 31;
            this.btnMAJ.Text = "Creer Mission";
            this.btnMAJ.UseVisualStyleBackColor = true;
            this.btnMAJ.Click += new System.EventHandler(this.btnMAJ_Click_1);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(48, 244);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(77, 29);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "Motif :";
            // 
            // btnConstituerEquipe
            // 
            this.btnConstituerEquipe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConstituerEquipe.Location = new System.Drawing.Point(267, 271);
            this.btnConstituerEquipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConstituerEquipe.Name = "btnConstituerEquipe";
            this.btnConstituerEquipe.Size = new System.Drawing.Size(412, 81);
            this.btnConstituerEquipe.TabIndex = 17;
            this.btnConstituerEquipe.Text = "Constituer Equipe";
            this.btnConstituerEquipe.UseVisualStyleBackColor = true;
            this.btnConstituerEquipe.Click += new System.EventHandler(this.btnConstituerEquipe_Click_1);
            // 
            // cbCaserneImmobiliser
            // 
            this.cbCaserneImmobiliser.FormattingEnabled = true;
            this.cbCaserneImmobiliser.Location = new System.Drawing.Point(267, 196);
            this.cbCaserneImmobiliser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCaserneImmobiliser.Name = "cbCaserneImmobiliser";
            this.cbCaserneImmobiliser.Size = new System.Drawing.Size(473, 37);
            this.cbCaserneImmobiliser.TabIndex = 19;
            this.cbCaserneImmobiliser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCaserneImmobiliser_KeyPress_1);
            // 
            // gbDecisionRegulateur
            // 
            this.gbDecisionRegulateur.Controls.Add(this.btnConstituerEquipe);
            this.gbDecisionRegulateur.Controls.Add(this.cbCaserneImmobiliser);
            this.gbDecisionRegulateur.Controls.Add(this.cbNatureSinistre);
            this.gbDecisionRegulateur.Controls.Add(this.label1);
            this.gbDecisionRegulateur.Controls.Add(this.label2);
            this.gbDecisionRegulateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDecisionRegulateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDecisionRegulateur.Location = new System.Drawing.Point(803, 65);
            this.gbDecisionRegulateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDecisionRegulateur.Name = "gbDecisionRegulateur";
            this.gbDecisionRegulateur.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDecisionRegulateur.Size = new System.Drawing.Size(784, 392);
            this.gbDecisionRegulateur.TabIndex = 28;
            this.gbDecisionRegulateur.TabStop = false;
            this.gbDecisionRegulateur.Text = "Décision du regulateur";
            // 
            // gbInformationsUsager
            // 
            this.gbInformationsUsager.Controls.Add(this.txtMotif);
            this.gbInformationsUsager.Controls.Add(this.txtVille);
            this.gbInformationsUsager.Controls.Add(this.txtCodePostale);
            this.gbInformationsUsager.Controls.Add(this.txtRue);
            this.gbInformationsUsager.Controls.Add(this.lblVille);
            this.gbInformationsUsager.Controls.Add(this.lblRue);
            this.gbInformationsUsager.Controls.Add(this.lblCodePostale);
            this.gbInformationsUsager.Controls.Add(this.lblAdresseSinistre);
            this.gbInformationsUsager.Controls.Add(this.lblMotif);
            this.gbInformationsUsager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformationsUsager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbInformationsUsager.Location = new System.Drawing.Point(98, 65);
            this.gbInformationsUsager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformationsUsager.Name = "gbInformationsUsager";
            this.gbInformationsUsager.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInformationsUsager.Size = new System.Drawing.Size(670, 392);
            this.gbInformationsUsager.TabIndex = 27;
            this.gbInformationsUsager.TabStop = false;
            this.gbInformationsUsager.Text = "Informations Usager";
            // 
            // lblDateDeclanchee
            // 
            this.lblDateDeclanchee.AutoSize = true;
            this.lblDateDeclanchee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDeclanchee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDateDeclanchee.Location = new System.Drawing.Point(937, 21);
            this.lblDateDeclanchee.Name = "lblDateDeclanchee";
            this.lblDateDeclanchee.Size = new System.Drawing.Size(103, 38);
            this.lblDateDeclanchee.TabIndex = 26;
            this.lblDateDeclanchee.Text = "label4";
            this.lblDateDeclanchee.Click += new System.EventHandler(this.lblDateDeclanchee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(681, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 38);
            this.label3.TabIndex = 25;
            this.label3.Text = "Déclenchée le : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Location = new System.Drawing.Point(356, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(103, 38);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "label2";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // lblIdMission
            // 
            this.lblIdMission.AutoSize = true;
            this.lblIdMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdMission.Location = new System.Drawing.Point(173, 21);
            this.lblIdMission.Name = "lblIdMission";
            this.lblIdMission.Size = new System.Drawing.Size(182, 38);
            this.lblIdMission.TabIndex = 23;
            this.lblIdMission.Text = "Mission n : ";
            // 
            // UC_CreerMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.flpEngins);
            this.Controls.Add(this.flpPompiers);
            this.Controls.Add(this.gbMobilisation);
            this.Controls.Add(this.btnMAJ);
            this.Controls.Add(this.gbDecisionRegulateur);
            this.Controls.Add(this.gbInformationsUsager);
            this.Controls.Add(this.lblDateDeclanchee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIdMission);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_CreerMission";
            this.Size = new System.Drawing.Size(1609, 1045);
            this.Load += new System.EventHandler(this.UCCreerMission_Load);
            this.gbMobilisation.ResumeLayout(false);
            this.gbMobilisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).EndInit();
            this.gbDecisionRegulateur.ResumeLayout(false);
            this.gbDecisionRegulateur.PerformLayout();
            this.gbInformationsUsager.ResumeLayout(false);
            this.gbInformationsUsager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNatureSinistre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMobilisation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPompiers;
        private System.Windows.Forms.DataGridView dgvEngins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePostale;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.Label lblAdresseSinistre;
        private System.Windows.Forms.Button btnMAJ;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Button btnConstituerEquipe;
        private System.Windows.Forms.ComboBox cbCaserneImmobiliser;
        private System.Windows.Forms.GroupBox gbDecisionRegulateur;
        private System.Windows.Forms.GroupBox gbInformationsUsager;
        private System.Windows.Forms.Label lblDateDeclanchee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdMission;
        private System.Windows.Forms.FlowLayoutPanel flpPompiers;
        private System.Windows.Forms.FlowLayoutPanel flpEngins;
    }
}
