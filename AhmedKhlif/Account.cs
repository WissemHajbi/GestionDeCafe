using AhmedKhlif.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmedKhlif
{
    public partial class Account : Form
    {
        public Client MainAccount { get; set; }
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            nomTextBox.Text = MainAccount.nom_cl.Trim();
            prenomTextBox.Text = MainAccount.prenom_cl.Trim();
            telTextBox.Text = MainAccount.tel_cl.Trim();
            mdpTextBox.Text = MainAccount.Mdp.Trim();
            roleTextBox.Text = MainAccount.role_cl.Trim();
            soldeTextBox.Text = MainAccount.solde.ToString();
            roleTextBox.Enabled= false;
        }
    }
}
