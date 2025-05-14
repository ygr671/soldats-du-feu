namespace prjSoldatsDuFeu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIDMission = new System.Windows.Forms.Label();
            this.lblDebutMission = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblMotifAppel = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIDMission
            // 
            this.lblIDMission.AutoSize = true;
            this.lblIDMission.Location = new System.Drawing.Point(209, 12);
            this.lblIDMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDMission.Name = "lblIDMission";
            this.lblIDMission.Size = new System.Drawing.Size(34, 20);
            this.lblIDMission.TabIndex = 1;
            this.lblIDMission.Text = "ID :";
            // 
            // lblDebutMission
            // 
            this.lblDebutMission.AutoSize = true;
            this.lblDebutMission.Location = new System.Drawing.Point(319, 12);
            this.lblDebutMission.Name = "lblDebutMission";
            this.lblDebutMission.Size = new System.Drawing.Size(73, 20);
            this.lblDebutMission.TabIndex = 2;
            this.lblDebutMission.Text = "Début le ";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(297, 29);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(81, 20);
            this.lblCaserne.TabIndex = 3;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // lblMotifAppel
            // 
            this.lblMotifAppel.AutoSize = true;
            this.lblMotifAppel.Location = new System.Drawing.Point(209, 103);
            this.lblMotifAppel.Name = "lblMotifAppel";
            this.lblMotifAppel.Size = new System.Drawing.Size(51, 20);
            this.lblMotifAppel.TabIndex = 4;
            this.lblMotifAppel.Text = "label1";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(316, 86);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(51, 20);
            this.lblConclusion.TabIndex = 5;
            this.lblConclusion.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCaserne);
            this.panel1.Controls.Add(this.lblConclusion);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 184);
            this.panel1.TabIndex = 6;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMotifAppel);
            this.Controls.Add(this.lblDebutMission);
            this.Controls.Add(this.lblIDMission);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(868, 191);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIDMission;
        private System.Windows.Forms.Label lblDebutMission;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblMotifAppel;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Panel panel1;
    }
}
