namespace Soluceapp_Csharp
{
    partial class Form_activite1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_activite1));
            titre_activite1 = new Label();
            toolStripMenuItem1 = new ToolStripMenuItem();
            vérifierMesPointsToolStripMenuItem = new ToolStripMenuItem();
            seDéconnecterToolStripMenuItem1 = new ToolStripMenuItem();
            fermerLapplicationToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            laComptaFacileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // titre_activite1
            // 
            titre_activite1.AutoSize = true;
            titre_activite1.BackColor = SystemColors.ActiveCaptionText;
            titre_activite1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titre_activite1.ForeColor = SystemColors.ButtonHighlight;
            titre_activite1.Location = new Point(286, 109);
            titre_activite1.Name = "titre_activite1";
            titre_activite1.Size = new Size(187, 32);
            titre_activite1.TabIndex = 7;
            titre_activite1.Text = "La compta facile";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { vérifierMesPointsToolStripMenuItem, seDéconnecterToolStripMenuItem1, fermerLapplicationToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(54, 20);
            toolStripMenuItem1.Text = "Fichier";
            // 
            // vérifierMesPointsToolStripMenuItem
            // 
            vérifierMesPointsToolStripMenuItem.Name = "vérifierMesPointsToolStripMenuItem";
            vérifierMesPointsToolStripMenuItem.Size = new Size(179, 22);
            vérifierMesPointsToolStripMenuItem.Text = "Vérifier mes points";
            // 
            // seDéconnecterToolStripMenuItem1
            // 
            seDéconnecterToolStripMenuItem1.Name = "seDéconnecterToolStripMenuItem1";
            seDéconnecterToolStripMenuItem1.Size = new Size(179, 22);
            seDéconnecterToolStripMenuItem1.Text = "Se déconnecter";
            seDéconnecterToolStripMenuItem1.Click += seDéconnecterToolStripMenuItem1_Click;
            // 
            // fermerLapplicationToolStripMenuItem1
            // 
            fermerLapplicationToolStripMenuItem1.Name = "fermerLapplicationToolStripMenuItem1";
            fermerLapplicationToolStripMenuItem1.Size = new Size(179, 22);
            fermerLapplicationToolStripMenuItem1.Text = "Fermer l'application";
            fermerLapplicationToolStripMenuItem1.Click += fermerLapplicationToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { laComptaFacileToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(59, 20);
            toolStripMenuItem2.Text = "Activité";
            // 
            // laComptaFacileToolStripMenuItem
            // 
            laComptaFacileToolStripMenuItem.Name = "laComptaFacileToolStripMenuItem";
            laComptaFacileToolStripMenuItem.Size = new Size(168, 22);
            laComptaFacileToolStripMenuItem.Text = "Escompte et avoir";
            laComptaFacileToolStripMenuItem.Click += EscompteavoirMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form_activite1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fond1;
            ClientSize = new Size(804, 689);
            Controls.Add(titre_activite1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_activite1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soluceapp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label titre_activite1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem vérifierMesPointsToolStripMenuItem;
        private ToolStripMenuItem seDéconnecterToolStripMenuItem1;
        private ToolStripMenuItem fermerLapplicationToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem laComptaFacileToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}