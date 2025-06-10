namespace prjSoldatsDuFeu
{
    partial class frmGestionPompiers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxChoixCaserne = new System.Windows.Forms.ComboBox();
            this.cbxChoixPompier = new System.Windows.Forms.ComboBox();
            this.btnNouveauPompier = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.rdbProfessionel = new System.Windows.Forms.RadioButton();
            this.lblEmbauche = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.gpbCarriere = new System.Windows.Forms.GroupBox();
            this.chkEnConge = new System.Windows.Forms.CheckBox();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtAffectation = new System.Windows.Forms.TextBox();
            this.txtCodeGrade = new System.Windows.Forms.TextBox();
            this.txtHabilitation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGrade = new System.Windows.Forms.ComboBox();
            this.gpbInfoCarriere = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMettreAJour = new System.Windows.Forms.Button();
            this.chkEnCongeMAJ = new System.Windows.Forms.CheckBox();
            this.cbxCaserneRattachement = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FormulaireConnexion = new prjSoldatsDuFeu.loginForm();
            this.grpInfo.SuspendLayout();
            this.gpbCarriere.SuspendLayout();
            this.gpbInfoCarriere.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selection d\'une caserne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selection d\'un pompier";
            // 
            // cbxChoixCaserne
            // 
            this.cbxChoixCaserne.FormattingEnabled = true;
            this.cbxChoixCaserne.Location = new System.Drawing.Point(24, 49);
            this.cbxChoixCaserne.Name = "cbxChoixCaserne";
            this.cbxChoixCaserne.Size = new System.Drawing.Size(121, 21);
            this.cbxChoixCaserne.TabIndex = 2;
            this.cbxChoixCaserne.SelectionChangeCommitted += new System.EventHandler(this.cbxChoixCaserne_SelectionChangeCommitted);
            // 
            // cbxChoixPompier
            // 
            this.cbxChoixPompier.FormattingEnabled = true;
            this.cbxChoixPompier.Location = new System.Drawing.Point(24, 113);
            this.cbxChoixPompier.Name = "cbxChoixPompier";
            this.cbxChoixPompier.Size = new System.Drawing.Size(121, 21);
            this.cbxChoixPompier.TabIndex = 3;
            this.cbxChoixPompier.SelectionChangeCommitted += new System.EventHandler(this.cbxChoixPompier_SelectionChangeCommitted);
            // 
            // btnNouveauPompier
            // 
            this.btnNouveauPompier.Location = new System.Drawing.Point(24, 168);
            this.btnNouveauPompier.Name = "btnNouveauPompier";
            this.btnNouveauPompier.Size = new System.Drawing.Size(121, 23);
            this.btnNouveauPompier.TabIndex = 4;
            this.btnNouveauPompier.Text = "Nouveau pompier";
            this.btnNouveauPompier.UseVisualStyleBackColor = true;
            this.btnNouveauPompier.Visible = false;
            this.btnNouveauPompier.Click += new System.EventHandler(this.btnNouveauPompier_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.rdbVolontaire);
            this.grpInfo.Controls.Add(this.rdbProfessionel);
            this.grpInfo.Controls.Add(this.lblEmbauche);
            this.grpInfo.Controls.Add(this.lblNaissance);
            this.grpInfo.Controls.Add(this.lblSexe);
            this.grpInfo.Controls.Add(this.lblPrenom);
            this.grpInfo.Controls.Add(this.lblNom);
            this.grpInfo.Controls.Add(this.lblMatricule);
            this.grpInfo.Controls.Add(this.gpbCarriere);
            this.grpInfo.Location = new System.Drawing.Point(194, 13);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(627, 596);
            this.grpInfo.TabIndex = 5;
            this.grpInfo.TabStop = false;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Enabled = false;
            this.rdbVolontaire.Location = new System.Drawing.Point(253, 176);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(72, 17);
            this.rdbVolontaire.TabIndex = 14;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // rdbProfessionel
            // 
            this.rdbProfessionel.AutoSize = true;
            this.rdbProfessionel.Enabled = false;
            this.rdbProfessionel.Location = new System.Drawing.Point(31, 176);
            this.rdbProfessionel.Name = "rdbProfessionel";
            this.rdbProfessionel.Size = new System.Drawing.Size(88, 17);
            this.rdbProfessionel.TabIndex = 13;
            this.rdbProfessionel.TabStop = true;
            this.rdbProfessionel.Text = "Professionnel";
            this.rdbProfessionel.UseVisualStyleBackColor = true;
            // 
            // lblEmbauche
            // 
            this.lblEmbauche.AutoSize = true;
            this.lblEmbauche.Location = new System.Drawing.Point(28, 221);
            this.lblEmbauche.Name = "lblEmbauche";
            this.lblEmbauche.Size = new System.Drawing.Size(89, 13);
            this.lblEmbauche.TabIndex = 12;
            this.lblEmbauche.Text = "Date embauche :";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.Location = new System.Drawing.Point(28, 146);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(102, 13);
            this.lblNaissance.TabIndex = 11;
            this.lblNaissance.Text = "Date de naissance :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(28, 117);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(37, 13);
            this.lblSexe.TabIndex = 10;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(28, 82);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(52, 13);
            this.lblPrenom.TabIndex = 9;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(28, 54);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom :";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(30, 25);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(53, 13);
            this.lblMatricule.TabIndex = 7;
            this.lblMatricule.Text = "Matricule ";
            // 
            // gpbCarriere
            // 
            this.gpbCarriere.Controls.Add(this.chkEnConge);
            this.gpbCarriere.Controls.Add(this.lblBip);
            this.gpbCarriere.Controls.Add(this.lblTelephone);
            this.gpbCarriere.Controls.Add(this.txtAffectation);
            this.gpbCarriere.Controls.Add(this.txtCodeGrade);
            this.gpbCarriere.Controls.Add(this.txtHabilitation);
            this.gpbCarriere.Controls.Add(this.label6);
            this.gpbCarriere.Controls.Add(this.label5);
            this.gpbCarriere.Controls.Add(this.label3);
            this.gpbCarriere.Location = new System.Drawing.Point(6, 257);
            this.gpbCarriere.Name = "gpbCarriere";
            this.gpbCarriere.Size = new System.Drawing.Size(615, 333);
            this.gpbCarriere.TabIndex = 0;
            this.gpbCarriere.TabStop = false;
            this.gpbCarriere.Text = "Carrière";
            // 
            // chkEnConge
            // 
            this.chkEnConge.AutoSize = true;
            this.chkEnConge.Enabled = false;
            this.chkEnConge.Location = new System.Drawing.Point(370, 37);
            this.chkEnConge.Name = "chkEnConge";
            this.chkEnConge.Size = new System.Drawing.Size(72, 17);
            this.chkEnConge.TabIndex = 24;
            this.chkEnConge.Text = "En congé";
            this.chkEnConge.UseVisualStyleBackColor = true;
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Location = new System.Drawing.Point(244, 85);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(31, 13);
            this.lblBip.TabIndex = 18;
            this.lblBip.Text = "Bip : ";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(22, 85);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(67, 13);
            this.lblTelephone.TabIndex = 17;
            this.lblTelephone.Text = "Téléphone : ";
            // 
            // txtAffectation
            // 
            this.txtAffectation.Enabled = false;
            this.txtAffectation.Location = new System.Drawing.Point(27, 240);
            this.txtAffectation.Multiline = true;
            this.txtAffectation.Name = "txtAffectation";
            this.txtAffectation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAffectation.Size = new System.Drawing.Size(519, 62);
            this.txtAffectation.TabIndex = 22;
            // 
            // txtCodeGrade
            // 
            this.txtCodeGrade.Enabled = false;
            this.txtCodeGrade.Location = new System.Drawing.Point(121, 41);
            this.txtCodeGrade.Name = "txtCodeGrade";
            this.txtCodeGrade.Size = new System.Drawing.Size(100, 20);
            this.txtCodeGrade.TabIndex = 16;
            // 
            // txtHabilitation
            // 
            this.txtHabilitation.Enabled = false;
            this.txtHabilitation.Location = new System.Drawing.Point(27, 159);
            this.txtHabilitation.Multiline = true;
            this.txtHabilitation.Name = "txtHabilitation";
            this.txtHabilitation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHabilitation.Size = new System.Drawing.Size(519, 62);
            this.txtHabilitation.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Affectations passées ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Habilitations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Grade :";
            // 
            // cbxGrade
            // 
            this.cbxGrade.FormattingEnabled = true;
            this.cbxGrade.Location = new System.Drawing.Point(162, 60);
            this.cbxGrade.Name = "cbxGrade";
            this.cbxGrade.Size = new System.Drawing.Size(121, 21);
            this.cbxGrade.TabIndex = 7;
            // 
            // gpbInfoCarriere
            // 
            this.gpbInfoCarriere.Controls.Add(this.label7);
            this.gpbInfoCarriere.Controls.Add(this.btnMettreAJour);
            this.gpbInfoCarriere.Controls.Add(this.chkEnCongeMAJ);
            this.gpbInfoCarriere.Controls.Add(this.cbxCaserneRattachement);
            this.gpbInfoCarriere.Controls.Add(this.label4);
            this.gpbInfoCarriere.Controls.Add(this.cbxGrade);
            this.gpbInfoCarriere.Location = new System.Drawing.Point(194, 615);
            this.gpbInfoCarriere.Name = "gpbInfoCarriere";
            this.gpbInfoCarriere.Size = new System.Drawing.Size(627, 109);
            this.gpbInfoCarriere.TabIndex = 6;
            this.gpbInfoCarriere.TabStop = false;
            this.gpbInfoCarriere.Text = "Mise à jour des informations de carrière";
            this.gpbInfoCarriere.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Changer de grade :";
            // 
            // btnMettreAJour
            // 
            this.btnMettreAJour.Location = new System.Drawing.Point(469, 21);
            this.btnMettreAJour.Name = "btnMettreAJour";
            this.btnMettreAJour.Size = new System.Drawing.Size(121, 23);
            this.btnMettreAJour.TabIndex = 7;
            this.btnMettreAJour.Text = "Mettre à jour";
            this.btnMettreAJour.UseVisualStyleBackColor = true;
            this.btnMettreAJour.Click += new System.EventHandler(this.btnMettreAJour_Click);
            // 
            // chkEnCongeMAJ
            // 
            this.chkEnCongeMAJ.AutoSize = true;
            this.chkEnCongeMAJ.Location = new System.Drawing.Point(317, 27);
            this.chkEnCongeMAJ.Name = "chkEnCongeMAJ";
            this.chkEnCongeMAJ.Size = new System.Drawing.Size(72, 17);
            this.chkEnCongeMAJ.TabIndex = 23;
            this.chkEnCongeMAJ.Text = "En congé";
            this.chkEnCongeMAJ.UseVisualStyleBackColor = true;
            // 
            // cbxCaserneRattachement
            // 
            this.cbxCaserneRattachement.FormattingEnabled = true;
            this.cbxCaserneRattachement.Location = new System.Drawing.Point(162, 23);
            this.cbxCaserneRattachement.Name = "cbxCaserneRattachement";
            this.cbxCaserneRattachement.Size = new System.Drawing.Size(121, 21);
            this.cbxCaserneRattachement.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Changer de caserne :";
            // 
            // FormulaireConnexion
            // 
            this.FormulaireConnexion.Location = new System.Drawing.Point(12, 270);
            this.FormulaireConnexion.Login = "";
            this.FormulaireConnexion.Name = "FormulaireConnexion";
            this.FormulaireConnexion.Password = "";
            this.FormulaireConnexion.Size = new System.Drawing.Size(176, 137);
            this.FormulaireConnexion.TabIndex = 11;
            // 
            // frmGestionPompiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.FormulaireConnexion);
            this.Controls.Add(this.gpbInfoCarriere);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnNouveauPompier);
            this.Controls.Add(this.cbxChoixPompier);
            this.Controls.Add(this.cbxChoixCaserne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionPompiers";
            this.Text = "Gestion des pompiers";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.gpbCarriere.ResumeLayout(false);
            this.gpbCarriere.PerformLayout();
            this.gpbInfoCarriere.ResumeLayout(false);
            this.gpbInfoCarriere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxChoixCaserne;
        private System.Windows.Forms.ComboBox cbxChoixPompier;
        private System.Windows.Forms.Button btnNouveauPompier;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblEmbauche;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.GroupBox gpbCarriere;
        private System.Windows.Forms.GroupBox gpbInfoCarriere;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbProfessionel;
        private System.Windows.Forms.ComboBox cbxGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtCodeGrade;
        private System.Windows.Forms.Button btnMettreAJour;
        private System.Windows.Forms.CheckBox chkEnCongeMAJ;
        private System.Windows.Forms.TextBox txtAffectation;
        private System.Windows.Forms.TextBox txtHabilitation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCaserneRattachement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkEnConge;
        private loginForm FormulaireConnexion;
    }
}