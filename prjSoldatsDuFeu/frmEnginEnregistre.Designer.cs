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
            this.btnDernier.Location = new System.Drawing.Point(512, 66);
            this.btnDernier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(112, 35);
            this.btnDernier.TabIndex = 11;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(390, 66);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(112, 35);
            this.btnSuivant.TabIndex = 10;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(268, 66);
            this.btnPrecedent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(112, 35);
            this.btnPrecedent.TabIndex = 9;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(147, 66);
            this.btnPremier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(112, 35);
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
            this.grbAffichage.Location = new System.Drawing.Point(18, 140);
            this.grbAffichage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAffichage.Name = "grbAffichage";
            this.grbAffichage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAffichage.Size = new System.Drawing.Size(778, 378);
            this.grbAffichage.TabIndex = 7;
            this.grbAffichage.TabStop = false;
            // 
            // ckbEnPanne
            // 
            this.ckbEnPanne.AutoSize = true;
            this.ckbEnPanne.Enabled = false;
            this.ckbEnPanne.Location = new System.Drawing.Point(184, 158);
            this.ckbEnPanne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbEnPanne.Name = "ckbEnPanne";
            this.ckbEnPanne.Size = new System.Drawing.Size(22, 21);
            this.ckbEnPanne.TabIndex = 8;
            this.ckbEnPanne.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "En panne";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "En mission";
            // 
            // ckbEnMission
            // 
            this.ckbEnMission.AutoSize = true;
            this.ckbEnMission.Enabled = false;
            this.ckbEnMission.Location = new System.Drawing.Point(184, 117);
            this.ckbEnMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbEnMission.Name = "ckbEnMission";
            this.ckbEnMission.Size = new System.Drawing.Size(22, 21);
            this.ckbEnMission.TabIndex = 7;
            this.ckbEnMission.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de réception";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro";
            // 
            // lblDateReception
            // 
            this.lblDateReception.AutoSize = true;
            this.lblDateReception.Location = new System.Drawing.Point(180, 77);
            this.lblDateReception.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateReception.Name = "lblDateReception";
            this.lblDateReception.Size = new System.Drawing.Size(44, 20);
            this.lblDateReception.TabIndex = 6;
            this.lblDateReception.Text = "Date";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(180, 40);
            this.lblMatricule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(73, 20);
            this.lblMatricule.TabIndex = 5;
            this.lblMatricule.Text = "Matricule";
            // 
            // grbChoixCaserne
            // 
            this.grbChoixCaserne.Controls.Add(this.cbxCaserne);
            this.grbChoixCaserne.Controls.Add(this.label1);
            this.grbChoixCaserne.Location = new System.Drawing.Point(18, 18);
            this.grbChoixCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbChoixCaserne.Name = "grbChoixCaserne";
            this.grbChoixCaserne.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbChoixCaserne.Size = new System.Drawing.Size(778, 85);
            this.grbChoixCaserne.TabIndex = 6;
            this.grbChoixCaserne.TabStop = false;
            // 
            // cbxCaserne
            // 
            this.cbxCaserne.FormattingEnabled = true;
            this.cbxCaserne.Location = new System.Drawing.Point(213, 29);
            this.cbxCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCaserne.Name = "cbxCaserne";
            this.cbxCaserne.Size = new System.Drawing.Size(180, 28);
            this.cbxCaserne.TabIndex = 1;
            this.cbxCaserne.SelectionChangeCommitted += new System.EventHandler(this.cbxCaserne_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choix de la caserne";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(375, 25);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(18, 20);
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
            this.grbControle.Location = new System.Drawing.Point(18, 548);
            this.grbControle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbControle.Name = "grbControle";
            this.grbControle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbControle.Size = new System.Drawing.Size(778, 142);
            this.grbControle.TabIndex = 15;
            this.grbControle.TabStop = false;
            // 
            // frmEnginEnregistre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 737);
            this.Controls.Add(this.grbControle);
            this.Controls.Add(this.grbAffichage);
            this.Controls.Add(this.grbChoixCaserne);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEnginEnregistre";
            this.Text = "frmEnginEnregistre";
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