using System.Windows.Forms;

namespace ManipulerDates
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            cboMoments.SelectedIndex = 0;
            CalculerDurees();
        }
        #region SelectedIndexChanged (À COMPLÉTER...)
        /// -------------------------------------------------------------------------------------------
        /// <summary>
        /// Dès que l'on sélectionne un choix dans la boîte combo,
        /// on modifie la date et on affiche la date en format yyyy-MM-dd et l'heure en format HH:mm:ss
        /// Valeur contenue dans la boîte combo:
        ///     0-Maintenant
        ///     1-Ajourd'hui, dans une heure
        ///     2-Hier, même heure
        ///     3-Demain, une heure de plus
        ///     4-Il y a 4 semaines (28 jours)
        ///     5-Dans 2 mois
        ///     6-Il y a 10 ans
        ///     7-Dans 20 ans, même jour, même heure
        /// </summary>
        /// --------------------------------------------------------------------------------------------
        private void cboMoments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cette variable contient la date actuelle, vous devez l'utiliser dans vos calculs
            DateTime dateAModifier = DateTime.Now;
            DateTime date = DateTime.Now;
            switch (cboMoments.SelectedIndex)
            {
                case 1: // TODO 01 : Aujourd'hui, dans une heure

                    date = dateAModifier.AddHours(1);

                    break;
                case 2: // TODO 02 : Hier, même heure
                    date = dateAModifier.AddDays(-1);
                    break;
                case 3: // TODO 03 : Demain, une heure de plus
                    date = dateAModifier.AddDays(1).AddHours(1);

                    break;
                case 4: // TODO 04 : Il y a 4 semaines (-28 jours)
                    date = dateAModifier.AddDays(-(4 * 7));
                    
                    break;
                case 5: // TODO 05 : Dans 2 mois
                    date = dateAModifier.AddMonths(2);

                    break;
                case 6: // TODO 06 : Il y a 10 ans
                    date = dateAModifier.AddYears(-10);

                    break;
                case 7: // TODO 07 : Dans 20 ans, même jour, même heure
                    date = dateAModifier.AddDays(20);
                    break;
            }

            // TODO 08 : Afficher la nouvelle date en respectant le format d'affichage de la démo
            txtDateFormattee.Text = date.ToString("d");
            txtHeureFormattee.Text = date.ToString("T");
        }
        #endregion

        #region CalculerDurees (À COMPLÉTER...)
        /// <summary>
        /// TODO 09 : Vous devez calculer et afficher l'intervalle de temps entre les deux dates (voir démo)
        /// </summary>
        private void CalculerDurees()
        {
            DateTime UneDate = DateTime.Parse(txtDateDebut.Text);

            TimeSpan Interval = DateTime.Now - UneDate;

            int nbJourComplets = Interval.Days;
            txtTotalJours.Text = nbJourComplets.ToString();
            double nbJour = Interval.TotalDays;
            txtJours.Text = nbJour.ToString();

            int nbHeuresComplets = Interval.Hours;
            txtTotalHeures.Text = nbHeuresComplets.ToString();
            double nbHeures = Interval.TotalHours;
            txtHeures.Text = nbHeures.ToString();

            int nbMinutesComplets = Interval.Minutes;
            txtTotalMinutes.Text = nbMinutesComplets.ToString();
            double nbMinutes = Interval.TotalMinutes;
            txtMinutes.Text = nbMinutes.ToString();

            int nbSecondsComplets = Interval.Seconds;
            txtTotalSecondes.Text = nbSecondsComplets.ToString();
            double nbSeconds = Interval.TotalSeconds;
            txtSecondes.Text = nbSeconds.ToString();

        }

        private void dtpDateFin_ValueChanged(object sender, EventArgs e)
        {
            CalculerDurees();
        }

        #endregion

    }
}
