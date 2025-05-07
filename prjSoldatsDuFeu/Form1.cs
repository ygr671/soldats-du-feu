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

        }

    }
}
