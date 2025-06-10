namespace prjSoldatsDuFeu
{
    partial class frmEnginEnregistre
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
            this.components = new System.ComponentModel.Container();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.grbAffichage = new System.Windows.Forms.GroupBox();
            this.ckbEnPanne = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbEnMission = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateReception = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.grbChoixCaserne = new System.Windows.Forms.GroupBox();
            this.cbxCaserne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grbControle = new System.Windows.Forms.GroupBox();
            this.grbAffichage.SuspendLayout();
            this.grbChoixCaserne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grbControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(341, 43);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(75, 23);
            this.btnDernier.TabIndex = 11;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(260, 43);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 10;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(179, 43);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 9;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(98, 43);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(75, 23);
            this.btnPremier.TabIndex = 8;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // grbAffichage
            // 
            this.grbAffichage.Controls.Add(this.ckbEnPanne);
            this.grbAffichage.Controls.Add(this.label5);
            this.grbAffichage.Controls.Add(this.label4);
            this.grbAffichage.Controls.Add(this.ckbEnMission);
            this.grbAffichage.Controls.Add(this.label3);
            this.grbAffichage.Controls.Add(this.label2);
            this.grbAffichage.Controls.Add(this.lblDateReception);
            this.grbAffichage.Controls.Add(this.lblMatricule);
            this.grbAffichage.Location = new System.Drawing.Point(12, 91);
            this.grbAffichage.Name = "grbAffichage";
            this.grbAffichage.Size = new System.Drawing.Size(519, 246);
            this.grbAffichage.TabIndex = 7;
            this.grbAffichage.TabStop = false;
            // 
            // ckbEnPanne
            // 
            this.ckbEnPanne.AutoSize = true;
            this.ckbEnPanne.Enabled = false;
            this.ckbEnPanne.Location = new System.Drawing.Point(123, 103);
            this.ckbEnPanne.Name = "ckbEnPanne";
            this.ckbEnPanne.Size = new System.Drawing.Size(15, 14);
            this.ckbEnPanne.TabIndex = 8;
            this.ckbEnPanne.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "En panne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "En mission";
            // 
            // ckbEnMission
            // 
            this.ckbEnMission.AutoSize = true;
            this.ckbEnMission.Enabled = false;
            this.ckbEnMission.Location = new System.Drawing.Point(123, 76);
            this.ckbEnMission.Name = "ckbEnMission";
            this.ckbEnMission.Size = new System.Drawing.Size(15, 14);
            this.ckbEnMission.TabIndex = 7;
            this.ckbEnMission.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de réception";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro";
            // 
            // lblDateReception
            // 
            this.lblDateReception.AutoSize = true;
            this.lblDateReception.Location = new System.Drawing.Point(120, 50);
            this.lblDateReception.Name = "lblDateReception";
            this.lblDateReception.Size = new System.Drawing.Size(30, 13);
            this.lblDateReception.TabIndex = 6;
            this.lblDateReception.Text = "Date";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(120, 26);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(50, 13);
            this.lblMatricule.TabIndex = 5;
            this.lblMatricule.Text = "Matricule";
            // 
            // grbChoixCaserne
            // 
            this.grbChoixCaserne.Controls.Add(this.cbxCaserne);
            this.grbChoixCaserne.Controls.Add(this.label1);
            this.grbChoixCaserne.Location = new System.Drawing.Point(12, 12);
            this.grbChoixCaserne.Name = "grbChoixCaserne";
            this.grbChoixCaserne.Size = new System.Drawing.Size(519, 55);
            this.grbChoixCaserne.TabIndex = 6;
            this.grbChoixCaserne.TabStop = false;
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(142, 19);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(121, 21);
            this.cbxCaserne.TabIndex = 1;
            this.cbxCaserne.SelectionChangeCommitted += new System.EventHandler(this.cbxCaserne_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choix de la caserne";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(250, 16);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(13, 13);
            this.lblIndex.TabIndex = 9;
            this.lblIndex.Text = "0";
            // 
            // grbControle
            // 
            this.grbControle.Controls.Add(this.btnSuivant);
            this.grbControle.Controls.Add(this.btnPremier);
            this.grbControle.Controls.Add(this.lblIndex);
            this.grbControle.Controls.Add(this.btnPrecedent);
            this.grbControle.Controls.Add(this.btnDernier);
            this.grbControle.Location = new System.Drawing.Point(12, 356);
            this.grbControle.Name = "grbControle";
            this.grbControle.Size = new System.Drawing.Size(519, 92);
            this.grbControle.TabIndex = 15;
            this.grbControle.TabStop = false;
            // 
            // frmEnginEnregistre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 479);
            this.Controls.Add(this.grbControle);
            this.Controls.Add(this.grbAffichage);
            this.Controls.Add(this.grbChoixCaserne);
            this.Name = "frmEnginEnregistre";
            this.Text = "Engins enregistrés";
            this.Load += new System.EventHandler(this.frmEnginEnregistre_Load);
            this.grbAffichage.ResumeLayout(false);
            this.grbAffichage.PerformLayout();
            this.grbChoixCaserne.ResumeLayout(false);
            this.grbChoixCaserne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grbControle.ResumeLayout(false);
            this.grbControle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.GroupBox grbAffichage;
        private System.Windows.Forms.CheckBox ckbEnPanne;
        private System.Windows.Forms.CheckBox ckbEnMission;
        private System.Windows.Forms.Label lblDateReception;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbChoixCaserne;
        private System.Windows.Forms.ComboBox cbxCaserne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox grbControle;
    }
}