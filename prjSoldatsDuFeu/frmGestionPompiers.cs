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
    public partial class frmGestionPompiers : Form
    {


        public frmGestionPompiers()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Ajouter le délégué
            FormulaireConnexion.valideur = AfficherInfoCarriere;
            // chargement des combobox caserne et pompier
            cbxChoixCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cbxChoixCaserne.DisplayMember = "nom";
            cbxChoixCaserne.ValueMember = "id";

            // creation de table dans dataset : tabPomp = JOIN pompier, affectation et grade, pour chargercbxPompier
            string req = "SELECT * FROM Pompier p JOIN Affectation a ON p.matricule = a.matriculePompier " ;
            string choixCaserne = cbxChoixCaserne.ValueMember.ToString();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(req, Connexion.Connec);
            adapter.Fill(MesDatas.DsGlobal, "TabPomp");

            /* inutile puisque requete en mode connecté
                        // tabHabili = JOIN pompier, passer et Habilitation, pour gprInfoCarriere
                        string reqHabili = "SELECT * FROM Pompier p " +
                                    "JOIN Passer s ON s.matriculePompier = p.matricule " +
                                    "JOIN Habilitation h ON h.id = s.idHabilitation";

                        SQLiteDataAdapter adapterHabili = new SQLiteDataAdapter(req, Connexion.Connec);
                        adapterHabili.Fill(MesDatas.DsGlobal, "TabHabili");
            */



            // puis chargement des 1ere infos
            chargerCbxPompier();

            majInfo();
        }
        
        private void chargerCbxPompier ()
        {

            // mettre les pompiers de la caserne selectionner dans une table TabPomp
            string filtre = "idCaserne = " + cbxChoixCaserne.SelectedValue.ToString();

            DataRow[] dtr = MesDatas.DsGlobal.Tables["TabPomp"].Select(filtre); // selection des pompiers selon leur caserne, possible grace à la jointure dans TabPomp

            DataTable dt = dtr.CopyToDataTable(); // table local et temporaire

            dt.Columns.Add("NomPrenom", typeof(string)); // pour chargerCbxPompeir

            foreach (DataRow dr in dt.Rows) // remplir la colonne pour l'affichage de la combo
            {
                dr["NomPrenom"] = dr["Nom"].ToString() + " " + dr["Prenom"].ToString();
            }


            cbxChoixPompier.DataSource = dt;
            cbxChoixPompier.DisplayMember = "NomPrenom";
            cbxChoixPompier.ValueMember = "Matricule";
        }

        private void cbxChoixCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chargerCbxPompier();
        }


        private void cbxChoixPompier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            majInfo();
        }

        private void majInfo()
        {
        // mise a jour des info du pompier en mode connecté

            //// recuperation de la ligne du pompier choisi, dans tabPomp, pour grpInfo
            string requete = "SELECT * FROM pompier p JOIN Grade g ON g.code = p.codeGrade WHERE p.matricule = " + cbxChoixPompier.SelectedValue + ";";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(requete,Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();

                DataTable tableLignePompier = new DataTable();
                tableLignePompier.Load(reader);

                //Remplissage des labels de grpInfo
                lblMatricule.Text = "Matricule : " + tableLignePompier.Rows[0]["matricule"].ToString();
                lblNom.Text = "Nom : " + tableLignePompier.Rows[0]["nom"].ToString(); 
                lblPrenom.Text = "Prénom : " + tableLignePompier.Rows[0]["prenom"].ToString();
                lblSexe.Text = "Sexe : " + tableLignePompier.Rows[0]["sexe"].ToString();
                lblNaissance.Text = "Date de naissance : " + tableLignePompier.Rows[0]["dateNaissance"].ToString();
                lblEmbauche.Text = "Date d'embauche : " + tableLignePompier.Rows[0]["dateEmbauche"].ToString();
                lblTelephone.Text = "Téléphone : " + tableLignePompier.Rows[0]["portable"].ToString();
                lblBip.Text = "Bip : " + tableLignePompier.Rows[0]["bip"].ToString();
                int boolConge = Convert.ToInt32(tableLignePompier.Rows[0]["enConge"]);
                if (boolConge == 1) { chkEnConge.Checked = true; } else { chkEnConge.Checked = false; }
                if (tableLignePompier.Rows[0]["type"].ToString() == "p") { rdbProfessionel.Checked = true; rdbVolontaire.Checked = false; }
                else {rdbProfessionel.Checked = false; rdbVolontaire.Checked = true; }

                //remplissage de gprGrade
                txtCodeGrade.Text = tableLignePompier.Rows[0]["codeGrade"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur majInfo, tabPomp: " + ex.Message);
            }

            //// recuperation des ligne du pompier dans la jointure de passer et habilitation, pour afficher ses habilitations
            requete = "SELECT * FROM Habilitation h JOIN Passer s ON h.id = s.idHabilitation " +
                        "WHERE s.matriculePompier = " + cbxChoixPompier.SelectedValue + ";";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();

                DataTable tableHabili = new DataTable();
                tableHabili.Load(reader);

                // remplissage txtHabilitation
                txtHabilitation.Clear();
                foreach (DataRow dr in tableHabili.Rows)
                {
                    txtHabilitation.AppendText( dr["dateObtention"].ToString() + " - " +
                                                dr["descriptif"].ToString() + Environment.NewLine);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur majInfo, habilitation: " + ex.Message);
            }

            //// recuperation des lignes du pompier dans la jointure affectation et caserne, pour afficher ses affectation , habilitation
            requete = "SELECT * FROM Affectation a JOIN caserne c ON a.idCaserne = c.id " +
                        "WHERE matriculePompier = " + cbxChoixPompier.SelectedValue + ";";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec);
                SQLiteDataReader reader = cmd.ExecuteReader();

                DataTable tableAffect = new DataTable();
                tableAffect.Load(reader);

                // remplissage txtAffectation
                txtAffectation.Clear();
                for (int i = 0; i < tableAffect.Rows.Count-1; i++) // seulement les affectations passés

                {
                    txtAffectation.AppendText("De " + tableAffect.Rows[i]["dateA"].ToString() +
                        " à " + tableAffect.Rows[i]["dateFin"].ToString() +
                        " - " + tableAffect.Rows[i]["nom"].ToString() +
                        Environment.NewLine);
                }


                // affichage pour dev
                
                //dgv3.DataSource = tableAffect;

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur majInfo, affectation: " + ex.Message);
            }
        }

        void remplirChangementInfo()
        {
            //remplir cbxCaserneRattachement, cbxGrade
            // creation de table dans dataset : tabMajCar =  caserne, pour charger cbxCaserneratachement
            string req = "SELECT * FROM Caserne";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(req, Connexion.Connec);
            adapter.Fill(MesDatas.DsGlobal, "TabMajCar");

        
            cbxCaserneRattachement.DataSource = MesDatas.DsGlobal.Tables["TabMajCar"];
            cbxCaserneRattachement.DisplayMember = "Nom";
            cbxCaserneRattachement.ValueMember = "id";

            cbxGrade.DataSource = MesDatas.DsGlobal.Tables["Grade"];
            cbxGrade.DisplayMember = "libelle";
            cbxGrade.ValueMember = "code";

        }

        private void AfficherInfoCarriere(object sender, EventArgs e)
        {
            bool connecte = false;
            foreach (DataRow dr in MesDatas.DsGlobal.Tables["Admin"].Rows)
            {
                if (FormulaireConnexion.Login == dr[1].ToString() && FormulaireConnexion.Password == dr[2].ToString()) // login et mdp
                { 
                    gpbInfoCarriere.Visible = true;
                    btnNouveauPompier.Visible = true;
                    remplirChangementInfo();
                    break;
                }
            }

        }

        private void btnMettreAJour_Click(object sender, EventArgs e)
        {
            // change la table en mode connecté, selon une requete dont les arguments son les choix de l'utilisateur
            // requete qui change idcaserne dans affectation
            // requete qui change codeGrade et enConge dans pompier

            string recupreq="";
            try
            {
                string req = "UPDATE Affectation " +
               "SET idCaserne = @Val1 " +
               "WHERE matriculePompier = @Val2;";
                recupreq = req;
                SQLiteCommand command = new SQLiteCommand(req, Connexion.Connec);
                command.Parameters.AddWithValue("@Val1", Convert.ToInt32(cbxCaserneRattachement.SelectedValue));
                command.Parameters.AddWithValue("@Val2", Convert.ToInt32(cbxChoixPompier.SelectedValue));

                int ret = command.ExecuteNonQuery();
                
                MessageBox.Show($"Requete pour changer caserne d'affectation : {ret} ligne(s) mise(s) à jour.\n\n req : "  + recupreq);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur majCaserAffect : " + ex.Message + "\n req : " + recupreq);
            }

            try
            {
                string req = "UPDATE Pompier " +
               "SET codeGrade = @Val1 ," +
               "enConge = @Val2 " +
               "WHERE matricule = " + cbxChoixPompier.SelectedValue.ToString() + ";";
                recupreq = req;
                SQLiteCommand command = new SQLiteCommand(req, Connexion.Connec);
                command.Parameters.AddWithValue("@Val1", cbxGrade.SelectedValue.ToString());
                int cong;
                if (chkEnCongeMAJ.Checked) { cong = 1; } else { cong = 0; }  
                command.Parameters.AddWithValue("@Val2", cong.ToString());


                int ret = command.ExecuteNonQuery();
                MessageBox.Show($"Requete pour changer grade et congé : {ret} ligne(s) mise(s) à jour.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur majCaserAffect : " + ex.Message + "\n req : " + recupreq);
            }
        }

        private void btnNouveauPompier_Click(object sender, EventArgs e)
        {

            frmNouveauPompier f2 = new frmNouveauPompier();
            f2.ShowDialog();
        }
    }
}
