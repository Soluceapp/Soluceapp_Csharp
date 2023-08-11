namespace Soluceapp_Csharp
{
    partial class Form_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_admin));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            seDéconnecterToolStripMenuItem1 = new ToolStripMenuItem();
            fermerLapplicationToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            laComptaFacileToolStripMenuItem = new ToolStripMenuItem();
            avoirEtEscompteToolStripMenuItem = new ToolStripMenuItem();
            modifierUnUtilisateurToolStripMenuItem = new ToolStripMenuItem();
            supprimerUnUtilisateurToolStripMenuItem = new ToolStripMenuItem();
            testDadministrationToolStripMenuItem = new ToolStripMenuItem();
            titre_admin = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { seDéconnecterToolStripMenuItem1, fermerLapplicationToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(54, 20);
            toolStripMenuItem1.Text = "Fichier";
            // 
            // seDéconnecterToolStripMenuItem1
            // 
            seDéconnecterToolStripMenuItem1.Name = "seDéconnecterToolStripMenuItem1";
            seDéconnecterToolStripMenuItem1.Size = new Size(180, 22);
            seDéconnecterToolStripMenuItem1.Text = "Se déconnecter";
            seDéconnecterToolStripMenuItem1.Click += seDéconnecterToolStripMenuItem1_Click;
            // 
            // fermerLapplicationToolStripMenuItem1
            // 
            fermerLapplicationToolStripMenuItem1.Name = "fermerLapplicationToolStripMenuItem1";
            fermerLapplicationToolStripMenuItem1.Size = new Size(180, 22);
            fermerLapplicationToolStripMenuItem1.Text = "Fermer l'application";
            fermerLapplicationToolStripMenuItem1.Click += fermerLapplicationToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { laComptaFacileToolStripMenuItem, avoirEtEscompteToolStripMenuItem, modifierUnUtilisateurToolStripMenuItem, supprimerUnUtilisateurToolStripMenuItem, testDadministrationToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(98, 20);
            toolStripMenuItem2.Text = "Administration";
            // 
            // laComptaFacileToolStripMenuItem
            // 
            laComptaFacileToolStripMenuItem.Name = "laComptaFacileToolStripMenuItem";
            laComptaFacileToolStripMenuItem.Size = new Size(201, 22);
            laComptaFacileToolStripMenuItem.Text = "Liste des utilisateurs";
            laComptaFacileToolStripMenuItem.Click += laComptaFacileToolStripMenuItem_Click;
            // 
            // avoirEtEscompteToolStripMenuItem
            // 
            avoirEtEscompteToolStripMenuItem.Name = "avoirEtEscompteToolStripMenuItem";
            avoirEtEscompteToolStripMenuItem.Size = new Size(201, 22);
            avoirEtEscompteToolStripMenuItem.Text = "Créer un utilisateur";
            avoirEtEscompteToolStripMenuItem.Click += avoirEtEscompteToolStripMenuItem_Click;
            // 
            // modifierUnUtilisateurToolStripMenuItem
            // 
            modifierUnUtilisateurToolStripMenuItem.Name = "modifierUnUtilisateurToolStripMenuItem";
            modifierUnUtilisateurToolStripMenuItem.Size = new Size(201, 22);
            modifierUnUtilisateurToolStripMenuItem.Text = "Modifier un utilisateur";
            modifierUnUtilisateurToolStripMenuItem.Click += modifierUnUtilisateurToolStripMenuItem_Click;
            // 
            // supprimerUnUtilisateurToolStripMenuItem
            // 
            supprimerUnUtilisateurToolStripMenuItem.Name = "supprimerUnUtilisateurToolStripMenuItem";
            supprimerUnUtilisateurToolStripMenuItem.Size = new Size(201, 22);
            supprimerUnUtilisateurToolStripMenuItem.Text = "Supprimer un utilisateur";
            supprimerUnUtilisateurToolStripMenuItem.Click += supprimerUnUtilisateurToolStripMenuItem_Click;
            // 
            // testDadministrationToolStripMenuItem
            // 
            testDadministrationToolStripMenuItem.Name = "testDadministrationToolStripMenuItem";
            testDadministrationToolStripMenuItem.Size = new Size(201, 22);
            testDadministrationToolStripMenuItem.Text = "Test d'administration";
            testDadministrationToolStripMenuItem.Click += testDadministrationToolStripMenuItem_Click;
            // 
            // titre_admin
            // 
            titre_admin.AutoSize = true;
            titre_admin.BackColor = SystemColors.ActiveCaptionText;
            titre_admin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titre_admin.ForeColor = SystemColors.ButtonHighlight;
            titre_admin.Location = new Point(300, 75);
            titre_admin.Name = "titre_admin";
            titre_admin.Size = new Size(268, 32);
            titre_admin.TabIndex = 8;
            titre_admin.Text = "Interface administrateur";
            // 
            // Form_admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fond1;
            ClientSize = new Size(800, 450);
            Controls.Add(titre_admin);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soluceapp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem seDéconnecterToolStripMenuItem1;
        private ToolStripMenuItem fermerLapplicationToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem laComptaFacileToolStripMenuItem;
        private ToolStripMenuItem avoirEtEscompteToolStripMenuItem;
        private Label titre_admin;
        private ToolStripMenuItem modifierUnUtilisateurToolStripMenuItem;
        private ToolStripMenuItem supprimerUnUtilisateurToolStripMenuItem;
        private ToolStripMenuItem testDadministrationToolStripMenuItem;
    }
}