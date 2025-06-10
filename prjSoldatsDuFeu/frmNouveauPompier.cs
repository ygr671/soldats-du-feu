using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSoldatsDuFeu
{
    public partial class frmNouveauPompier : Form
    {            //bool condition : tout champs valide pour un requete
        bool champsValide = false;
        public frmNouveauPompier()
        {
            InitializeComponent();
            

        }

        private void NouveauPomp_Load(object sender, EventArgs e)
        {


            // remplir cbxSexe
            Dictionary<string, string> dicSexe = new Dictionary<string, string>
            {
                {"Homme", "m" },
                {"Femme", "f" }
            };
            cbxSexe.DataSource = new BindingSource(dicSexe, null);
            cbxSexe.DisplayMember = "Key";
            cbxSexe.ValueMember = "Value";


            // remplir cbxtype

            Dictionary<string, string> dicType = new Dictionary<string, string>
            {
                {"Professionnel", "p"},
                {"Volontaire", "v" }
            };
            cbxType.DataSource = new BindingSource(dicType, null);
            cbxType.DisplayMember = "Key";
            cbxType.ValueMember = "Value";


            //remplir grade
            cbxGrade.DataSource = MesDatas.DsGlobal.Tables["Grade"];
            cbxGrade.DisplayMember = "libelle";
            cbxGrade.ValueMember = "code";

        }

        private void txtMatricule_KeyPress(object sender, KeyPressEventArgs e)
        {
            // filtre
            e.Handled = true;

            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        void testMatricule()
        {
            string aTest = txtMatricule.Text;
            string requete = "SELECT * FROM Pompier ;";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();

                DataTable tableMatricule = new DataTable();
                tableMatricule.Load(reader);

                for (int i = 0; i < tableMatricule.Rows.Count; i++) // parcours les ligne de pompier

                {
                    if (tableMatricule.Rows[i]["matricule"].ToString() == aTest)
                    {
                        champsValide = false;
                        throw new Exception("Matricule déjà existant");
                    }
                    else
                    { champsValide = true; }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // filtre
            e.Handled = true;

            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // filtre
            e.Handled = true;

            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            if (e.KeyChar == 13)
            {
                // test si prenom est correct
            }
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // filtre
                e.Handled = true;

                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
        }

        private void txtBip_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // filtre
                e.Handled = true;

                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
        }

        void testNomPrenom()
    {
        string nomATest = txtNom.Text;
        string prenomATest = txtPrenom.Text;
        string requete = "SELECT * FROM Pompier ;";
        try
        {
            SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
            SQLiteDataReader reader = cmd.ExecuteReader();

            DataTable tableMatricule = new DataTable();
            tableMatricule.Load(reader);

            for (int i = 0; i < tableMatricule.Rows.Count; i++) // parcours les ligne de pompier

            {
                if (tableMatricule.Rows[i]["nom"].ToString() == nomATest &&
                    tableMatricule.Rows[i]["prenom"].ToString() == prenomATest)
                {
                    champsValide = false;
                    throw new Exception("Un pompier possede deja ce nom et prénom");
                }
                else
                { champsValide = true; }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur : " + ex.Message);
        }
    }

        void testBip()
        {
            string aTest = txtBip.Text;
            string requete = "SELECT * FROM Pompier ;";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();

                DataTable tableMatricule = new DataTable();
                tableMatricule.Load(reader);

                for (int i = 0; i < tableMatricule.Rows.Count; i++) // parcours les ligne de pompier

                {
                    if (tableMatricule.Rows[i]["bip"].ToString() == aTest)
                    {
                        champsValide = false;
                        throw new Exception("Numero de bip déjà existant");
                    }
                    else
                    { champsValide = true; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        void testTelephone()
        {
            string aTest = txtTelephone.Text;
            string requete = "SELECT * FROM Pompier ;";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();

                DataTable tableMatricule = new DataTable();
                tableMatricule.Load(reader);

                for (int i = 0; i < tableMatricule.Rows.Count; i++) // parcours les ligne de pompier

                {
                    if (tableMatricule.Rows[i]["portable"].ToString() == aTest)
                    {
                        champsValide = false;
                        throw new Exception("Numero de telephone déjà existant");
                    }
                    else
                    { champsValide = true; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            // test des champs entré par l'utilisateur
            testMatricule();
            testBip();
            testNomPrenom();
            testTelephone();
            
            // requete inserer dans pompier ligne : matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche
            if (champsValide)
            {
                try
                {
                    string req = "INSERT INTO Pompier (matricule, nom, prenom, " +
                        "sexe, dateNaissance, type, " +
                        "portable, bip, enMission, " +
                        "enConge, codeGrade, dateEmbauche) " +
                        "VALUES (@matricule, @nom, @prenom, " +
                        "@sexe, @dateNaissance, @type, " +
                        "@portable, @bip, @enMission, " +
                        "@enConge, @codeGrade, @dateEmbauche)";
                        
                    
                    SQLiteCommand command = new SQLiteCommand(req, Connexion.Connec);

                    command.Parameters.AddWithValue("@matricule", txtMatricule.Text.ToString());
                    command.Parameters.AddWithValue("@nom", txtNom.Text.ToString());
                    command.Parameters.AddWithValue("@prenom", txtPrenom.Text.ToString());
                    command.Parameters.AddWithValue("@sexe", cbxSexe.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@dateNaissance", dtpDateNaissance.Value.ToString("dd/MM/yyyy"));
                    command.Parameters.AddWithValue("@type", cbxType.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@portable", cbxGrade.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@bip", txtBip.Text.ToString());
                    command.Parameters.AddWithValue("@enMission", "0");
                    command.Parameters.AddWithValue("@enConge", "0");
                    command.Parameters.AddWithValue("@codeGrade", cbxGrade.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@dateEmbauche", dtpDateEmbauche.Value.ToString("dd/MM/yyyy"));

                    MessageBox.Show("Req:\n@matricule : " + txtMatricule.Text.ToString() +
                                    "\n@nom" + txtNom.Text.ToString() +
                                    "\n@prenom" + txtPrenom.ToString() +
                                    "\n@sexe" + cbxSexe.SelectedValue.ToString() +
                                    "\n@dateNaissance" + dtpDateNaissance.Value.ToString()+
                                    "\n@type" + cbxType.SelectedValue.ToString()+
                                    "\n@portable" + cbxGrade.SelectedValue.ToString()+
                                    "\n@bip" + txtBip.Text.ToString()+
                                    "\n@enMission" + "0" +
                                    "\n@enConge" + "0" +
                                    "\n@codeGrade" + cbxGrade.SelectedValue.ToString()+
                                    "\n@dateEmbauche" + dtpDateEmbauche.ToString()) ;

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show($"Requete pour ajouter un pompier : {ret} ligne(s) mise(s) à jour.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur Ajout Pompier : " + ex.Message);
                }

                // message utilisateur: ne pas oublier d'affecter le pompier à une caserne!
            }
        }


    }
}
