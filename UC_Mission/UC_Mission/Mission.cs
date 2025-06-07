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
        public delegate void GenererPDF(object sender, EventArgs e);
        public delegate void AfficherInformations(object sender, EventArgs e);
        public delegate void CloturerMission(object sender, EventArgs e);



        // L'instance du delegate
        public GenererPDF generateur;
        public AfficherInformations afficherInformations;
        public CloturerMission cloturerMission;

        // Variables pour les détails de mission
        int id;
        string dateDebut;
        string dateFin;
        string sinistre;
        string motif;
        string addresse;
        string compte_rendu;
        string caserne;
        string[] pompiers_affectes; // TODO : peut-être faire une classe ici pour représenter un pompier mais à voir

        public int Id { get => id; set => id = value; }
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        public string DateFin { get => dateFin; set => dateFin = value; }
        public string Sinistre { get => sinistre; set => sinistre = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Addresse { get => addresse; set => addresse = value; }
        public string Compte_rendu { get => compte_rendu; set => compte_rendu = value; }
        public string Caserne { get => caserne; set => caserne = value; }

        public bool EtatBoutonCloture { get => btnCloturerMission.Visible; set => btnCloturerMission.Visible = value; }

        public Mission()
        {
            InitializeComponent();
        }

        public Mission(int id_mission, string date_debut_mission, string caserne_pompiers, string sinistre_mission, string motif_mission)
        {
            InitializeComponent();
            this.lblID.Text += id_mission;
            this.id = id_mission;
            // Formattage de la date
            this.lblDateDebut.Text += Convert.ToDateTime(date_debut_mission).ToString("dd/MM/yyyy 'à' HH:mm");
            this.lblCaserne.Text += caserne_pompiers;
            this.caserne = caserne_pompiers;
            this.lblLNatureSinistre.Text += sinistre_mission;
            this.sinistre = sinistre_mission;
            this.lblMotifAppel.Text += motif_mission;
            this.motif = motif_mission;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenererPDF_Click(object sender, EventArgs e)
        {
            if (this.generateur != null)
            {
                this.generateur(this, e); // Remplacement the sender par this pour passer le formulaire au lieu du bouton
            }
        }

        private void btnInfos_Click(object sender, EventArgs e)
        {
            if (this.afficherInformations != null)
            {
                this.afficherInformations(this, e); // Remplacement the sender par this pour passer le formulaire au lieu du bouton
            }
        }

        private void btnCloturerMission_Click(object sender, EventArgs e)
        {
            if (this.cloturerMission != null)
            {
                this.cloturerMission(this, e); // Remplacement the sender par this pour passer le formulaire au lieu du bouton
            }
        }
    }
}
