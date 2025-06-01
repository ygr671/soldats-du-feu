using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSoldatsDuFeu
{
    public partial class frmEnginEnregistre : Form
    {
        
        int index = 0; // index des lignes de dsEngin
        BindingSource bs1 = new BindingSource();

        public frmEnginEnregistre()
        {
            InitializeComponent();
        }

        private void frmEnginEnregistre_Load(object sender, EventArgs e)
        {

            // chargement combobox des casernes
            cbxCaserne.DataSource = MesDatas.DsGlobal.Tables["Caserne"];
            cbxCaserne.DisplayMember = "nom";
            cbxCaserne.ValueMember = "id";

            chargeTabledsEngin();

        }

        void chargeTabledsEngin()
        {
            try
            {
                if (MesDatas.DsGlobal.Tables.Contains("TableDsEngin"))
                {
                    MesDatas.DsGlobal.Tables.Remove("TableDsEngin");
                }

                string req;
                string choixCaserne = cbxCaserne.SelectedValue.ToString();

                req = "SELECT e.*, t.Nom AS NomTypeEngin, idCaserne || '-' || codeTypeEngin || '-' || numero AS matricule " +
                        "FROM Engin e JOIN TypeEngin t ON t.code=e.codeTypeEngin " +
                        "WHERE idCaserne = " + choixCaserne;


                SQLiteDataAdapter adapter = new SQLiteDataAdapter(req, Connexion.Connec);

                adapter.Fill(MesDatas.DsGlobal, "TableDsEngin");

                //ajout d'une colonne pour le chemin de l'image, type imageObject
                MesDatas.DsGlobal.Tables["TableDsEngin"].Columns.Add("imageObject", typeof(Image));

                // AJout de l'image dans la colonne imageObject
                foreach (DataRow row in MesDatas.DsGlobal.Tables["TableDsEngin"].Rows)
                {
                    string code = row["codeTypeEngin"].ToString();
                    string cheminImage = Path.Combine("VehiculePompier", code + ".jpeg");

                    if (File.Exists(cheminImage))
                    {
                        using (var fs = new FileStream(cheminImage, FileMode.Open, FileAccess.Read))
                        {
                            row["imageObject"] = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        row["imageObject"] = null;
                    }
                }
                //pour afficher dsEngin, a supprimmer quand le volet est fini
                dgvTest.DataSource = MesDatas.DsGlobal.Tables["TableDsEngin"];

                    // MessageBox.Show("Requete apres fill : " + req);
                    // MessageBox.Show("\ndsEngin rows : " + MesDatas.DsGlobal.Tables["TableDsEngin"].Rows.Count.ToString());

                // Bindingue source
                bs1.DataSource = MesDatas.DsGlobal.Tables["TableDsEngin"];

                // gestion affichage de l'index
                bs1.Position = 0;
                lblIndex.Text = (bs1.Position+1).ToString() + "/" + (MesDatas.DsGlobal.Tables["TableDsEngin"].Rows.Count);

                //gestion de l'affichage de la date de reception
                lblDateReception.DataBindings.Clear();
                lblDateReception.DataBindings.Add("Text", bs1, "dateReception");

                //gestion de ckbEnMission
                ckbEnMission.DataBindings.Clear();
                ckbEnMission.DataBindings.Add("Checked", bs1, "enMission");

                //gestion de ckbEnPanne
                ckbEnPanne.DataBindings.Clear();
                ckbEnPanne.DataBindings.Add("Checked", bs1, "enPanne");

                //gestion image
                

                //Instanciation de la picture box 
                PictureBox pict = new PictureBox();
                pict.Location = new System.Drawing.Point(279, 19);
                pict.Size = new System.Drawing.Size(200, 133);
                pict.SizeMode = PictureBoxSizeMode.AutoSize;
                grbAffichage.Controls.Add(pict);
                pict.DataBindings.Clear();
                Binding binding = new Binding("Image", bs1, "imageObject");
                pict.DataBindings.Add(binding);

                // appel de la fonction qui fait l'affichage du matricule
                actualisMatricule();

            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur dsEngin : " + err.Message);
            }

        }

        private void cbxCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // quand on change la caserne, ca met à jour dsEngin
            chargeTabledsEngin();
        }


        ///////BOUTON
        private void button2_Click(object sender, EventArgs e)
        {
            bs1.MovePrevious();
            lblIndex.Text = (bs1.Position + 1).ToString() + "/" + MesDatas.DsGlobal.Tables["TableDsEngin"].Rows.Count;
            //actualisMatricule();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            bs1.MoveNext();
            lblIndex.Text = (bs1.Position + 1).ToString() + "/" + MesDatas.DsGlobal.Tables["TableDsEngin"].Rows.Count;
            //actualisMatricule();
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            bs1.MoveFirst();
            lblIndex.Text = (bs1.Position + 1).ToString() + "/" + MesDatas.DsGlobal.Tables["TableDsEngin"].Rows.Count;
            //actualisMatricule();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bs1.MoveLast();
            lblIndex.Text = (bs1.Position + 1).ToString() + "/" + MesDatas.DsGlobal.Tables["TableDsEngin"].Rows.Count;
            //actualisMatricule();
        }
        ///////
        
        void actualisMatricule()
        {
            lblMatricule.DataBindings.Clear();
            lblMatricule.DataBindings.Add("Text", bs1, "matricule");

        }

 
    }
}
