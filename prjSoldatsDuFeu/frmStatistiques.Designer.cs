namespace prjSoldatsDuFeu
{
    partial class frmStatistiques
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStatistiqueCaserne = new System.Windows.Forms.Label();
            this.lblStatistiquesGlobales = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboRequeteParCaserne = new System.Windows.Forms.ComboBox();
            this.cboStatistiquesGlobales = new System.Windows.Forms.ComboBox();
            this.cboTypeSinistre = new System.Windows.Forms.ComboBox();
            this.cboHabilitation = new System.Windows.Forms.ComboBox();
            this.pnlGlobal = new System.Windows.Forms.Panel();
            this.pnlCaserne = new System.Windows.Forms.Panel();
            this.lblTypeSinistre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatistiqueCaserne
            // 
            this.lblStatistiqueCaserne.AutoSize = true;
            this.lblStatistiqueCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistiqueCaserne.Location = new System.Drawing.Point(13, 9);
            this.lblStatistiqueCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatistiqueCaserne.Name = "lblStatistiqueCaserne";
            this.lblStatistiqueCaserne.Size = new System.Drawing.Size(266, 29);
            this.lblStatistiqueCaserne.TabIndex = 0;
            this.lblStatistiqueCaserne.Text = "Statistiques la caserne :";
            // 
            // lblStatistiquesGlobales
            // 
            this.lblStatistiquesGlobales.AutoSize = true;
            this.lblStatistiquesGlobales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistiquesGlobales.Location = new System.Drawing.Point(37, 87);
            this.lblStatistiquesGlobales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatistiquesGlobales.Name = "lblStatistiquesGlobales";
            this.lblStatistiquesGlobales.Size = new System.Drawing.Size(242, 29);
            this.lblStatistiquesGlobales.TabIndex = 1;
            this.lblStatistiquesGlobales.Text = "Statisques globales : ";
            this.lblStatistiquesGlobales.Visible = false;
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(287, 10);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(271, 28);
            this.cboCaserne.TabIndex = 3;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // cboRequeteParCaserne
            // 
            this.cboRequeteParCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequeteParCaserne.FormattingEnabled = true;
            this.cboRequeteParCaserne.Location = new System.Drawing.Point(287, 48);
            this.cboRequeteParCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboRequeteParCaserne.Name = "cboRequeteParCaserne";
            this.cboRequeteParCaserne.Size = new System.Drawing.Size(271, 28);
            this.cboRequeteParCaserne.TabIndex = 5;
            this.cboRequeteParCaserne.Visible = false;
            this.cboRequeteParCaserne.SelectedIndexChanged += new System.EventHandler(this.cboRequeteParCaserne_SelectedIndexChanged);
            // 
            // cboStatistiquesGlobales
            // 
            this.cboStatistiquesGlobales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatistiquesGlobales.FormattingEnabled = true;
            this.cboStatistiquesGlobales.Location = new System.Drawing.Point(287, 88);
            this.cboStatistiquesGlobales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStatistiquesGlobales.Name = "cboStatistiquesGlobales";
            this.cboStatistiquesGlobales.Size = new System.Drawing.Size(271, 28);
            this.cboStatistiquesGlobales.TabIndex = 6;
            this.cboStatistiquesGlobales.Visible = false;
            this.cboStatistiquesGlobales.SelectedIndexChanged += new System.EventHandler(this.cboStatGlobal_SelectedIndexChanged);
            // 
            // cboTypeSinistre
            // 
            this.cboTypeSinistre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeSinistre.FormattingEnabled = true;
            this.cboTypeSinistre.Location = new System.Drawing.Point(768, 11);
            this.cboTypeSinistre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTypeSinistre.Name = "cboTypeSinistre";
            this.cboTypeSinistre.Size = new System.Drawing.Size(180, 28);
            this.cboTypeSinistre.TabIndex = 7;
            this.cboTypeSinistre.Visible = false;
            this.cboTypeSinistre.SelectedIndexChanged += new System.EventHandler(this.cboTypeSinistre_SelectedIndexChanged);
            // 
            // cboHabilitation
            // 
            this.cboHabilitation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHabilitation.FormattingEnabled = true;
            this.cboHabilitation.Location = new System.Drawing.Point(830, 88);
            this.cboHabilitation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboHabilitation.Name = "cboHabilitation";
            this.cboHabilitation.Size = new System.Drawing.Size(180, 28);
            this.cboHabilitation.TabIndex = 8;
            this.cboHabilitation.Visible = false;
            this.cboHabilitation.SelectedIndexChanged += new System.EventHandler(this.cboHabilitation_SelectedIndexChanged);
            // 
            // pnlGlobal
            // 
            this.pnlGlobal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlGlobal.Location = new System.Drawing.Point(679, 162);
            this.pnlGlobal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGlobal.Name = "pnlGlobal";
            this.pnlGlobal.Size = new System.Drawing.Size(658, 411);
            this.pnlGlobal.TabIndex = 9;
            this.pnlGlobal.Visible = false;
            // 
            // pnlCaserne
            // 
            this.pnlCaserne.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlCaserne.Location = new System.Drawing.Point(13, 162);
            this.pnlCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCaserne.Name = "pnlCaserne";
            this.pnlCaserne.Size = new System.Drawing.Size(658, 411);
            this.pnlCaserne.TabIndex = 10;
            this.pnlCaserne.Visible = false;
            // 
            // lblTypeSinistre
            // 
            this.lblTypeSinistre.AutoSize = true;
            this.lblTypeSinistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeSinistre.Location = new System.Drawing.Point(566, 10);
            this.lblTypeSinistre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeSinistre.Name = "lblTypeSinistre";
            this.lblTypeSinistre.Size = new System.Drawing.Size(203, 29);
            this.lblTypeSinistre.TabIndex = 11;
            this.lblTypeSinistre.Text = "Type de sinistre : ";
            this.lblTypeSinistre.Visible = false;
            // 
            // frmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1887, 692);
            this.Controls.Add(this.lblTypeSinistre);
            this.Controls.Add(this.pnlCaserne);
            this.Controls.Add(this.pnlGlobal);
            this.Controls.Add(this.cboHabilitation);
            this.Controls.Add(this.cboTypeSinistre);
            this.Controls.Add(this.cboStatistiquesGlobales);
            this.Controls.Add(this.cboRequeteParCaserne);
            this.Controls.Add(this.cboCaserne);
            this.Controls.Add(this.lblStatistiquesGlobales);
            this.Controls.Add(this.lblStatistiqueCaserne);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStatistiques";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatistiqueCaserne;
        private System.Windows.Forms.Label lblStatistiquesGlobales;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboRequeteParCaserne;
        private System.Windows.Forms.ComboBox cboStatistiquesGlobales;
        private System.Windows.Forms.ComboBox cboTypeSinistre;
        private System.Windows.Forms.ComboBox cboHabilitation;
        private System.Windows.Forms.Panel pnlGlobal;
        private System.Windows.Forms.Panel pnlCaserne;
        private System.Windows.Forms.Label lblTypeSinistre;
    }
}

