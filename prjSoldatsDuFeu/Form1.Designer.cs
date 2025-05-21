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
            this.pbTableauDeBord = new System.Windows.Forms.PictureBox();
            this.pnlBoutonsNavigation = new System.Windows.Forms.Panel();
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTableauDeBord = new System.Windows.Forms.Panel();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.flpnlTDB = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTableauDeBord)).BeginInit();
            this.pnlBoutonsNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTableauDeBord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTableauDeBord
            // 
            this.pbTableauDeBord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbTableauDeBord.Image = ((System.Drawing.Image)(resources.GetObject("pbTableauDeBord.Image")));
            this.pbTableauDeBord.Location = new System.Drawing.Point(4, 3);
            this.pbTableauDeBord.Name = "pbTableauDeBord";
            this.pbTableauDeBord.Size = new System.Drawing.Size(60, 60);
            this.pbTableauDeBord.TabIndex = 6;
            this.pbTableauDeBord.TabStop = false;
            this.pbTableauDeBord.Click += new System.EventHandler(this.pbTableauDeBord_Click);
            // 
            // pnlBoutonsNavigation
            // 
            this.pnlBoutonsNavigation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlBoutonsNavigation.Controls.Add(this.pbQuitter);
            this.pnlBoutonsNavigation.Controls.Add(this.pictureBox3);
            this.pnlBoutonsNavigation.Controls.Add(this.pictureBox2);
            this.pnlBoutonsNavigation.Controls.Add(this.pictureBox1);
            this.pnlBoutonsNavigation.Controls.Add(this.pbTableauDeBord);
            this.pnlBoutonsNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBoutonsNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlBoutonsNavigation.Name = "pnlBoutonsNavigation";
            this.pnlBoutonsNavigation.Size = new System.Drawing.Size(69, 692);
            this.pnlBoutonsNavigation.TabIndex = 7;
            // 
            // pbQuitter
            // 
            this.pbQuitter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbQuitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbQuitter.BackgroundImage")));
            this.pbQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQuitter.Location = new System.Drawing.Point(4, 629);
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.Size = new System.Drawing.Size(60, 60);
            this.pbQuitter.TabIndex = 8;
            this.pbQuitter.TabStop = false;
            this.pbQuitter.Click += new System.EventHandler(this.pbQuitter_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Location = new System.Drawing.Point(4, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Location = new System.Drawing.Point(4, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(4, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
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
            this.chkEnCours.Size = new System.Drawing.Size(133, 33);
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
            this.lblTitre.Size = new System.Drawing.Size(279, 40);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Tableau de bord";
            // 
            // frmTableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlTableauDeBord);
            this.Controls.Add(this.pnlBoutonsNavigation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTableauDeBord";
            this.Text = "Soldats du feu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmTableauDeBord_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbTableauDeBord)).EndInit();
            this.pnlBoutonsNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTableauDeBord.ResumeLayout(false);
            this.pnlTableauDeBord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbTableauDeBord;
        private System.Windows.Forms.Panel pnlBoutonsNavigation;
        private System.Windows.Forms.PictureBox pbQuitter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTableauDeBord;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.FlowLayoutPanel flpnlTDB;
        private System.Windows.Forms.CheckBox chkEnCours;
    }
}

