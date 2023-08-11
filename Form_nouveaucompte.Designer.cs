namespace Soluceapp_Csharp
{
    partial class Form_nouveaucompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_nouveaucompte));
            titre_nouveau = new Label();
            fermeture = new Button();
            Btn_valide = new Button();
            label_mp = new Label();
            label_mail = new Label();
            Saisie_mp = new TextBox();
            Saisie_util = new TextBox();
            Indication = new Label();
            SuspendLayout();
            // 
            // titre_nouveau
            // 
            titre_nouveau.AutoSize = true;
            titre_nouveau.BackColor = SystemColors.ActiveCaptionText;
            titre_nouveau.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titre_nouveau.ForeColor = SystemColors.ButtonHighlight;
            titre_nouveau.Location = new Point(306, 86);
            titre_nouveau.Name = "titre_nouveau";
            titre_nouveau.Size = new Size(347, 32);
            titre_nouveau.TabIndex = 7;
            titre_nouveau.Text = "Création d'un nouveau compte";
            titre_nouveau.Click += titre_Click;
            // 
            // fermeture
            // 
            fermeture.BackColor = Color.Purple;
            fermeture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fermeture.ForeColor = SystemColors.ButtonHighlight;
            fermeture.Location = new Point(752, 12);
            fermeture.Name = "fermeture";
            fermeture.Size = new Size(36, 31);
            fermeture.TabIndex = 12;
            fermeture.Text = "X";
            fermeture.UseVisualStyleBackColor = false;
            // 
            // Btn_valide
            // 
            Btn_valide.BackColor = Color.Purple;
            Btn_valide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_valide.ForeColor = SystemColors.ButtonHighlight;
            Btn_valide.Location = new Point(356, 326);
            Btn_valide.Name = "Btn_valide";
            Btn_valide.Size = new Size(182, 40);
            Btn_valide.TabIndex = 13;
            Btn_valide.Text = "Confirmer par mail";
            Btn_valide.UseVisualStyleBackColor = false;
            // 
            // label_mp
            // 
            label_mp.AutoSize = true;
            label_mp.BackColor = SystemColors.ActiveCaptionText;
            label_mp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_mp.ForeColor = SystemColors.ButtonHighlight;
            label_mp.Location = new Point(181, 218);
            label_mp.Name = "label_mp";
            label_mp.Size = new Size(124, 25);
            label_mp.TabIndex = 19;
            label_mp.Text = "Mot de passe";
            // 
            // label_mail
            // 
            label_mail.AutoSize = true;
            label_mail.BackColor = SystemColors.ActiveCaptionText;
            label_mail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_mail.ForeColor = SystemColors.ButtonHighlight;
            label_mail.Location = new Point(181, 169);
            label_mail.Name = "label_mail";
            label_mail.Size = new Size(98, 25);
            label_mail.TabIndex = 18;
            label_mail.Text = "Votre mail";
            // 
            // Saisie_mp
            // 
            Saisie_mp.Location = new Point(356, 218);
            Saisie_mp.Name = "Saisie_mp";
            Saisie_mp.Size = new Size(271, 23);
            Saisie_mp.TabIndex = 17;
            // 
            // Saisie_util
            // 
            Saisie_util.Location = new Point(356, 171);
            Saisie_util.Name = "Saisie_util";
            Saisie_util.Size = new Size(271, 23);
            Saisie_util.TabIndex = 16;
            // 
            // Indication
            // 
            Indication.AutoSize = true;
            Indication.BackColor = SystemColors.ActiveCaptionText;
            Indication.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Indication.ForeColor = SystemColors.ButtonHighlight;
            Indication.Location = new Point(181, 276);
            Indication.Name = "Indication";
            Indication.Size = new Size(534, 21);
            Indication.TabIndex = 20;
            Indication.Text = "Mot de passe : 12 caractères minimum, 1 majuscule et minuscule minimum.";
            // 
            // Form_nouveaucompte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fond1;
            ClientSize = new Size(800, 450);
            Controls.Add(Indication);
            Controls.Add(label_mp);
            Controls.Add(label_mail);
            Controls.Add(Saisie_mp);
            Controls.Add(Saisie_util);
            Controls.Add(Btn_valide);
            Controls.Add(fermeture);
            Controls.Add(titre_nouveau);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_nouveaucompte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soluceapp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titre_nouveau;
        private Button fermeture;
        private Button Btn_valide;
        private Label label_mp;
        private Label label_mail;
        private TextBox Saisie_mp;
        private TextBox Saisie_util;
        private Label Indication;
    }
}