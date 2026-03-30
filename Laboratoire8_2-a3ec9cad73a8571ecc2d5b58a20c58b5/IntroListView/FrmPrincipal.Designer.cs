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
            this.lsvExemple = new System.Windows.Forms.ListView();
            this.clhCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCol3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCol4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPeuplerListView = new System.Windows.Forms.Button();
            this.btnAjouterUneLigneV3 = new System.Windows.Forms.Button();
            this.btnAfficherLigneSelectionnee = new System.Windows.Forms.Button();
            this.btnAjouterUneLigneV1 = new System.Windows.Forms.Button();
            this.btnAjouterUneLigneV2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvExemple
            // 
            this.lsvExemple.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCol1,
            this.clhCol2,
            this.clhCol3,
            this.clhCol4});
            this.lsvExemple.FullRowSelect = true;
            this.lsvExemple.HideSelection = false;
            this.lsvExemple.Location = new System.Drawing.Point(22, 23);
            this.lsvExemple.Name = "lsvExemple";
            this.lsvExemple.Size = new System.Drawing.Size(250, 273);
            this.lsvExemple.TabIndex = 0;
            this.lsvExemple.UseCompatibleStateImageBehavior = false;
            this.lsvExemple.View = System.Windows.Forms.View.Details;
            // 
            // clhCol1
            // 
            this.clhCol1.Text = "CA";
            // 
            // clhCol2
            // 
            this.clhCol2.Text = "C2";
            this.clhCol2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clhCol3
            // 
            this.clhCol3.Text = "C3";
            this.clhCol3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clhCol4
            // 
            this.clhCol4.Text = "C4";
            this.clhCol4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPeuplerListView
            // 
            this.btnPeuplerListView.Location = new System.Drawing.Point(291, 139);
            this.btnPeuplerListView.Name = "btnPeuplerListView";
            this.btnPeuplerListView.Size = new System.Drawing.Size(203, 23);
            this.btnPeuplerListView.TabIndex = 1;
            this.btnPeuplerListView.Text = "Peupler le ListView";
            this.btnPeuplerListView.UseVisualStyleBackColor = true;
            this.btnPeuplerListView.Click += new System.EventHandler(this.btnPeuplerListView_Click);
            // 
            // btnAjouterUneLigneV3
            // 
            this.btnAjouterUneLigneV3.Location = new System.Drawing.Point(291, 81);
            this.btnAjouterUneLigneV3.Name = "btnAjouterUneLigneV3";
            this.btnAjouterUneLigneV3.Size = new System.Drawing.Size(203, 23);
            this.btnAjouterUneLigneV3.TabIndex = 2;
            this.btnAjouterUneLigneV3.Text = "Ajouter une ligne V3";
            this.btnAjouterUneLigneV3.UseVisualStyleBackColor = true;
            this.btnAjouterUneLigneV3.Click += new System.EventHandler(this.btnAjouterUneLigneV3_Click);
            // 
            // btnAfficherLigneSelectionnee
            // 
            this.btnAfficherLigneSelectionnee.Location = new System.Drawing.Point(291, 110);
            this.btnAfficherLigneSelectionnee.Name = "btnAfficherLigneSelectionnee";
            this.btnAfficherLigneSelectionnee.Size = new System.Drawing.Size(203, 23);
            this.btnAfficherLigneSelectionnee.TabIndex = 3;
            this.btnAfficherLigneSelectionnee.Text = "Afficher l\'index de la ligne sélectionnée";
            this.btnAfficherLigneSelectionnee.UseVisualStyleBackColor = true;
            this.btnAfficherLigneSelectionnee.Click += new System.EventHandler(this.btnAfficherIndexLigneSelectionnee_Click);
            // 
            // btnAjouterUneLigneV1
            // 
            this.btnAjouterUneLigneV1.Location = new System.Drawing.Point(291, 23);
            this.btnAjouterUneLigneV1.Name = "btnAjouterUneLigneV1";
            this.btnAjouterUneLigneV1.Size = new System.Drawing.Size(203, 23);
            this.btnAjouterUneLigneV1.TabIndex = 4;
            this.btnAjouterUneLigneV1.Text = "Ajouter une ligne V1";
            this.btnAjouterUneLigneV1.UseVisualStyleBackColor = true;
            this.btnAjouterUneLigneV1.Click += new System.EventHandler(this.btnAjouterUneLigneV1_Click);
            // 
            // btnAjouterUneLigneV2
            // 
            this.btnAjouterUneLigneV2.Location = new System.Drawing.Point(291, 52);
            this.btnAjouterUneLigneV2.Name = "btnAjouterUneLigneV2";
            this.btnAjouterUneLigneV2.Size = new System.Drawing.Size(203, 23);
            this.btnAjouterUneLigneV2.TabIndex = 5;
            this.btnAjouterUneLigneV2.Text = "Ajouter une ligne V2";
            this.btnAjouterUneLigneV2.UseVisualStyleBackColor = true;
            this.btnAjouterUneLigneV2.Click += new System.EventHandler(this.btnAjouterUneLigneV2_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 314);
            this.Controls.Add(this.btnAjouterUneLigneV2);
            this.Controls.Add(this.btnAjouterUneLigneV1);
            this.Controls.Add(this.btnAfficherLigneSelectionnee);
            this.Controls.Add(this.btnAjouterUneLigneV3);
            this.Controls.Add(this.btnPeuplerListView);
            this.Controls.Add(this.lsvExemple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduction au ListView ";
            this.ResumeLayout(false);

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
