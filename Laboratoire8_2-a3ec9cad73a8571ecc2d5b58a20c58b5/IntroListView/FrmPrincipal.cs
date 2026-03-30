namespace IntroListView
{
    public partial class FrmPrincipal : Form
    {
       

        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
        //=====================================================================================
        /// <summary>
        /// TODO 01 : Ajoute une ligne contenant le mot ALLO en 1ere colonne.
        /// </summary>
        /// ----------------------------------------------------------------------------------
        private void btnAjouterUneLigneV1_Click(object sender, EventArgs e)
        {
            ListViewItem ligne = new ListViewItem("Allo");
            lsvExemple.Items.Add(ligne);
        }
        //=====================================================================================
        /// <summary>
        /// TODO 02 : Ajoute une ligne contenant la chaîne "Ligne #x" en 1ere colonne.
        ///                - x représente le numéro (commence à 1) de la ligne où l'on est rendu dans la liste.
        /// </summary>
        /// ----------------------------------------------------------------------------------
        /// 
        private void btnAjouterUneLigneV2_Click(object sender, EventArgs e)
        {
            
            ListViewItem ligne = new ListViewItem($"ligne#{lsvExemple.Items.Count}");
            
            lsvExemple.Items.Add(ligne);
        }
        //============================================================================================
        /// <summary>
        /// TODO 03 : Ajoute une ligne contenant la chaîne "Ligne #x" en 1ere colonne.
        /// Les autres colonnes contiennent les chaines "info 2", "info 3" et "info 4".
        /// </summary>
        /// -----------------------------------------------------------------------------------------
        private void btnAjouterUneLigneV3_Click(object sender, EventArgs e)
        {
            ListViewItem ligne = new ListViewItem($"ligne#{lsvExemple.Items.Count}");
            ligne.SubItems.Add($"Info 1");
            ligne.SubItems.Add($"Info 2");
            ligne.SubItems.Add($"Info 3");


            lsvExemple.Items.Add(ligne);
        }
        //=====================================================================================
        /// <summary>
        /// TODO 04 : Affiche dans un message box, l'index de la ligne qui est présentement sélectionnée.
        ///          affiche -1 , si aucune n'est sélectionnée.
        /// </summary>
        /// ----------------------------------------------------------------------------------
        private void btnAfficherIndexLigneSelectionnee_Click(object sender, EventArgs e)
        {
            if (lsvExemple.SelectedIndices.Count > 0)
            {
                MessageBox.Show(lsvExemple.SelectedIndices[0].ToString());
            }
            
        }
        //=====================================================================================
        /// <summary>
        /// TODO 05 : Ajoute 9 lignes et des colonnes dans la listView comme ci-dessous:
        ///              L1:C1   L1:C2   L1:C3   L1:C4
        ///              L2:C1   L2:C2   L2:C3   L2:C4
        ///              ...
        ///              L9:C1   L9:C2   L9:C3   L9:C4
        /// </summary>
        /// ----------------------------------------------------------------------------------
        private void btnPeuplerListView_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                ListViewItem ligne = new ListViewItem($"L{lsvExemple.Items.Count+1}:C1");
                ligne.SubItems.Add($"L{lsvExemple.Items.Count + 1}:C2");
                ligne.SubItems.Add($"L{lsvExemple.Items.Count + 1}:C3");
                ligne.SubItems.Add($"L{lsvExemple.Items.Count + 1}:C4");

                lsvExemple.Items.Add(ligne);

            }



        }

        private void lsvExemple_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
