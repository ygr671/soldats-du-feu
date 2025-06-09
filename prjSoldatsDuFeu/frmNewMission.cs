using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace prjSoldatsDuFeu
{
    public partial class frmNewMission : Form
    {
        public frmNewMission()
        {
            InitializeComponent();
        }

        private void frmNewMission_Load(object sender, EventArgs e)
        {
            grpBoxResult.Visible = false;

            try
            {
                lblNumMission.Text = "Mission n°" + (MesDatas.DsGlobal.Tables["Mission"].Rows.Count + 1).ToString();
                lblDateMission.Text = "Déclenchée le : " + DateTime.Now.ToString("yyyy-MM-dd") + " à " + DateTime.Now.ToString("t");
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            int x = 15;
            int y = 25;

            try
            {
                for (int i = 0; i < MesDatas.DsGlobal.Tables["NatureSinistre"].Rows.Count; i++)
                {
                    RadioButton rb = new RadioButton
                    {
                        AutoSize = true,
                        Location = new Point(x, y),
                        Name = "rdb" + MesDatas.DsGlobal.Tables["NatureSinistre"].Rows[i].Field<string>("libelle"),
                        Tag = i,
                        Text = MesDatas.DsGlobal.Tables["NatureSinistre"].Rows[i].Field<string>("libelle"),
                        UseVisualStyleBackColor = true,
                        Checked = false
                    };

                    grpNatureSinistre.Controls.Add(rb);

                    y += 25;
                    if ((i + 1) % 7 == 0)
                    {
                        y = 55;
                        x += 200;
                    }
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            x = 15;
            y = 25;

            try
            {
                for (int i = 0; i < MesDatas.DsGlobal.Tables["Caserne"].Rows.Count; i++)
                {
                    RadioButton rb = new RadioButton
                    {
                        AutoSize = true,
                        Location = new Point(x, y),
                        Name = "rdb" + MesDatas.DsGlobal.Tables["Caserne"].Rows[i].Field<string>("nom"),
                        Tag = i,
                        Text = MesDatas.DsGlobal.Tables["Caserne"].Rows[i].Field<string>("nom"),
                        UseVisualStyleBackColor = true,
                        Checked = false
                    };

                    grpCaserneMobi.Controls.Add(rb);

                    y += 25;
                    if ((i + 1) % 7 == 0)
                    {
                        y = 55;
                        x += 200;
                    }
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtxtMotif.Clear();
            txtRue.Clear();
            txtVille.Clear();
            txtCodePostal.Clear();

            foreach (RadioButton rb in grpNatureSinistre.Controls.OfType<RadioButton>())
                rb.Checked = false;

            foreach (RadioButton rb in grpCaserneMobi.Controls.OfType<RadioButton>())
                rb.Checked = false;

            dgvEngins.Rows.Clear();
            dgvEngins.Columns.Clear();

            dgvPompiers.Rows.Clear();
            dgvPompiers.Columns.Clear();

            grpBoxInfo.Visible = true;
            grpBoxDeci.Visible = true;
            grpBoxResult.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int idSinistre = 0;
            int idCaserne = 0;

            foreach (RadioButton rdb in grpNatureSinistre.Controls.OfType<RadioButton>())
            {
                if (rdb.Checked)
                {
                    if (rdb.Tag is int index)
                        idSinistre = index + 1;
                    break;
                }
            }

            foreach (RadioButton rdb in grpCaserneMobi.Controls.OfType<RadioButton>())
            {
                if (rdb.Checked)
                {
                    if (rdb.Tag is int index)
                        idCaserne = index + 1;
                    break;
                }
            }

            if (idSinistre == 0 || idCaserne == 0)
            {
                MessageBox.Show("Veuillez sélectionner une nature de sinistre et une caserne.");
                return;
            }

            try
            {
                // Engins nécessaires pour la mission
                Dictionary<string, int> typeNeeded = new Dictionary<string, int>();
                // Engins disponibles dans la caserne
                Dictionary<string, List<int>> enginDispo = new Dictionary<string, List<int>>();

                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Necessiter"].Rows)
                {
                    if (Convert.ToInt32(dr["idNatureSinistre"]) == idSinistre)
                    {
                        string typeEngin = dr["codeTypeEngin"].ToString();
                        int nombre = Convert.ToInt32(dr["nombre"]);

                        if (!typeNeeded.ContainsKey(typeEngin))
                            typeNeeded[typeEngin] = 0;
                        typeNeeded[typeEngin] += nombre;
                    }
                }

                foreach (var type in typeNeeded.Keys)
                {
                    enginDispo[type] = new List<int>();
                }

                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Engin"].Rows)
                {
                    int caserneId = Convert.ToInt32(dr["idCaserne"]);
                    if (caserneId == idCaserne)
                    {
                        string typeEngin = dr["codeTypeEngin"].ToString();
                        int numero = Convert.ToInt32(dr["numero"]);
                        bool enMission = dr["enMission"].ToString() == "1";
                        bool enPanne = dr["enPanne"].ToString() == "1";

                        if (!enMission && !enPanne && typeNeeded.ContainsKey(typeEngin))
                        {
                            enginDispo[typeEngin].Add(numero);
                        }
                    }
                }

                // Vérification si assez d'engins disponibles
                foreach (var kvp in typeNeeded)
                {
                    string type = kvp.Key;
                    int required = kvp.Value;
                    if (enginDispo[type].Count < required)
                    {
                        MessageBox.Show($"Mission annulée : pas assez d'engins disponibles du type {type}.");
                        btnReset_Click(sender, e);
                        return;
                    }
                }

                // Pompiers nécessaires (habilitation)
                Dictionary<int, int> habiNeeded = new Dictionary<int, int>();
                // Pompiers disponibles (matricule -> habilitation)
                Dictionary<int, int> pompierDispo = new Dictionary<int, int>();

                foreach (var kvp in typeNeeded)
                {
                    string codeTypeEngin = kvp.Key;

                    foreach (DataRow dr in MesDatas.DsGlobal.Tables["Embarquer"].Rows)
                    {
                        if (dr["codeTypeEngin"].ToString() == codeTypeEngin)
                        {
                            int idHabilitation = Convert.ToInt32(dr["idHabilitation"]);
                            int nombre = Convert.ToInt32(dr["nombre"]);

                            if (!habiNeeded.ContainsKey(idHabilitation))
                                habiNeeded[idHabilitation] = 0;
                            habiNeeded[idHabilitation] += nombre;
                        }
                    }
                }

                foreach (var kvp in habiNeeded)
                {
                    int habilitation = kvp.Key;
                    int required = kvp.Value;
                    int count = 0;

                    foreach (DataRow dr in MesDatas.DsGlobal.Tables["Passer"].Rows)
                    {
                        if (Convert.ToInt32(dr["idHabilitation"]) == habilitation)
                        {
                            int matricule = Convert.ToInt32(dr["matriculePompier"]);
                            if (!pompierDispo.ContainsKey(matricule))
                            {
                                pompierDispo[matricule] = habilitation;
                                count++;
                                if (count >= required)
                                    break;
                            }
                        }
                    }

                    if (count < required)
                    {
                        MessageBox.Show($"Mission annulée : pas assez de pompiers avec l'habilitation {habilitation}.");
                        btnReset_Click(sender, e);
                        return;
                    }
                }

                // Affichage des engins dans DataGridView
                dgvEngins.Rows.Clear();
                dgvEngins.Columns.Clear();
                dgvEngins.Columns.Add("type", "Type engin");
                dgvEngins.Columns.Add("numero", "Numéro");

                foreach (var kvp in enginDispo)
                {
                    string type = kvp.Key;
                    int required = typeNeeded[type];
                    var numeros = kvp.Value.OrderBy(n => n).Take(required);

                    foreach (var num in numeros)
                    {
                        dgvEngins.Rows.Add(type, num);
                    }
                }

                // Affichage des pompiers dans DataGridView
                dgvPompiers.Rows.Clear();
                dgvPompiers.Columns.Clear();
                dgvPompiers.Columns.Add("matricule", "Matricule");
                dgvPompiers.Columns.Add("habilitation", "Habilitation");

                foreach (var kvp in pompierDispo)
                {
                    dgvPompiers.Rows.Add(kvp.Key, kvp.Value);
                }

                grpBoxInfo.Visible = false;
                grpBoxDeci.Visible = false;
                grpBoxResult.Visible = true;

                // Construction de la requête d'insertion (attention injection SQL volontaire)
                string mission = $@"INSERT INTO Mission
                                    (id, dateHeureDepart, dateHeureRetour, motifAppel, adresse, cp, ville, terminee, compteRendu, idNatureSinistre, idCaserne)
                                    VALUES
                                    ({MesDatas.DsGlobal.Tables["Mission"].Rows.Count + 1},
                                    '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',
                                    NULL,
                                    '{rtxtMotif.Text}',
                                    '{txtRue.Text}',
                                    '{txtCodePostal.Text}',
                                    '{txtVille.Text}',
                                    0,
                                    NULL,
                                    {idSinistre},
                                    {idCaserne});";

                using (SQLiteCommand cmd = new SQLiteCommand(mission, Connexion.Connec))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
