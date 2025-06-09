namespace prjSoldatsDuFeu
{
    partial class frmNewMission
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblDateMission = new System.Windows.Forms.Label();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtMotif = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxDeci = new System.Windows.Forms.GroupBox();
            this.grpBoxResult = new System.Windows.Forms.GroupBox();
            this.dgvPompiers = new System.Windows.Forms.DataGridView();
            this.dgvEngins = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpNatureSinistre = new System.Windows.Forms.GroupBox();
            this.grpCaserneMobi = new System.Windows.Forms.GroupBox();
            this.grpBoxInfo.SuspendLayout();
            this.grpBoxDeci.SuspendLayout();
            this.grpBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(890, 667);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(326, 65);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMission.Location = new System.Drawing.Point(205, 25);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(79, 29);
            this.lblNumMission.TabIndex = 1;
            this.lblNumMission.Text = "label1";
            // 
            // lblDateMission
            // 
            this.lblDateMission.AutoSize = true;
            this.lblDateMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateMission.Location = new System.Drawing.Point(722, 25);
            this.lblDateMission.Name = "lblDateMission";
            this.lblDateMission.Size = new System.Drawing.Size(79, 29);
            this.lblDateMission.TabIndex = 2;
            this.lblDateMission.Text = "label1";
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.txtRue);
            this.grpBoxInfo.Controls.Add(this.txtVille);
            this.grpBoxInfo.Controls.Add(this.txtCodePostal);
            this.grpBoxInfo.Controls.Add(this.label5);
            this.grpBoxInfo.Controls.Add(this.label4);
            this.grpBoxInfo.Controls.Add(this.label3);
            this.grpBoxInfo.Controls.Add(this.label2);
            this.grpBoxInfo.Controls.Add(this.rtxtMotif);
            this.grpBoxInfo.Controls.Add(this.label1);
            this.grpBoxInfo.Location = new System.Drawing.Point(12, 66);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(1201, 172);
            this.grpBoxInfo.TabIndex = 3;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Informations usager";
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(666, 55);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(461, 26);
            this.txtRue.TabIndex = 8;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(666, 128);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(461, 26);
            this.txtVille.TabIndex = 7;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(666, 94);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(123, 26);
            this.txtCodePostal.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse sinistre";
            // 
            // rtxtMotif
            // 
            this.rtxtMotif.Location = new System.Drawing.Point(67, 25);
            this.rtxtMotif.Name = "rtxtMotif";
            this.rtxtMotif.Size = new System.Drawing.Size(403, 126);
            this.rtxtMotif.TabIndex = 1;
            this.rtxtMotif.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motif";
            // 
            // grpBoxDeci
            // 
            this.grpBoxDeci.Controls.Add(this.grpCaserneMobi);
            this.grpBoxDeci.Controls.Add(this.grpNatureSinistre);
            this.grpBoxDeci.Controls.Add(this.btnValider);
            this.grpBoxDeci.Controls.Add(this.btnReset);
            this.grpBoxDeci.Location = new System.Drawing.Point(12, 244);
            this.grpBoxDeci.Name = "grpBoxDeci";
            this.grpBoxDeci.Size = new System.Drawing.Size(1201, 417);
            this.grpBoxDeci.TabIndex = 4;
            this.grpBoxDeci.TabStop = false;
            this.grpBoxDeci.Text = "Décisions du régulateur";
            // 
            // grpBoxResult
            // 
            this.grpBoxResult.Controls.Add(this.dgvPompiers);
            this.grpBoxResult.Controls.Add(this.dgvEngins);
            this.grpBoxResult.Controls.Add(this.label9);
            this.grpBoxResult.Controls.Add(this.label8);
            this.grpBoxResult.Location = new System.Drawing.Point(15, 66);
            this.grpBoxResult.Name = "grpBoxResult";
            this.grpBoxResult.Size = new System.Drawing.Size(1201, 595);
            this.grpBoxResult.TabIndex = 5;
            this.grpBoxResult.TabStop = false;
            this.grpBoxResult.Text = "Pompiers et engins mobiliser";
            // 
            // dgvPompiers
            // 
            this.dgvPompiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompiers.Location = new System.Drawing.Point(634, 63);
            this.dgvPompiers.Name = "dgvPompiers";
            this.dgvPompiers.RowHeadersWidth = 62;
            this.dgvPompiers.RowTemplate.Height = 28;
            this.dgvPompiers.Size = new System.Drawing.Size(558, 503);
            this.dgvPompiers.TabIndex = 3;
            // 
            // dgvEngins
            // 
            this.dgvEngins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngins.Location = new System.Drawing.Point(6, 63);
            this.dgvEngins.Name = "dgvEngins";
            this.dgvEngins.RowHeadersWidth = 62;
            this.dgvEngins.RowTemplate.Height = 28;
            this.dgvEngins.Size = new System.Drawing.Size(558, 503);
            this.dgvEngins.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(839, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pompiers mobilisés";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Engins mobilisés";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(846, 363);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(161, 48);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1034, 363);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 48);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Annuler";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpNatureSinistre
            // 
            this.grpNatureSinistre.Location = new System.Drawing.Point(6, 25);
            this.grpNatureSinistre.Name = "grpNatureSinistre";
            this.grpNatureSinistre.Size = new System.Drawing.Size(622, 371);
            this.grpNatureSinistre.TabIndex = 13;
            this.grpNatureSinistre.TabStop = false;
            this.grpNatureSinistre.Text = "Nature du sinistre";
            // 
            // grpCaserneMobi
            // 
            this.grpCaserneMobi.Location = new System.Drawing.Point(634, 25);
            this.grpCaserneMobi.Name = "grpCaserneMobi";
            this.grpCaserneMobi.Size = new System.Drawing.Size(557, 332);
            this.grpCaserneMobi.TabIndex = 14;
            this.grpCaserneMobi.TabStop = false;
            this.grpCaserneMobi.Text = "Caserne a mobiliser";
            // 
            // frmNewMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 752);
            this.Controls.Add(this.grpBoxResult);
            this.Controls.Add(this.grpBoxDeci);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.lblDateMission);
            this.Controls.Add(this.lblNumMission);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmNewMission";
            this.Text = "Gestion d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.frmNewMission_Load);
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            this.grpBoxDeci.ResumeLayout(false);
            this.grpBoxResult.ResumeLayout(false);
            this.grpBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblDateMission;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.GroupBox grpBoxDeci;
        private System.Windows.Forms.GroupBox grpBoxResult;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtMotif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView dgvPompiers;
        private System.Windows.Forms.DataGridView dgvEngins;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpNatureSinistre;
        private System.Windows.Forms.GroupBox grpCaserneMobi;
    }
}