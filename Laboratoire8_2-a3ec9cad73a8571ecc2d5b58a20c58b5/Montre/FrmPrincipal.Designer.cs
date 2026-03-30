namespace Montre
{
    partial class FrmPrincipal
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
            txtAffichageMontre = new TextBox();
            btnAvancer = new Button();
            tmrHorloge = new System.Windows.Forms.Timer(components);
            btnDemarrerArreterHorloge = new Button();
            btnInitialiserMontre = new Button();
            mnuPrincipal = new MenuStrip();
            mnuFichier = new ToolStripMenuItem();
            mnuFichierQuitter = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // txtAffichageMontre
            // 
            txtAffichageMontre.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAffichageMontre.Location = new Point(44, 57);
            txtAffichageMontre.Name = "txtAffichageMontre";
            txtAffichageMontre.ReadOnly = true;
            txtAffichageMontre.Size = new Size(268, 31);
            txtAffichageMontre.TabIndex = 0;
            txtAffichageMontre.TabStop = false;
            txtAffichageMontre.Text = "0:00:00";
            txtAffichageMontre.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAvancer
            // 
            btnAvancer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancer.Location = new Point(43, 108);
            btnAvancer.Name = "btnAvancer";
            btnAvancer.Size = new Size(268, 40);
            btnAvancer.TabIndex = 1;
            btnAvancer.Text = "Avancer d'une seconde";
            btnAvancer.Click += btnAvancer_Click;
            // 
            // tmrHorloge
            // 
            tmrHorloge.Interval = 1000;
            tmrHorloge.Tick += btnAvancer_Click;
            // 
            // btnDemarrerArreterHorloge
            // 
            btnDemarrerArreterHorloge.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDemarrerArreterHorloge.Location = new Point(43, 217);
            btnDemarrerArreterHorloge.Name = "btnDemarrerArreterHorloge";
            btnDemarrerArreterHorloge.Size = new Size(268, 39);
            btnDemarrerArreterHorloge.TabIndex = 3;
            btnDemarrerArreterHorloge.Text = "Démarrer/Arrêter";
            btnDemarrerArreterHorloge.Click += btnDemarrerArreterHorloge_Click;
            // 
            // btnInitialiserMontre
            // 
            btnInitialiserMontre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInitialiserMontre.Location = new Point(43, 162);
            btnInitialiserMontre.Name = "btnInitialiserMontre";
            btnInitialiserMontre.Size = new Size(268, 40);
            btnInitialiserMontre.TabIndex = 2;
            btnInitialiserMontre.Text = "Initialiser à 23:59:55";
            btnInitialiserMontre.Click += btnInitialiserMontre_Click;
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { mnuFichier });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(342, 24);
            mnuPrincipal.TabIndex = 4;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            mnuFichier.DropDownItems.AddRange(new ToolStripItem[] { mnuFichierQuitter });
            mnuFichier.Name = "mnuFichier";
            mnuFichier.Size = new Size(54, 20);
            mnuFichier.Text = "Fichier";
            // 
            // mnuFichierQuitter
            // 
            mnuFichierQuitter.Name = "mnuFichierQuitter";
            mnuFichierQuitter.ShortcutKeys = Keys.Control | Keys.Q;
            mnuFichierQuitter.Size = new Size(154, 22);
            mnuFichierQuitter.Text = "&Quitter";
            mnuFichierQuitter.Click += mnuFichierQuitter_Click;
            // 
            // FrmPrincipal
            // 
            AcceptButton = btnAvancer;
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(342, 276);
            Controls.Add(btnInitialiserMontre);
            Controls.Add(btnDemarrerArreterHorloge);
            Controls.Add(btnAvancer);
            Controls.Add(txtAffichageMontre);
            Controls.Add(mnuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mnuPrincipal;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToString ";
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox txtAffichageMontre;
        private System.Windows.Forms.Button btnAvancer;
        private System.Windows.Forms.Timer tmrHorloge;
        private System.Windows.Forms.Button btnDemarrerArreterHorloge;
        private System.Windows.Forms.Button btnInitialiserMontre;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
    }
}

