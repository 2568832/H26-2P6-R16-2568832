namespace IntroListView
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
            lsvExemple = new ListView();
            clhCol1 = new ColumnHeader();
            clhCol2 = new ColumnHeader();
            clhCol3 = new ColumnHeader();
            clhCol4 = new ColumnHeader();
            btnPeuplerListView = new Button();
            btnAjouterUneLigneV3 = new Button();
            btnAfficherLigneSelectionnee = new Button();
            btnAjouterUneLigneV1 = new Button();
            btnAjouterUneLigneV2 = new Button();
            SuspendLayout();
            // 
            // lsvExemple
            // 
            lsvExemple.Columns.AddRange(new ColumnHeader[] { clhCol1, clhCol2, clhCol3, clhCol4 });
            lsvExemple.FullRowSelect = true;
            lsvExemple.Location = new Point(26, 27);
            lsvExemple.Margin = new Padding(4, 3, 4, 3);
            lsvExemple.Name = "lsvExemple";
            lsvExemple.Size = new Size(291, 314);
            lsvExemple.TabIndex = 0;
            lsvExemple.UseCompatibleStateImageBehavior = false;
            lsvExemple.View = View.Details;
            lsvExemple.SelectedIndexChanged += lsvExemple_SelectedIndexChanged;
            // 
            // clhCol1
            // 
            clhCol1.Text = "CA";
            clhCol1.Width = 100;
            // 
            // clhCol2
            // 
            clhCol2.Text = "C2";
            clhCol2.TextAlign = HorizontalAlignment.Center;
            // 
            // clhCol3
            // 
            clhCol3.Text = "C3";
            clhCol3.TextAlign = HorizontalAlignment.Center;
            // 
            // clhCol4
            // 
            clhCol4.Text = "C4";
            clhCol4.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPeuplerListView
            // 
            btnPeuplerListView.Location = new Point(340, 160);
            btnPeuplerListView.Margin = new Padding(4, 3, 4, 3);
            btnPeuplerListView.Name = "btnPeuplerListView";
            btnPeuplerListView.Size = new Size(237, 27);
            btnPeuplerListView.TabIndex = 1;
            btnPeuplerListView.Text = "Peupler le ListView";
            btnPeuplerListView.UseVisualStyleBackColor = true;
            btnPeuplerListView.Click += btnPeuplerListView_Click;
            // 
            // btnAjouterUneLigneV3
            // 
            btnAjouterUneLigneV3.Location = new Point(340, 93);
            btnAjouterUneLigneV3.Margin = new Padding(4, 3, 4, 3);
            btnAjouterUneLigneV3.Name = "btnAjouterUneLigneV3";
            btnAjouterUneLigneV3.Size = new Size(237, 27);
            btnAjouterUneLigneV3.TabIndex = 2;
            btnAjouterUneLigneV3.Text = "Ajouter une ligne V3";
            btnAjouterUneLigneV3.UseVisualStyleBackColor = true;
            btnAjouterUneLigneV3.Click += btnAjouterUneLigneV3_Click;
            // 
            // btnAfficherLigneSelectionnee
            // 
            btnAfficherLigneSelectionnee.Location = new Point(340, 127);
            btnAfficherLigneSelectionnee.Margin = new Padding(4, 3, 4, 3);
            btnAfficherLigneSelectionnee.Name = "btnAfficherLigneSelectionnee";
            btnAfficherLigneSelectionnee.Size = new Size(237, 27);
            btnAfficherLigneSelectionnee.TabIndex = 3;
            btnAfficherLigneSelectionnee.Text = "Afficher l'index de la ligne sélectionnée";
            btnAfficherLigneSelectionnee.UseVisualStyleBackColor = true;
            btnAfficherLigneSelectionnee.Click += btnAfficherIndexLigneSelectionnee_Click;
            // 
            // btnAjouterUneLigneV1
            // 
            btnAjouterUneLigneV1.Location = new Point(340, 27);
            btnAjouterUneLigneV1.Margin = new Padding(4, 3, 4, 3);
            btnAjouterUneLigneV1.Name = "btnAjouterUneLigneV1";
            btnAjouterUneLigneV1.Size = new Size(237, 27);
            btnAjouterUneLigneV1.TabIndex = 4;
            btnAjouterUneLigneV1.Text = "Ajouter une ligne V1";
            btnAjouterUneLigneV1.UseVisualStyleBackColor = true;
            btnAjouterUneLigneV1.Click += btnAjouterUneLigneV1_Click;
            // 
            // btnAjouterUneLigneV2
            // 
            btnAjouterUneLigneV2.Location = new Point(340, 60);
            btnAjouterUneLigneV2.Margin = new Padding(4, 3, 4, 3);
            btnAjouterUneLigneV2.Name = "btnAjouterUneLigneV2";
            btnAjouterUneLigneV2.Size = new Size(237, 27);
            btnAjouterUneLigneV2.TabIndex = 5;
            btnAjouterUneLigneV2.Text = "Ajouter une ligne V2";
            btnAjouterUneLigneV2.UseVisualStyleBackColor = true;
            btnAjouterUneLigneV2.Click += btnAjouterUneLigneV2_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 362);
            Controls.Add(btnAjouterUneLigneV2);
            Controls.Add(btnAjouterUneLigneV1);
            Controls.Add(btnAfficherLigneSelectionnee);
            Controls.Add(btnAjouterUneLigneV3);
            Controls.Add(btnPeuplerListView);
            Controls.Add(lsvExemple);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Introduction au ListView ";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvExemple;
        private System.Windows.Forms.ColumnHeader clhCol1;
        private System.Windows.Forms.ColumnHeader clhCol2;
        private System.Windows.Forms.ColumnHeader clhCol3;
        private System.Windows.Forms.ColumnHeader clhCol4;
        private System.Windows.Forms.Button btnPeuplerListView;
        private System.Windows.Forms.Button btnAjouterUneLigneV3;
        private System.Windows.Forms.Button btnAfficherLigneSelectionnee;
        private System.Windows.Forms.Button btnAjouterUneLigneV1;
        private System.Windows.Forms.Button btnAjouterUneLigneV2;
    }
}
