namespace Montre
{
    public partial class FrmPrincipal : Form
    {
        //====================================================
        //	CHAMPS: variable membre de la classe FrmPrincipal
        private Montre m_objMontre = null!;

        //==================================
        public FrmPrincipal()
        {
            InitializeComponent();

            //--------------------------------------------------------------------------------- 
            //Instancier un objet montre à 9:05:42 avec le constructeur à 3 paramètres

            m_objMontre = new Montre(9, 5, 42);
            txtAffichageMontre.Text = m_objMontre.AfficherHeure();
        }

        //============================================================================
        // Evénement associé au tick de l'horloge.
        // À chaque tick, on avance d'une seconde.
        private void btnAvancer_Click(object sender, System.EventArgs e)
        {
            m_objMontre.AvancerUneSeconde();
            txtAffichageMontre.Text = m_objMontre.AfficherHeure();
        }

        //============================================================================
        // Rendre disponible ou non l'horloge
        private void btnDemarrerArreterHorloge_Click(object sender, System.EventArgs e)
        {
            tmrHorloge.Enabled = !tmrHorloge.Enabled;
        }

        //============================================================================
        // Remettre la montre à 23 hr, 59 min et 55 sec
        private void btnInitialiserMontre_Click(object sender, System.EventArgs e)
        {
            m_objMontre.Initialiser(23, 59, 55);

            txtAffichageMontre.Text = m_objMontre.AfficherHeure();
        }
        //============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

    }
}
