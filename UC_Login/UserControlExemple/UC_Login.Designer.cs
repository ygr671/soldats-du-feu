namespace prjSoldatsDuFeu
{
    partial class loginForm
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
            this.grpConnexion = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtPasssword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.grpConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnexion
            // 
            this.grpConnexion.Controls.Add(this.btnValider);
            this.grpConnexion.Controls.Add(this.btnAnnuler);
            this.grpConnexion.Controls.Add(this.txtPasssword);
            this.grpConnexion.Controls.Add(this.txtLogin);
            this.grpConnexion.Controls.Add(this.lblPassword);
            this.grpConnexion.Controls.Add(this.lblLogin);
            this.grpConnexion.Location = new System.Drawing.Point(0, 0);
            this.grpConnexion.Name = "grpConnexion";
            this.grpConnexion.Size = new System.Drawing.Size(176, 137);
            this.grpConnexion.TabIndex = 0;
            this.grpConnexion.TabStop = false;
            this.grpConnexion.Text = "Connexion";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(90, 97);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(9, 97);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtPasssword
            // 
            this.txtPasssword.Location = new System.Drawing.Point(71, 58);
            this.txtPasssword.Name = "txtPasssword";
            this.txtPasssword.Size = new System.Drawing.Size(99, 20);
            this.txtPasssword.TabIndex = 3;
            this.txtPasssword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(71, 29);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(99, 20);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 61);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpConnexion);
            this.Name = "loginForm";
            this.Size = new System.Drawing.Size(176, 137);
            this.grpConnexion.ResumeLayout(false);
            this.grpConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnexion;
        private System.Windows.Forms.TextBox txtPasssword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
