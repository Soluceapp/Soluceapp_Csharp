using System.Diagnostics;

namespace Soluceapp_Csharp
{
  
    public partial class Form_init : Form
    {

        public Form_init()
        {
            InitializeComponent();
            titre.BackColor = System.Drawing.Color.Transparent;
            label_bienvenue.BackColor = System.Drawing.Color.Transparent;
        }

        private void Btn_acces_Click(object sender, EventArgs e)
        {
            Form_connect form_connect = new Form_connect();
            form_connect.Show();
            this.Hide();
        }
        private void fermeture_Click(object sender, EventArgs e) => Application.Exit();

        
    }
}
