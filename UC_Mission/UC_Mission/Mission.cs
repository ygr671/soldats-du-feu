using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace UC_Mission
{
    public partial class Mission: UserControl
    {
        public delegate void genererPDF(object sender, EventArgs e);
        
        // L'instance du delegate
        public genererPDF generateur;

        public Mission()
        {
            InitializeComponent();
        }

        public Mission(int id_mission, string date, string caserne, string sinistre, string motif)
        {
            InitializeComponent();
            this.lblID.Text += id_mission;
            this.lblDateDebut.Text += date;
            this.lblCaserne.Text += caserne;
            this.lblLNatureSinistre.Text += sinistre;
            this.lblMotifAppel.Text += motif;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pbGenererPDF_Click(object sender, EventArgs e)
        {
            if (this.generateur != null)
            {
                this.generateur(sender, e);
            }
        }
    }
}
