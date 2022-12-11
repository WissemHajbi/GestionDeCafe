using AhmedKhlif.Data;
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
    public partial class Buy : Form
    {
        public Client MainAccount { get; set; }
        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            try
            {
                DbContext.Open();
                buyDataGridView.DataSource = LigneCommandeAdo.Liste_LigneCommandes(MainAccount.Id);
                totalTextBox.Text = "total : " + LigneCommandeAdo.GetTotal(MainAccount).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            qteTextBox.Text = buyDataGridView[3, buyDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void BuyProductBtn_Click(object sender, EventArgs e)
        {
            int total = LigneCommandeAdo.GetTotal(MainAccount);

            if (MainAccount.solde  >= total)
            {
                LigneCommandeAdo.Buy(MainAccount);
                ClientAdo.Buy(MainAccount, total);
                MainAccount.solde -= total;

                // mise a jour
                buyDataGridView.DataSource = LigneCommandeAdo.Liste_LigneCommandes(MainAccount.Id);
                totalTextBox.Text = "total : " + LigneCommandeAdo.GetTotal(MainAccount).ToString();
            }
            else
            {
                MessageBox.Show("solde insuffisante !");
            }
        }

        private void DeleteBuyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(buyDataGridView[0, buyDataGridView.CurrentRow.Index].Value.ToString());

                DialogResult r = MessageBox.Show("Voulez vous supprimer cetter produit", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    LigneCommandeAdo.Delete(Id);
                    buyDataGridView.DataSource = LigneCommandeAdo.Liste_LigneCommandes(MainAccount.Id);
                    totalTextBox.Text = "total : " + LigneCommandeAdo.GetTotal(MainAccount).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModifyBuyBtn_Click(object sender, EventArgs e)
        {
            if (qteTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un quantity !");
                qteTextBox.Focus();
            }
            else
            {
                LigneCommande l = new LigneCommande();

                l.Id = int.Parse(buyDataGridView[0, buyDataGridView.CurrentRow.Index].Value.ToString());
                l.id_Cmd = LigneCommandeAdo.GetLastNumCmd() + 1;
                l.prod = int.Parse(buyDataGridView[1, buyDataGridView.CurrentRow.Index].Value.ToString());

                int xx;

                if (int.TryParse(qteTextBox.Text, out xx) == false)
                {
                    MessageBox.Show("donner un quantity correcte ! ");
                    qteTextBox.Focus();
                }
                else
                {
                    l.qte = int.Parse(qteTextBox.Text);
                }

                l.nom_prod = buyDataGridView[2, buyDataGridView.CurrentRow.Index].Value.ToString();
                l.client = MainAccount.Id;
                l.prix_l = l.qte * int.Parse(buyDataGridView[3, buyDataGridView.CurrentRow.Index].Value.ToString());
                try
                {
                    LigneCommandeAdo.Modify(l);

                    // update the gridView
                    buyDataGridView.DataSource = LigneCommandeAdo.Liste_LigneCommandes(MainAccount.Id);
                    totalTextBox.Text = "total : " + LigneCommandeAdo.GetTotal(MainAccount).ToString();

                    // clear the textBoxes
                    qteTextBox.Clear();
                    totalTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
