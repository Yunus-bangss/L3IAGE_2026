using System.Data;   /// Nécessaire pour DataTable.Compute
namespace CalcApp
{
    public partial class Calculatrice : Form

    {
        // Variables pour gérer les calculs et il stocke le calcul actuel
        private string calculatriceActuelle = "";
       

        public Calculatrice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            /// Récupère le bouton cliqué et ajoute son texte à l'expression actuelle
            Button btn = (Button)sender;
            calculatriceActuelle += btn.Text;
            textBox.Text = calculatriceActuelle;
        }
        private void btn_Egale_Click(object sender, EventArgs e) 
        {
            string calculFormate = calculatriceActuelle.ToString();
            try
            {
                /// Utilisation de DataTable.Compute pour évaluer l'expression mathématique 
                var resultat = new DataTable().Compute(calculFormate, null);
                textBox.Text = resultat.ToString();
                calculatriceActuelle = textBox.Text;
            }
            /// Gestion des erreurs de calcul
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de calcul : " + ex.Message);
            }
        }

        private void btn_Effacer_Click(object sender, EventArgs e)
        {
            /// Réinitialise la calculatrice
            calculatriceActuelle = "";
            textBox.Text = "0";
        }
        private void btn_effacerEntrer_Click(object sender, EventArgs e)
        {
            
           if(calculatriceActuelle.Length > 0)
            {
                calculatriceActuelle = calculatriceActuelle.Remove(calculatriceActuelle.Length - 1,1); ///Supprime le dernier caractère entré
            }
            textBox.Text = calculatriceActuelle;
        }


    }
}
