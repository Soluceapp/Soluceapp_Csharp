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
    public partial class Form_activite1 : Form
    {
        public Form_activite1()
        {
            InitializeComponent();
            titre_activite1.BackColor = System.Drawing.Color.Transparent;
        }


        private void seDéconnecterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_connect form_connect = new Form_connect();
            form_connect.Show();
            this.Close();
        }

        private void fermerLapplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void EscompteavoirMenuItem1_Click(object sender, EventArgs e)
        {
            Form_activite2 form_activite2 = new Form_activite2();
            form_activite2.Show();
            this.Close();
        }
    }
}
