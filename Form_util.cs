namespace Soluceapp_Csharp
{
    public partial class Form_util : Form
    {
        public Form_util()
        {
            InitializeComponent();
            titre_util.BackColor = System.Drawing.Color.Transparent;
            label_showpts.BackColor = System.Drawing.Color.Transparent;
        }


        private void seDéconnecterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_connect form_connect = new Form_connect();
            form_connect.Show();
            this.Close();
        }

        private void laComptaFacileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_activite1 form_activite1 = new Form_activite1();
            form_activite1.Show();
            this.Close();
        }

        private void fermerLapplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void avoirEtEscompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_activite2 form_activite2 = new Form_activite2();
            form_activite2.Show();
            this.Close();
        }

        private void vérifierMesPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_util form_util = new Form_util();
            form_util.Show();
            this.Close();
        }
    }
}