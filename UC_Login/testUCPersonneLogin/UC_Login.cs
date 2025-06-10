using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlExemple;

namespace prjSoldatsDuFeu
{
    public partial class UC_Login : Form
    {

        public delegate void ValiderLogin(object sender, EventArgs e);

        public UC_Login()
        {
            InitializeComponent();
            loginForm1.valideur = Valider;
        }
        
        public void Valider(object sender, EventArgs e)
        {
            // Cast du sender
            Button btn = (Button)sender;
            UserControlExemple.loginForm logForm = (UserControlExemple.loginForm)btn.Parent.Parent; // Il faut aller sur le parent du parent parce que le parent est un groupbox, qui est parent du bouton mdr
            // Affichage

            if (loginForm1.Login.Length == 0)
            {
                MessageBox.Show("Entrez un login !");
            }
            else if (loginForm1.Password.Length == 0)
            {
                MessageBox.Show("Entrez un mot de passe !");
            }
            else if (loginForm1.Password == "bonjour")
            {
                MessageBox.Show("Tu as réussi");
            }
            else { MessageBox.Show("Mauvais mot de passe !"); }
        }
    }
}
