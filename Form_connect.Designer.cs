namespace Soluceapp_Csharp;

partial class Form_connect
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_connect));
        Btn_valide = new Button();
        Btn_nouveaucompte = new Button();
        btn_modifmp = new Button();
        fermeture = new Button();
        Saisie_util = new TextBox();
        Saisie_mp = new TextBox();
        label_util = new Label();
        label_mp = new Label();
        label_access = new Label();
        SuspendLayout();
        // 
        // Btn_valide
        // 
        Btn_valide.BackColor = Color.Purple;
        Btn_valide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Btn_valide.ForeColor = SystemColors.ButtonHighlight;
        Btn_valide.Location = new Point(123, 244);
        Btn_valide.Name = "Btn_valide";
        Btn_valide.Size = new Size(81, 40);
        Btn_valide.TabIndex = 8;
        Btn_valide.Text = "Acceder";
        Btn_valide.UseVisualStyleBackColor = false;
        Btn_valide.Click += Btn_valide_Click;
        // 
        // Btn_nouveaucompte
        // 
        Btn_nouveaucompte.BackColor = Color.Purple;
        Btn_nouveaucompte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Btn_nouveaucompte.ForeColor = SystemColors.ButtonHighlight;
        Btn_nouveaucompte.Location = new Point(262, 244);
        Btn_nouveaucompte.Name = "Btn_nouveaucompte";
        Btn_nouveaucompte.Size = new Size(160, 40);
        Btn_nouveaucompte.TabIndex = 9;
        Btn_nouveaucompte.Text = "Nouveau compte";
        Btn_nouveaucompte.UseVisualStyleBackColor = false;
        Btn_nouveaucompte.Click += Btn_nouveaucompte_Click;
        // 
        // btn_modifmp
        // 
        btn_modifmp.BackColor = Color.Purple;
        btn_modifmp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        btn_modifmp.ForeColor = SystemColors.ButtonHighlight;
        btn_modifmp.Location = new Point(428, 244);
        btn_modifmp.Name = "btn_modifmp";
        btn_modifmp.Size = new Size(213, 40);
        btn_modifmp.TabIndex = 10;
        btn_modifmp.Text = "Modifier le mot de passe";
        btn_modifmp.UseVisualStyleBackColor = false;
        // 
        // fermeture
        // 
        fermeture.BackColor = Color.Purple;
        fermeture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        fermeture.ForeColor = SystemColors.ButtonHighlight;
        fermeture.Location = new Point(676, 12);
        fermeture.Name = "fermeture";
        fermeture.Size = new Size(36, 31);
        fermeture.TabIndex = 11;
        fermeture.Text = "X";
        fermeture.UseVisualStyleBackColor = false;
        fermeture.Click += fermeture_Click;
        // 
        // Saisie_util
        // 
        Saisie_util.Location = new Point(370, 110);
        Saisie_util.Name = "Saisie_util";
        Saisie_util.Size = new Size(271, 23);
        Saisie_util.TabIndex = 12;
        // 
        // Saisie_mp
        // 
        Saisie_mp.Location = new Point(370, 148);
        Saisie_mp.Name = "Saisie_mp";
        Saisie_mp.PasswordChar = '*';
        Saisie_mp.Size = new Size(271, 23);
        Saisie_mp.TabIndex = 13;
        // 
        // label_util
        // 
        label_util.AutoSize = true;
        label_util.BackColor = SystemColors.ActiveCaptionText;
        label_util.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label_util.ForeColor = SystemColors.ButtonHighlight;
        label_util.Location = new Point(154, 110);
        label_util.Name = "label_util";
        label_util.Size = new Size(178, 25);
        label_util.TabIndex = 14;
        label_util.Text = "Utilisateur (ou mail)";
        // 
        // label_mp
        // 
        label_mp.AutoSize = true;
        label_mp.BackColor = SystemColors.ActiveCaptionText;
        label_mp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label_mp.ForeColor = SystemColors.ButtonHighlight;
        label_mp.Location = new Point(154, 148);
        label_mp.Name = "label_mp";
        label_mp.Size = new Size(124, 25);
        label_mp.TabIndex = 15;
        label_mp.Text = "Mot de passe";
        // 
        // label_access
        // 
        label_access.AutoSize = true;
        label_access.BackColor = SystemColors.ActiveCaptionText;
        label_access.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label_access.ForeColor = Color.FromArgb(255, 128, 128);
        label_access.Location = new Point(154, 194);
        label_access.Name = "label_access";
        label_access.Size = new Size(0, 21);
        label_access.TabIndex = 16;
        label_access.Visible = false;
        // 
        // Form_connect
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.fond1;
        ClientSize = new Size(724, 363);
        Controls.Add(label_access);
        Controls.Add(label_mp);
        Controls.Add(label_util);
        Controls.Add(Saisie_mp);
        Controls.Add(Saisie_util);
        Controls.Add(fermeture);
        Controls.Add(btn_modifmp);
        Controls.Add(Btn_nouveaucompte);
        Controls.Add(Btn_valide);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form_connect";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Soluceapp";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button Btn_valide;
    private Button Btn_nouveaucompte;
    private Button btn_modifmp;
    private Button fermeture;
    private TextBox Saisie_util;
    private TextBox Saisie_mp;
    private Label label_util;
    private Label label_mp;
    private Label label_access;
}