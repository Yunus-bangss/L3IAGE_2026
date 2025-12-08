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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lstVille.Items.Add(txtVille.Text);
            txtVille.Text = string.Empty;
            txtVille.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            lstVille.Items.RemoveAt(lstVille.SelectedIndex);
        }

        private void btnToutSupprimer_Click(object sender, EventArgs e)
        {
            lstVille.Items.Clear();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
