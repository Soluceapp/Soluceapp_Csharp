using System.Diagnostics;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;


namespace Soluceapp_Csharp
{

    public partial class Form_connect : Form
    {

        public Form_connect()
        {
            InitializeComponent();
            label_util.BackColor = System.Drawing.Color.Transparent;
            label_mp.BackColor = System.Drawing.Color.Transparent;
            label_access.BackColor = System.Drawing.Color.Transparent;
        }

        private void Btn_valider_click(object sender, EventArgs e) { MessageBox.Show("Hello"); }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void Btn_nouveaucompte_Click(object sender, EventArgs e)
        {
            Form_admin form_admin = new Form_admin();
            form_admin.Show();
            this.Close();
        }


        private void fermeture_Click(object sender, EventArgs e) => Application.Exit();

        private void Btn_valide_Click(object sender, EventArgs e)
        {
         /*   string ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Expertom\source\repos\Soluceapp_Csharp\Soluceapp_Csharp\registration.mdf;Integrated Security=True;Connect Timeout=30";
              SqlConnection con = new SqlConnection(ConnectionString);
              con.Open();
            string dutil = Saisie_util.Text; string dmp = Saisie_mp.Text; 
           string Query = "SELECT * FROM registre";
          SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();*/

            if (dutil == "test" && dmp == "test") { Form_util form_util = new Form_util(); form_util.Show(); this.Close(); }
            if (dutil == "vervisct" && dmp == "19711007@") { Form_admin form_admin = new Form_admin(); form_admin.Show(); this.Close(); }
            else if (dutil.Length == 0 || dmp.Length == 0) { label_access.Visible = true; label_access.Text = "Nom d'utilisateur ou mot de passe non indiqué."; }
            else if (dmp.Length < 12 && dmp.Length != 0) { label_access.Visible = true; label_access.Text = "Votre mot de passe n'est pas conforme."; }
            else { label_access.Visible = true; label_access.Text = "Nom d'utilisateur ou mot de passe incorrect."; }
        }
    }
}
