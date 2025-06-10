using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSoldatsDuFeu
{
    // Déclaration de la signature du délégué
    public delegate void valider(object sender, EventArgs e);
    public partial class loginForm: UserControl
    {
        private String login;
        private String password;

        public string Login { get => txtLogin.Text; set => login = value; }
        public string Password { get => txtPasssword.Text; set => password = value; }

        // Déclaration d'une instance du délégué
        public valider valideur;
            
        public loginForm()
        {
            InitializeComponent();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPasssword.Clear();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Valider ou non la saisie dans le contexte appelant
            if (this.valideur != null) { this.valideur(sender, e); }
        }
    }
}
