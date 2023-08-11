namespace Soluceapp_Csharp
{
    partial class Form_init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_init));
            titre = new Label();
            Btn_acces = new Button();
            label_bienvenue = new Label();
            fermeture = new Button();
            SuspendLayout();
            // 
            // titre
            // 
            titre.AutoSize = true;
            titre.BackColor = SystemColors.ActiveCaptionText;
            titre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titre.ForeColor = SystemColors.ButtonHighlight;
            titre.Location = new Point(223, 87);
            titre.Name = "titre";
            titre.Size = new Size(208, 32);
            titre.TabIndex = 6;
            titre.Text = "Soluceapp_Csharp";
            // 
            // Btn_acces
            // 
            Btn_acces.BackColor = Color.Purple;
            Btn_acces.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_acces.ForeColor = SystemColors.ButtonHighlight;
            Btn_acces.Location = new Point(289, 181);
            Btn_acces.Name = "Btn_acces";
            Btn_acces.Size = new Size(81, 40);
            Btn_acces.TabIndex = 7;
            Btn_acces.Text = "Acceder";
            Btn_acces.UseVisualStyleBackColor = false;
            Btn_acces.Click += Btn_acces_Click;
            // 
            // label_bienvenue
            // 
            label_bienvenue.AutoSize = true;
            label_bienvenue.BackColor = SystemColors.InactiveCaptionText;
            label_bienvenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_bienvenue.ForeColor = SystemColors.ButtonHighlight;
            label_bienvenue.Location = new Point(247, 142);
            label_bienvenue.Name = "label_bienvenue";
            label_bienvenue.Size = new Size(184, 21);
            label_bienvenue.TabIndex = 8;
            label_bienvenue.Text = "Bienvenue sur Soluceapp";
            // 
            // fermeture
            // 
            fermeture.BackColor = Color.Purple;
            fermeture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fermeture.ForeColor = SystemColors.ButtonHighlight;
            fermeture.Location = new Point(600, 12);
            fermeture.Name = "fermeture";
            fermeture.Size = new Size(36, 31);
            fermeture.TabIndex = 9;
            fermeture.Text = "X";
            fermeture.UseVisualStyleBackColor = false;
            fermeture.Click += fermeture_Click;
            // 
            // Form_init
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fond1;
            ClientSize = new Size(648, 326);
            Controls.Add(fermeture);
            Controls.Add(label_bienvenue);
            Controls.Add(Btn_acces);
            Controls.Add(titre);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_init";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soluceapp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titre;
        private Button Btn_acces;
        private Label label_bienvenue;
        private Button fermeture;
    }
}