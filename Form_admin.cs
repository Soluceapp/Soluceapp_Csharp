using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soluceapp_Csharp
{
    public partial class Form_admin : Form
    {

        public Form_admin()
        {
            InitializeComponent();
            titre_admin.BackColor = System.Drawing.Color.Transparent;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void seDéconnecterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_connect form_connect = new Form_connect();
            form_connect.Show();
            this.Close();
        }

        private void laComptaFacileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void avoirEtEscompteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supprimerUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testDadministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fermerLapplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
