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
using System.Data.SqlClient;

namespace prjSoldatsDuFeu
{
    public partial class frmTableauDeBord : Form
    {
        SQLiteConnection cx = Connexion.Connec;

        public void AfficherDetailsMission(object sender, EventArgs e)
        {
            Mission mission = (Mission)sender;

            var tableMissions = MesDatas.DsGlobal.Tables["Mission"];
            var tableNatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"];
            var tableCasernes = MesDatas.DsGlobal.Tables["Caserne"];

            DataRow[] resultatMission = tableMissions.Select("id = " + mission.Id);
            if (resultatMission.Length == 0)
            {
                MessageBox.Show($"Mission {mission.Id} introuvable.");
                return;
            }

            DataRow ligneMission = resultatMission[0];

            // Données de base
            DateTime dateHeureDepart = Convert.ToDateTime(ligneMission["dateHeureDepart"]);
            string dateHeureRetourStr = ligneMission["dateHeureRetour"] == DBNull.Value ? "En cours" : Convert.ToDateTime(ligneMission["dateHeureRetour"]).ToString("dd-MM-yyyy 'à' HH'h'mm");
            string motifAppel = ligneMission["motifAppel"].ToString();
            string adresseMission = ligneMission["adresse"].ToString();
            string compteRenduMission = (ligneMission["compteRendu"].ToString().Length != 0) ? ligneMission["compteRendu"].ToString() : "Compte rendu de mission vide.";
            int idCaserneMission = Convert.ToInt32(ligneMission["idCaserne"]);
            int idNatureSinistreMission = Convert.ToInt32(ligneMission["idNatureSinistre"]);

            string libelleSinistre = tableNatureSinistre.Select("id = " + idNatureSinistreMission).FirstOrDefault()?["libelle"]?.ToString() ?? "Inconnu";
            string nomCaserne = tableCasernes.Select("id = " + idCaserneMission).FirstOrDefault()?["nom"]?.ToString() ?? "Inconnue";

            // Création du texte à afficher
            string details = $"📋 **Détails de la mission n°{mission.Id}**\n\n" +
                             $"🕒 Déclenchée le : {dateHeureDepart:dd-MM-yyyy 'à' HH'h'mm}\n" +
                             $"🔚 Retour le : {dateHeureRetourStr}\n" +
                             $"🏷️ Type de sinistre : {libelleSinistre}\n" +
                             $"📌 Motif : {motifAppel}\n" +
                             $"📍 Adresse : {adresseMission}\n" +
                             $"🏠 Caserne : {nomCaserne}\n" +
                             $"📝 Compte-rendu : {compteRenduMission}";

            // Affichage
            MessageBox.Show(details, $"Mission n°{mission.Id}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void GenererPDF(object sender, EventArgs e)
        {
            Document document = new Document();
            Mission mission = (Mission)sender;

            try
            {
                // Création du dossier pour les PDFs s'il n'existe pas
                string dossierPdf = Path.Combine(Application.StartupPath, "rapports");
                if (!Directory.Exists(dossierPdf))
                {
                    Directory.CreateDirectory(dossierPdf);
                }

                // Définition du chemin du fichier PDF
                string cheminFichier = Path.Combine(dossierPdf, $"Mission_{mission.Id}.pdf");
                MessageBox.Show("Avant création fichier : " + cheminFichier);

                using (FileStream fichierStream = new FileStream(cheminFichier, FileMode.Create))
                {
                    PdfWriter.GetInstance(document, fichierStream);
                    document.Open();

                    // Chargement des tables de données nécessaires
                    var tableMissions = MesDatas.DsGlobal.Tables["Mission"];
                    var tableNatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"];
                    var tableCasernes = MesDatas.DsGlobal.Tables["Caserne"];
                    var tableAffectations = MesDatas.DsGlobal.Tables["Affectation"];
                    var tablePompiers = MesDatas.DsGlobal.Tables["Pompier"];
                    var tableGrades = MesDatas.DsGlobal.Tables["Grade"];
                    var tablePartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"];
                    var tableEngins = MesDatas.DsGlobal.Tables["Engin"];
                    var tableTypeEngin = MesDatas.DsGlobal.Tables["TypeEngin"];

                    // Recherche de la mission
                    DataRow[] resultatMission = tableMissions.Select("id = " + mission.Id);
                    if (resultatMission.Length == 0)
                    {
                        MessageBox.Show($"Mission {mission.Id} introuvable.");
                        return;
                    }

                    DataRow ligneMission = resultatMission[0];

                    // Données principales
                    DateTime dateHeureDepart = Convert.ToDateTime(ligneMission["dateHeureDepart"]);
                    string dateHeureRetourStr = ligneMission["dateHeureRetour"] == DBNull.Value ? ": en cours" : Convert.ToDateTime(ligneMission["dateHeureRetour"]).ToString("dd-MM-yyyy 'à' HH'h'mm");
                    string motifAppel = ligneMission["motifAppel"].ToString();
                    string adresseMission = ligneMission["adresse"].ToString();
                    string compteRenduMission = (ligneMission["compteRendu"].ToString().Length != 0) ? ligneMission["compteRendu"].ToString() : "Compte rendu de mission vide.";
                    int idCaserneMission = Convert.ToInt32(ligneMission["idCaserne"]);
                    int idNatureSinistreMission = Convert.ToInt32(ligneMission["idNatureSinistre"]);

                    // Infos sinistre et caserne
                    string libelleSinistre = tableNatureSinistre.Select("id = " + idNatureSinistreMission).FirstOrDefault()?["libelle"]?.ToString() ?? "Inconnu";
                    string nomCaserne = tableCasernes.Select("id = " + idCaserneMission).FirstOrDefault()?["nom"]?.ToString() ?? "Inconnu";

                    // Ajout au PDF
                    document.Add(new Paragraph("Rapport de la mission") { Alignment = Element.ALIGN_CENTER });
                    document.Add(new Paragraph(" "));

                    document.Add(new Paragraph("Déclenchée le " + dateHeureDepart.ToString("dd-MM-yyyy 'à' HH'h'mm")));
                    document.Add(new Paragraph("Retour le " + dateHeureRetourStr));
                    document.Add(new Paragraph(new string('-', 40)));
                    document.Add(new Paragraph("Type de sinistre : " + libelleSinistre));
                    document.Add(new Paragraph("Motif : " + motifAppel));
                    document.Add(new Paragraph("Adresse : " + adresseMission));
                    document.Add(new Paragraph("Compte-rendu : " + compteRenduMission));
                    document.Add(new Paragraph(new string('-', 40)));
                    document.Add(new Paragraph("Caserne : " + nomCaserne));
                    document.Add(new Paragraph(" "));

                    // Pompiers affectés
                    document.Add(new Paragraph("Pompiers affectés :"));
                    var affectationsFiltres = tableAffectations.Select($"idCaserne = {idCaserneMission}");

                    foreach (var affectation in affectationsFiltres)
                    {
                        int matriculePompier = Convert.ToInt32(affectation["matriculePompier"]);
                        DateTime dateDebut = Convert.ToDateTime(affectation["dateA"]);
                        string dateFinStr = affectation["dateFin"].ToString();
                        DateTime dateFin = string.IsNullOrEmpty(dateFinStr) ? DateTime.MaxValue : Convert.ToDateTime(dateFinStr);

                        if (dateDebut <= DateTime.Now && dateFin >= dateHeureDepart)
                        {
                            var pompier = tablePompiers.Select("matricule = " + matriculePompier).FirstOrDefault();
                            if (pompier != null)
                            {
                                string codeGrade = pompier["codeGrade"].ToString();
                                string libelleGrade = tableGrades.Select($"code = '{codeGrade}'").FirstOrDefault()?["libelle"]?.ToString() ?? "";
                                string nomComplet = $"{libelleGrade} {pompier["nom"]} {pompier["prenom"]}";
                                document.Add(new Paragraph("--> " + nomComplet));
                            }
                        }
                    }

                    document.Add(new Paragraph(new string('-', 40)));

                    // Engins mobilisés
                    document.Add(new Paragraph("Engins mobilisés :"));
                    var enginsMobilises = tablePartirAvec.Select("idMission = " + mission.Id);
                    foreach (var engin in enginsMobilises)
                    {
                        int idCaserneEngin = Convert.ToInt32(engin["idCaserne"]);
                        string codeType = engin["codeTypeEngin"].ToString();
                        int numero = Convert.ToInt32(engin["numeroEngin"]);
                        string reparations = engin["reparationsEventuelles"].ToString();

                        var enginTrouve = tableEngins.Select(
                            $"idCaserne = {idCaserneEngin} AND codeTypeEngin = '{codeType}' AND numero = {numero}"
                        ).FirstOrDefault();

                        if (enginTrouve != null)
                        {
                            string nomType = tableTypeEngin.Select($"code = '{codeType}'").FirstOrDefault()?["nom"]?.ToString() ?? codeType;
                            string texte = !string.IsNullOrWhiteSpace(reparations)
                                ? $"--> Engin {nomType} n°{numero} (Réparations : {reparations})"
                                : $"--> Engin {nomType} n°{numero}";

                            document.Add(new Paragraph(texte));
                        }
                    }

                    document.Close();
                    MessageBox.Show("PDF généré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string cheminFichier = "";
                try
                {
                    cheminFichier = Path.Combine(Application.StartupPath, "rapports", $"Mission_{mission.Id}.pdf");
                }
                catch { /* ignore */ }

                MessageBox.Show(
                    "Erreur lors de la génération du PDF :\n" +
                    ex.Message +
                    "\n\nType : " + ex.GetType().FullName +
                    "\nStackTrace :\n" + ex.StackTrace +
                    (!string.IsNullOrEmpty(cheminFichier) ? "\n\nChemin tenté : " + cheminFichier : ""),
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
            flpnlTDB.Controls.Clear(); // On vide le flow panel avant de le remplir à nouveau

            int id_mission = -1;
            int state_mission = -1;
            string motif = "";
            string date_non_formatee = "";
            string nature_sinistre = "";
            string caserne = "";

            // Missions en cours
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

                    if (state_mission == 0)
                    {
                        Mission m = new Mission(id_mission, date_non_formatee, caserne, nature_sinistre, motif);
                        m.Tag = id_mission;
                        m.afficherInformations = AfficherDetailsMission;
                        m.generateur = GenererPDF;
                        m.cloturerMission = CloturerMission;
                        m.Motif = motif;
                        m.Sinistre = nature_sinistre;
                        m.EtatBoutonCloture = true;
                        flpnlTDB.Controls.Add(m);
                    }
                }
            }
            // Missions terminées
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
                    m.cloturerMission = CloturerMission;
                    m.generateur = GenererPDF;
                    m.EtatBoutonCloture = false;
                    flpnlTDB.Controls.Add(m);
                }
            }
        }

        private void CloturerMission(object sender, EventArgs e)
        {
            Mission mission = (Mission)sender;
            // Cloture de la mission dans le dataset
            DataTable tableMission = MesDatas.DsGlobal.Tables["Mission"];

            DataRow[] lignes = MesDatas.DsGlobal.Tables["Mission"].Select($"id = {mission.Id}");
            if (lignes.Length > 0)
            {
                lignes[0]["terminee"] = 1;
            }

            SQLiteTransaction transaction = null;
            try
            {
                // Démarrage de la transaction
                transaction = cx.BeginTransaction();

                // Requête SQL
                string req = "UPDATE Mission SET terminee = 1 WHERE id = " + mission.Id + ";";

                // Création de la commande et affectation de la transaction
                SQLiteCommand cmd = new SQLiteCommand(req, cx);
                cmd.Transaction = transaction;

                // Exécution de la commande
                cmd.ExecuteNonQuery();

                // Validation de la transaction
                transaction.Commit();
            }
            catch (Exception err)
            {
                // Annulation si erreur
                if (transaction != null)
                    transaction.Rollback();

                MessageBox.Show("Erreur : " + err.Message);
            }


            MessageBox.Show("Mission n°" + mission.Id + " clôturée avec succès.", "Clôture de mission", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RemplirMission();
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

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            Form frmStatistiques = new frmStatistiques();
            frmStatistiques.ShowDialog();
        }

        private void btnCreerMission_Click(object sender, EventArgs e)
        {
            Form frmMission = new frmNewMission();
            frmMission.ShowDialog();
            MesDatas.DsGlobal.Clear();
            FillDataSet(this.cx, MesDatas.DsGlobal);
            RemplirMission();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmPompiers = new frmGestionPompiers();
            frmPompiers.ShowDialog();
        }
    }
}
