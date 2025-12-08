using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeProjetForm
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue " + txtNom.Text + " " + txtPrenom.Text + " dans le monde de la programmation C#, votre email est "+ txtEmail.Text);
            txtEmail.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtNom.Focus();

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
