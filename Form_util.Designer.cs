namespace Soluceapp_Csharp
{
    partial class Form_util
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_util));
            contextMenuStrip1 = new ContextMenuStrip(components);
            seDéconnecterToolStripMenuItem = new ToolStripMenuItem();
            fermerLapplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            vérifierMesPointsToolStripMenuItem = new ToolStripMenuItem();
            seDéconnecterToolStripMenuItem1 = new ToolStripMenuItem();
            fermerLapplicationToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            laComptaFacileToolStripMenuItem = new ToolStripMenuItem();
            avoirEtEscompteToolStripMenuItem = new ToolStripMenuItem();
            titre_util = new Label();
            label_showpts = new Label();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { seDéconnecterToolStripMenuItem, fermerLapplicationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(178, 48);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            seDéconnecterToolStripMenuItem.Size = new Size(177, 22);
            seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            // 
            // fermerLapplicationToolStripMenuItem
            // 
            fermerLapplicationToolStripMenuItem.Name = "fermerLapplicationToolStripMenuItem";
            fermerLapplicationToolStripMenuItem.Size = new Size(177, 22);
            fermerLapplicationToolStripMenuItem.Text = "fermer l'application";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(876, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
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
            vérifierMesPointsToolStripMenuItem.Click += vérifierMesPointsToolStripMenuItem_Click;
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
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { laComptaFacileToolStripMenuItem, avoirEtEscompteToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(59, 20);
            toolStripMenuItem2.Text = "Activité";
            // 
            // laComptaFacileToolStripMenuItem
            // 
            laComptaFacileToolStripMenuItem.Name = "laComptaFacileToolStripMenuItem";
            laComptaFacileToolStripMenuItem.Size = new Size(180, 22);
            laComptaFacileToolStripMenuItem.Text = "La compta facile";
            laComptaFacileToolStripMenuItem.Click += laComptaFacileToolStripMenuItem_Click;
            // 
            // avoirEtEscompteToolStripMenuItem
            // 
            avoirEtEscompteToolStripMenuItem.Name = "avoirEtEscompteToolStripMenuItem";
            avoirEtEscompteToolStripMenuItem.Size = new Size(180, 22);
            avoirEtEscompteToolStripMenuItem.Text = "Avoir et escompte";
            avoirEtEscompteToolStripMenuItem.Click += avoirEtEscompteToolStripMenuItem_Click;
            // 
            // titre_util
            // 
            titre_util.AutoSize = true;
            titre_util.BackColor = SystemColors.ActiveCaptionText;
            titre_util.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titre_util.ForeColor = SystemColors.ButtonHighlight;
            titre_util.Location = new Point(315, 106);
            titre_util.Name = "titre_util";
            titre_util.Size = new Size(268, 32);
            titre_util.TabIndex = 7;
            titre_util.Text = "Choisissez votre activité";
            // 
            // label_showpts
            // 
            label_showpts.AutoSize = true;
            label_showpts.BackColor = SystemColors.ActiveCaptionText;
            label_showpts.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_showpts.ForeColor = SystemColors.ButtonHighlight;
            label_showpts.Location = new Point(173, 215);
            label_showpts.Name = "label_showpts";
            label_showpts.Size = new Size(275, 25);
            label_showpts.TabIndex = 8;
            label_showpts.Text = "Votre nombre de points est de :";
            // 
            // Form_util
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fond1;
            ClientSize = new Size(876, 602);
            Controls.Add(label_showpts);
            Controls.Add(titre_util);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form_util";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soluceapp";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private ToolStripMenuItem fermerLapplicationToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem vérifierMesPointsToolStripMenuItem;
        private ToolStripMenuItem seDéconnecterToolStripMenuItem1;
        private ToolStripMenuItem fermerLapplicationToolStripMenuItem1;
        private ToolStripMenuItem laComptaFacileToolStripMenuItem;
        private ToolStripMenuItem avoirEtEscompteToolStripMenuItem;
        private Label titre_util;
        private Label label_showpts;
    }
}