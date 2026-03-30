namespace ManipulerDates
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
            grpValeurSelectionnnee = new GroupBox();
            txtHeureFormattee = new TextBox();
            txtDateFormattee = new TextBox();
            lblHeure = new Label();
            lblDate = new Label();
            cboMoments = new ComboBox();
            grpDuree = new GroupBox();
            txtTotalSecondes = new TextBox();
            txtTotalMinutes = new TextBox();
            txtTotalHeures = new TextBox();
            txtTotalJours = new TextBox();
            txtSecondes = new TextBox();
            txtMinutes = new TextBox();
            txtHeures = new TextBox();
            txtJours = new TextBox();
            lblTotal = new Label();
            lblNombreDe = new Label();
            lblSec = new Label();
            lblMinutes = new Label();
            lblHrs = new Label();
            lblJour = new Label();
            dtpDateFin = new DateTimePicker();
            lblDateFin = new Label();
            txtDateDebut = new TextBox();
            lblDateDebut = new Label();
            grpValeurSelectionnnee.SuspendLayout();
            grpDuree.SuspendLayout();
            SuspendLayout();
            // 
            // grpValeurSelectionnnee
            // 
            grpValeurSelectionnnee.Controls.Add(txtHeureFormattee);
            grpValeurSelectionnnee.Controls.Add(txtDateFormattee);
            grpValeurSelectionnnee.Controls.Add(lblHeure);
            grpValeurSelectionnnee.Controls.Add(lblDate);
            grpValeurSelectionnnee.Controls.Add(cboMoments);
            grpValeurSelectionnnee.Location = new Point(12, 12);
            grpValeurSelectionnnee.Name = "grpValeurSelectionnnee";
            grpValeurSelectionnnee.Size = new Size(441, 118);
            grpValeurSelectionnnee.TabIndex = 0;
            grpValeurSelectionnnee.TabStop = false;
            grpValeurSelectionnnee.Text = "Calcul avec des dates";
            // 
            // txtHeureFormattee
            // 
            txtHeureFormattee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            txtHeureFormattee.Location = new Point(249, 78);
            txtHeureFormattee.Name = "txtHeureFormattee";
            txtHeureFormattee.ReadOnly = true;
            txtHeureFormattee.Size = new Size(173, 20);
            txtHeureFormattee.TabIndex = 2;
            // 
            // txtDateFormattee
            // 
            txtDateFormattee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            txtDateFormattee.Location = new Point(19, 78);
            txtDateFormattee.Name = "txtDateFormattee";
            txtDateFormattee.ReadOnly = true;
            txtDateFormattee.Size = new Size(178, 20);
            txtDateFormattee.TabIndex = 1;
            // 
            // lblHeure
            // 
            lblHeure.AutoSize = true;
            lblHeure.Location = new Point(246, 63);
            lblHeure.Name = "lblHeure";
            lblHeure.Size = new Size(131, 15);
            lblHeure.TabIndex = 5;
            lblHeure.Text = "Heure/minute/seconde";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(17, 63);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(98, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Année/mois/jour";
            // 
            // cboMoments
            // 
            cboMoments.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMoments.FormattingEnabled = true;
            cboMoments.Items.AddRange(new object[] { "Maintenant", "Aujourd'hui dans une heure", "Hier même heure", "Demain, une heure de plus", "Il y a 4 semaines (28 jours)", "Dans 2 mois", "Il y a 10 ans", "Dans 20 ans, même jour, même heure" });
            cboMoments.Location = new Point(19, 35);
            cboMoments.Name = "cboMoments";
            cboMoments.Size = new Size(404, 23);
            cboMoments.TabIndex = 0;
            cboMoments.SelectedIndexChanged += cboMoments_SelectedIndexChanged;
            // 
            // grpDuree
            // 
            grpDuree.Controls.Add(txtTotalSecondes);
            grpDuree.Controls.Add(txtTotalMinutes);
            grpDuree.Controls.Add(txtTotalHeures);
            grpDuree.Controls.Add(txtTotalJours);
            grpDuree.Controls.Add(txtSecondes);
            grpDuree.Controls.Add(txtMinutes);
            grpDuree.Controls.Add(txtHeures);
            grpDuree.Controls.Add(txtJours);
            grpDuree.Controls.Add(lblTotal);
            grpDuree.Controls.Add(lblNombreDe);
            grpDuree.Controls.Add(lblSec);
            grpDuree.Controls.Add(lblMinutes);
            grpDuree.Controls.Add(lblHrs);
            grpDuree.Controls.Add(lblJour);
            grpDuree.Controls.Add(dtpDateFin);
            grpDuree.Controls.Add(lblDateFin);
            grpDuree.Controls.Add(txtDateDebut);
            grpDuree.Controls.Add(lblDateDebut);
            grpDuree.Location = new Point(13, 147);
            grpDuree.Name = "grpDuree";
            grpDuree.Size = new Size(440, 173);
            grpDuree.TabIndex = 4;
            grpDuree.TabStop = false;
            grpDuree.Text = "Calcul de durées entre 2 dates";
            // 
            // txtTotalSecondes
            // 
            txtTotalSecondes.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtTotalSecondes.Location = new Point(340, 129);
            txtTotalSecondes.Name = "txtTotalSecondes";
            txtTotalSecondes.ReadOnly = true;
            txtTotalSecondes.Size = new Size(80, 20);
            txtTotalSecondes.TabIndex = 37;
            txtTotalSecondes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalMinutes
            // 
            txtTotalMinutes.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtTotalMinutes.Location = new Point(249, 129);
            txtTotalMinutes.Name = "txtTotalMinutes";
            txtTotalMinutes.ReadOnly = true;
            txtTotalMinutes.Size = new Size(80, 20);
            txtTotalMinutes.TabIndex = 36;
            txtTotalMinutes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalHeures
            // 
            txtTotalHeures.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtTotalHeures.Location = new Point(159, 129);
            txtTotalHeures.Name = "txtTotalHeures";
            txtTotalHeures.ReadOnly = true;
            txtTotalHeures.Size = new Size(80, 20);
            txtTotalHeures.TabIndex = 35;
            txtTotalHeures.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalJours
            // 
            txtTotalJours.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtTotalJours.Location = new Point(67, 129);
            txtTotalJours.Name = "txtTotalJours";
            txtTotalJours.ReadOnly = true;
            txtTotalJours.Size = new Size(80, 20);
            txtTotalJours.TabIndex = 34;
            txtTotalJours.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSecondes
            // 
            txtSecondes.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtSecondes.Location = new Point(340, 101);
            txtSecondes.Name = "txtSecondes";
            txtSecondes.ReadOnly = true;
            txtSecondes.Size = new Size(80, 20);
            txtSecondes.TabIndex = 33;
            txtSecondes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMinutes
            // 
            txtMinutes.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtMinutes.Location = new Point(249, 101);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.ReadOnly = true;
            txtMinutes.Size = new Size(80, 20);
            txtMinutes.TabIndex = 32;
            txtMinutes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtHeures
            // 
            txtHeures.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtHeures.Location = new Point(159, 101);
            txtHeures.Name = "txtHeures";
            txtHeures.ReadOnly = true;
            txtHeures.Size = new Size(80, 20);
            txtHeures.TabIndex = 31;
            txtHeures.TextAlign = HorizontalAlignment.Right;
            // 
            // txtJours
            // 
            txtJours.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtJours.Location = new Point(67, 101);
            txtJours.Name = "txtJours";
            txtJours.ReadOnly = true;
            txtJours.Size = new Size(80, 20);
            txtJours.TabIndex = 30;
            txtJours.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(9, 131);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 15);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "Total en : ";
            // 
            // lblNombreDe
            // 
            lblNombreDe.AutoSize = true;
            lblNombreDe.Location = new Point(9, 101);
            lblNombreDe.Name = "lblNombreDe";
            lblNombreDe.Size = new Size(58, 15);
            lblNombreDe.TabIndex = 24;
            lblNombreDe.Text = "Nbre de : ";
            // 
            // lblSec
            // 
            lblSec.AutoSize = true;
            lblSec.Location = new Point(337, 85);
            lblSec.Name = "lblSec";
            lblSec.Size = new Size(56, 15);
            lblSec.TabIndex = 23;
            lblSec.Text = "secondes";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(254, 85);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(50, 15);
            lblMinutes.TabIndex = 22;
            lblMinutes.Text = "minutes";
            // 
            // lblHrs
            // 
            lblHrs.AutoSize = true;
            lblHrs.Location = new Point(158, 85);
            lblHrs.Name = "lblHrs";
            lblHrs.Size = new Size(42, 15);
            lblHrs.TabIndex = 21;
            lblHrs.Text = "heures";
            // 
            // lblJour
            // 
            lblJour.AutoSize = true;
            lblJour.Location = new Point(66, 85);
            lblJour.Name = "lblJour";
            lblJour.Size = new Size(33, 15);
            lblJour.TabIndex = 15;
            lblJour.Text = "jours";
            // 
            // dtpDateFin
            // 
            dtpDateFin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpDateFin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dtpDateFin.Format = DateTimePickerFormat.Custom;
            dtpDateFin.Location = new Point(249, 47);
            dtpDateFin.Name = "dtpDateFin";
            dtpDateFin.Size = new Size(178, 20);
            dtpDateFin.TabIndex = 5;
            dtpDateFin.ValueChanged += dtpDateFin_ValueChanged;
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.Location = new Point(246, 31);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new Size(70, 15);
            lblDateFin.TabIndex = 7;
            lblDateFin.Text = "Date de fin :";
            // 
            // txtDateDebut
            // 
            txtDateDebut.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            txtDateDebut.Location = new Point(19, 47);
            txtDateDebut.Name = "txtDateDebut";
            txtDateDebut.ReadOnly = true;
            txtDateDebut.Size = new Size(178, 20);
            txtDateDebut.TabIndex = 1;
            txtDateDebut.Text = "2012-01-01 00:00:00";
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.Location = new Point(14, 31);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new Size(87, 15);
            lblDateDebut.TabIndex = 0;
            lblDateDebut.Text = "Date de début :";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 334);
            Controls.Add(grpDuree);
            Controls.Add(grpValeurSelectionnnee);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manipulation de dates";
            grpValeurSelectionnnee.ResumeLayout(false);
            grpValeurSelectionnnee.PerformLayout();
            grpDuree.ResumeLayout(false);
            grpDuree.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpValeurSelectionnnee;
        private ComboBox cboMoments;
        private Label lblDate;
        private TextBox txtHeureFormattee;
        private TextBox txtDateFormattee;
        private Label lblHeure;
        private GroupBox grpDuree;
        private DateTimePicker dtpDateFin;
        private Label lblDateFin;
        private TextBox txtDateDebut;
        private Label lblDateDebut;
        private Label lblSec;
        private Label lblMinutes;
        private Label lblHrs;
        private Label lblJour;
        private TextBox txtTotalSecondes;
        private TextBox txtTotalMinutes;
        private TextBox txtTotalHeures;
        private TextBox txtTotalJours;
        private TextBox txtSecondes;
        private TextBox txtMinutes;
        private TextBox txtHeures;
        private TextBox txtJours;
        private Label lblTotal;
        private Label lblNombreDe;
    }
}
