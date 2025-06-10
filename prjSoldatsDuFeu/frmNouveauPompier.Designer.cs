namespace prjSoldatsDuFeu
{
    partial class frmNouveauPompier
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
            this.Matricule = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cbxSexe = new System.Windows.Forms.ComboBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxGrade = new System.Windows.Forms.ComboBox();
            this.txtBip = new System.Windows.Forms.TextBox();
            this.dtpDateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnValide = new System.Windows.Forms.Button();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Matricule
            // 
            this.Matricule.AutoSize = true;
            this.Matricule.Location = new System.Drawing.Point(60, 46);
            this.Matricule.Name = "Matricule";
            this.Matricule.Size = new System.Drawing.Size(50, 13);
            this.Matricule.TabIndex = 0;
            this.Matricule.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sexe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bip";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(208, 38);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(100, 20);
            this.txtMatricule.TabIndex = 8;
            this.txtMatricule.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricule_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(208, 75);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 9;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(208, 108);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 10;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenom_KeyPress);
            // 
            // cbxSexe
            // 
            this.cbxSexe.FormattingEnabled = true;
            this.cbxSexe.Location = new System.Drawing.Point(208, 137);
            this.cbxSexe.Name = "cbxSexe";
            this.cbxSexe.Size = new System.Drawing.Size(121, 21);
            this.cbxSexe.TabIndex = 11;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(208, 206);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(200, 20);
            this.dtpDateNaissance.TabIndex = 12;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(208, 280);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 13;
            // 
            // cbxGrade
            // 
            this.cbxGrade.FormattingEnabled = true;
            this.cbxGrade.Location = new System.Drawing.Point(208, 326);
            this.cbxGrade.Name = "cbxGrade";
            this.cbxGrade.Size = new System.Drawing.Size(121, 21);
            this.cbxGrade.TabIndex = 14;
            // 
            // txtBip
            // 
            this.txtBip.Location = new System.Drawing.Point(208, 367);
            this.txtBip.Name = "txtBip";
            this.txtBip.Size = new System.Drawing.Size(100, 20);
            this.txtBip.TabIndex = 15;
            this.txtBip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBip_KeyPress);
            // 
            // dtpDateEmbauche
            // 
            this.dtpDateEmbauche.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dtpDateEmbauche.Location = new System.Drawing.Point(210, 243);
            this.dtpDateEmbauche.Name = "dtpDateEmbauche";
            this.dtpDateEmbauche.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEmbauche.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date de embauche";
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(65, 397);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(75, 23);
            this.btnValide.TabIndex = 18;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(208, 171);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 20;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephone_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Telephone";
            // 
            // frmNouveauPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.dtpDateEmbauche);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBip);
            this.Controls.Add(this.cbxGrade);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.cbxSexe);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Matricule);
            this.Name = "frmNouveauPompier";
            this.Text = "Nouveau pompier";
            this.Load += new System.EventHandler(this.NouveauPomp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Matricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cbxSexe;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxGrade;
        private System.Windows.Forms.TextBox txtBip;
        private System.Windows.Forms.DateTimePicker dtpDateEmbauche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label9;
    }
}