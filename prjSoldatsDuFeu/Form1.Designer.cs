namespace prjSoldatsDuFeu
{
    partial class frmTableauDeBord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableauDeBord));
            this.pnlBoutonsNavigation = new System.Windows.Forms.Panel();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGestionEngins = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.pnlTableauDeBord = new System.Windows.Forms.Panel();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.flpnlTDB = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlBoutonsNavigation.SuspendLayout();
            this.pnlTableauDeBord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoutonsNavigation
            // 
            this.pnlBoutonsNavigation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlBoutonsNavigation.Controls.Add(this.btnStatistiques);
            this.pnlBoutonsNavigation.Controls.Add(this.btnQuitter);
            this.pnlBoutonsNavigation.Controls.Add(this.button3);
            this.pnlBoutonsNavigation.Controls.Add(this.btnGestionEngins);
            this.pnlBoutonsNavigation.Controls.Add(this.button1);
            this.pnlBoutonsNavigation.Controls.Add(this.btnTableauDeBord);
            this.pnlBoutonsNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBoutonsNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlBoutonsNavigation.Name = "pnlBoutonsNavigation";
            this.pnlBoutonsNavigation.Size = new System.Drawing.Size(69, 692);
            this.pnlBoutonsNavigation.TabIndex = 7;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistiques.BackgroundImage")));
            this.btnStatistiques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiques.Location = new System.Drawing.Point(4, 267);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(60, 60);
            this.btnStatistiques.TabIndex = 14;
            this.btnStatistiques.UseVisualStyleBackColor = true;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitter.BackgroundImage")));
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Location = new System.Drawing.Point(4, 629);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(60, 60);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(4, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnGestionEngins
            // 
            this.btnGestionEngins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGestionEngins.BackgroundImage")));
            this.btnGestionEngins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGestionEngins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionEngins.Location = new System.Drawing.Point(4, 135);
            this.btnGestionEngins.Name = "btnGestionEngins";
            this.btnGestionEngins.Size = new System.Drawing.Size(60, 60);
            this.btnGestionEngins.TabIndex = 11;
            this.btnGestionEngins.UseVisualStyleBackColor = true;
            this.btnGestionEngins.Click += new System.EventHandler(this.btnGestionEngins_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(4, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTableauDeBord.BackgroundImage")));
            this.btnTableauDeBord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTableauDeBord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableauDeBord.Location = new System.Drawing.Point(4, 3);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(60, 60);
            this.btnTableauDeBord.TabIndex = 9;
            this.btnTableauDeBord.UseVisualStyleBackColor = true;
            // 
            // pnlTableauDeBord
            // 
            this.pnlTableauDeBord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTableauDeBord.Controls.Add(this.chkEnCours);
            this.pnlTableauDeBord.Controls.Add(this.flpnlTDB);
            this.pnlTableauDeBord.Controls.Add(this.lblTitre);
            this.pnlTableauDeBord.Location = new System.Drawing.Point(75, 12);
            this.pnlTableauDeBord.Name = "pnlTableauDeBord";
            this.pnlTableauDeBord.Size = new System.Drawing.Size(1113, 668);
            this.pnlTableauDeBord.TabIndex = 8;
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Location = new System.Drawing.Point(42, 18);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(91, 24);
            this.chkEnCours.TabIndex = 2;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // flpnlTDB
            // 
            this.flpnlTDB.AutoScroll = true;
            this.flpnlTDB.Location = new System.Drawing.Point(3, 48);
            this.flpnlTDB.Name = "flpnlTDB";
            this.flpnlTDB.Size = new System.Drawing.Size(1107, 617);
            this.flpnlTDB.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(470, 11);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(192, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Tableau de bord";
            // 
            // frmTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlTableauDeBord);
            this.Controls.Add(this.pnlBoutonsNavigation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmTableauDeBord";
            this.Text = "Soldats du feu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmTableauDeBord_Resize);
            this.pnlBoutonsNavigation.ResumeLayout(false);
            this.pnlTableauDeBord.ResumeLayout(false);
            this.pnlTableauDeBord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBoutonsNavigation;
        private System.Windows.Forms.Panel pnlTableauDeBord;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.FlowLayoutPanel flpnlTDB;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGestionEngins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnStatistiques;
    }
}

