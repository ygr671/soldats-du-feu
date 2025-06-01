using iTextSharp.text.pdf;
using iTextSharp.text;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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
            Mission mission = (Mission)sender;
            MessageBox.Show("Mission n°" + mission.Id);
        }

        public void GenererPDF(object sender, EventArgs e)
        {
            Mission mission = (Mission)sender;

            string path = @"rapports/" + mission.Id + ".pdf";
            Document doc = new Document(PageSize.A4);
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();

                // Titre
                Paragraph titre = new Paragraph($"Rapport de mission n° {mission.Id}", FontFactory.GetFont("Arial", 18));
                titre.Alignment = Element.ALIGN_CENTER;
                doc.Add(titre);
                doc.Add(new Paragraph(" ")); // espace

                // Détails
                doc.Add(new Paragraph($"Date de début : a"));
                doc.Add(new Paragraph($"Caserne : a"));
                doc.Add(new Paragraph($"Nature du sinistre : a"));
                doc.Add(new Paragraph($"Motif de l'appel : a"));

                doc.Close();

                MessageBox.Show("PDF généré avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du PDF : " + ex.Message);
            }
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
            string date_non_formatee = "";
            string nature_sinistre = "";
            string caserne = "";

            if (chkEnCours.Checked)
            {
                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Mission"].Rows)
                {
                    id_mission = Convert.ToInt32(dr["id"]);
                    state_mission = Convert.ToInt32(dr["terminee"]);
                    motif = dr["motifAppel"].ToString();
                    date_non_formatee = dr["dateHeureDepart"].ToString();

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
                        Mission m = new Mission(id_mission, date_non_formatee, caserne, nature_sinistre, motif);
                        m.Tag = id_mission;
                        m.afficherInformations = AfficherDetailsMission;
                        m.generateur = GenererPDF;
                        m.Motif = motif;
                        m.Sinistre = nature_sinistre;
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
                        date_non_formatee = dr["dateHeureDepart"].ToString();

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
                    Mission m = new Mission(id_mission, date_non_formatee, caserne, nature_sinistre, motif);
                    m.Tag = id_mission;
                    m.afficherInformations = AfficherDetailsMission;
                    m.generateur = GenererPDF;
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

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionEngins_Click(object sender, EventArgs e)
        {
            Form frmEngins = new frmEnginEnregistre();
            frmEngins.ShowDialog();
        }
    }
}
