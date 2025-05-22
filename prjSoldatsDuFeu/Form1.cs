using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_Mission;

namespace prjSoldatsDuFeu
{
    public partial class frmTableauDeBord : Form
    {
        SQLiteConnection cx = Connexion.Connec;

        public void AfficherDetailsMission(object sender, EventArgs e)
        {
            MessageBox.Show("KING KONG ça fonctionne");
        }

        public void FillDataSet(SQLiteConnection cx, DataSet ds)
        {
            try
            {
                string req;
                DataTable schemaTable = cx.GetSchema("Tables");
                string liste = "";

                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    string nomTable = schemaTable.Rows[i][2].ToString();
                    req = "SELECT * FROM " + nomTable;

                    using (SQLiteCommand cd = new SQLiteCommand(req, cx))
                    {
                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cd))
                        {
                            da.Fill(ds, nomTable);
                        }
                    }

                    liste += nomTable + "\n";
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur SQLite : " + err.Message);
            }
        }

        public void RemplirMission()
        {
            int id_mission = -1;
            int state_mission = -1;
            string motif = "";
            string date_debut = "";
            string nature_sinistre = "";
            string caserne = "";

            if (chkEnCours.Checked)
            {
                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    id_mission = Convert.ToInt32(dr["id"]);
                    state_mission = Convert.ToInt32(dr["terminee"]);
                    motif = dr["motifAppel"].ToString();
                    string date_non_formatee = dr["dateHeureDepart"].ToString();

                    // Formattage de la date
                    date_debut = Convert.ToDateTime(date_non_formatee).ToString("dd/MM/yyyy 'à' HH:mm");


                    string id_sinistre = dr["idNatureSinistre"].ToString();

                    string id_caserne = dr["idCaserne"].ToString();

                    DataRow[] nature_row = MesDatas.DsGlobal.Tables["NatureSinistre"].Select($"id = {id_sinistre}");
                    DataRow[] caserne_row = MesDatas.DsGlobal.Tables["Caserne"].Select($"id = {id_caserne}");

                    // Vérification si nature saisie
                    if (nature_row.Length > 0)
                    {
                        nature_sinistre = nature_row[0]["libelle"].ToString();
                    }
                    else
                    {
                        nature_sinistre = "Pas de nature de sinistre spécifiée.";
                    }

                    // Vérification si caserne existe
                    if (caserne_row.Length > 0)
                    {
                        caserne = caserne_row[0]["nom"].ToString();
                    }
                    else
                    {
                        caserne = "Pas de nature de caserne spécifiée.";
                    }

                    if (state_mission == 1)
                    {
                        Mission m = new Mission(id_mission, date_debut, caserne, nature_sinistre, motif);
                        m.generateur = AfficherDetailsMission;
                        flpnlTDB.Controls.Add(m);
                    }
                }
            }
            else
            {
                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    try
                    {
                        id_mission = Convert.ToInt32(dr["id"]);
                        state_mission = Convert.ToInt32(dr["terminee"]);
                        motif = dr["motifAppel"].ToString();
                        string date_non_formatee = dr["dateHeureDepart"].ToString();

                        // Formattage de la date
                        date_debut = Convert.ToDateTime(date_non_formatee).ToString("dd/MM/yyyy 'à' HH:mm");

                        string id_sinistre = dr["idNatureSinistre"].ToString();

                        string id_caserne = dr["idCaserne"].ToString();

                        DataRow[] nature_row = MesDatas.DsGlobal.Tables["NatureSinistre"].Select($"id = {id_sinistre}");
                        DataRow[] caserne_row = MesDatas.DsGlobal.Tables["Caserne"].Select($"id = {id_caserne}");

                        // Vérification si nature saisie
                        if (nature_row.Length > 0)
                        {
                            nature_sinistre = nature_row[0]["libelle"].ToString();
                        }
                        else
                        {
                            nature_sinistre = "Pas de nature de sinistre spécifiée.";
                        }

                        // Vérification si caserne existe
                        if (caserne_row.Length > 0)
                        {
                            caserne = caserne_row[0]["nom"].ToString();
                        }
                        else
                        {
                            caserne = "Pas de nature de caserne spécifiée.";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur : {ex.Message}");
                    }
                    Mission m = new Mission(id_mission, date_debut, caserne, nature_sinistre, motif);
                    flpnlTDB.Controls.Add(m);
                }
            }
        }

        public frmTableauDeBord()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataSet(this.cx, MesDatas.DsGlobal);
            RemplirMission();
        }

        private void imageButton1_Load(object sender, EventArgs e)
        {
            //imageButton1.File_name = "start.jpg";
        }

        private void pbTableauDeBord_Click(object sender, EventArgs e)
        {

        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTableauDeBord_Resize(object sender, EventArgs e)
        {
            // TODO : METTRE UN TRUC POUR l'autoresize des Missions avec un accesseur sur sa taille et selon la taille du flowpanel
            // Le faire pour à peu près tout
        }

        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            flpnlTDB.Controls.Clear(); // On vide le flow panel avant de le remplir à nouveau
            RemplirMission();
        }
    }
}
