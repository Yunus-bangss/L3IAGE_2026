using System.Data;   
namespace CalcApp
{
    public partial class Calculatrice : Form

    {
        // Variables pour gérer les calculs
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
            Button btn = (Button)sender;
            calculatriceActuelle += btn.Text;
            textBox.Text = calculatriceActuelle;
        }
        private void btnEgal_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_Egale_Click(object sender, EventArgs e) 
        {
            string calculFormate = calculatriceActuelle.ToString();
            try
            {
                var resultat = new DataTable().Compute(calculFormate, null);
                textBox.Text = resultat.ToString();
                calculatriceActuelle = textBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de calcul : " + ex.Message);
            }
        }

        private void btn_Effacer_Click(object sender, EventArgs e)
        {
            calculatriceActuelle = "";
            textBox.Text = "0";
        }
        private void btn_effacerEntrer_Click(object sender, EventArgs e)
        {
           if(calculatriceActuelle.Length > 0)
            {
                calculatriceActuelle = calculatriceActuelle.Remove(calculatriceActuelle.Length - 1,1);
            }
            textBox.Text = calculatriceActuelle;
        }


    }
}
