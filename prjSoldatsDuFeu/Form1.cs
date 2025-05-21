using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UC_Mission;

namespace prjSoldatsDuFeu
{
    public partial class frmTableauDeBord : Form
    {
        SQLiteConnection cx = Connexion.Connec;

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

                MessageBox.Show(liste + "\nNombre de tables chargées : " + ds.Tables.Count.ToString());
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur SQLite : " + err.Message);
            }
        }


        public frmTableauDeBord()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Mission(int id_mission, string date, string caserne, string sinistre, string motif)
            // Instancier les UC mission ici

            for (int i = 0; i < 10; i++)
            {
                // int id_mission = Convert.ToInt32(MesDatas.DsGlobal.Tables["Mission"].Rows[i]["id"]);
                Mission m = new Mission(i, "Placeholder", "caserne", "sinistre", "motif");
                flpnlTDB.Controls.Add(m);
            }
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
    }
}
