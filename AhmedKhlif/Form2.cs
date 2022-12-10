using AhmedKhlif.Data;
using AhmedKhlif.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmedKhlif
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                DbContext.Open();
                productsDataGrid.DataSource = ProductAdo.Liste_Product();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            int xx;

            if (int.TryParse(Id_prTextBox.Text,out xx) == false)
            {
                MessageBox.Show("donner un Id !");
                Id_prTextBox.Focus();
            }
            else if (nom_prTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un nom du produit !");
                nom_prTextBox.Focus();
            }
            else if (prix_prTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un prix !");
                prix_prTextBox.Focus();
            }
            else if (categ_prTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un category de produit !");
                categ_prTextBox.Focus();
            }else
            {
                Product p = new Product();

                p.Id = int.Parse(Id_prTextBox.Text);
                p.nom_pr = nom_prTextBox.Text;
                p.prix_pr = float.Parse(prix_prTextBox.Text);
                p.categ_pr= categ_prTextBox.Text;

                try
                {
                    if (ProductAdo.Exist(p.Id))
                    {
                        MessageBox.Show("il existe deja une produit avec cette Id !");
                        Id_prTextBox.Focus();
                    }
                    else
                    {
                        ProductAdo.Add(p);

                        // update the gridView
                        productsDataGrid.DataSource = ProductAdo.Liste_Product();

                        // clear the textBoxes
                        Id_prTextBox.Clear();
                        nom_prTextBox.Clear();
                        prix_prTextBox.Clear();
                        categ_prTextBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void productsDataGrid_DoubleClick(object sender, EventArgs e)
        {
            Id_prTextBox.Text = productsDataGrid[0,productsDataGrid.CurrentRow.Index].Value.ToString();
            nom_prTextBox.Text = productsDataGrid[1, productsDataGrid.CurrentRow.Index].Value.ToString();
            prix_prTextBox.Text = productsDataGrid[2, productsDataGrid.CurrentRow.Index].Value.ToString();
            categ_prTextBox.Text = productsDataGrid[3, productsDataGrid.CurrentRow.Index].Value.ToString();

            // disable the Id TextBox so the client cant change the Id of the product
            Id_prTextBox.Enabled = false;
        }

        private void ModifyProductBtn_Click(object sender, EventArgs e)
        {
            if (nom_prTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un nom du produit !");
                nom_prTextBox.Focus();
            }
            else if (prix_prTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un prix !");
                prix_prTextBox.Focus();
            }
            else if (categ_prTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner un category de produit !");
                categ_prTextBox.Focus();
            }
            else
            {
                Product p = new Product();

                p.Id = int.Parse(Id_prTextBox.Text);
                p.nom_pr = nom_prTextBox.Text;
                p.prix_pr = float.Parse(prix_prTextBox.Text);
                p.categ_pr = categ_prTextBox.Text;


                try
                {
                    ProductAdo.Modify(p);

                    // update the gridView
                    productsDataGrid.DataSource = ProductAdo.Liste_Product();

                    // clear the textBoxes
                    Id_prTextBox.Clear();
                    nom_prTextBox.Clear();
                    prix_prTextBox.Clear();
                    categ_prTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(productsDataGrid[0, productsDataGrid.CurrentRow.Index].Value.ToString());

                DialogResult r = MessageBox.Show("Voulez vous supprimer cetter produit", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    ProductAdo.Delete(Id);
                    productsDataGrid.DataSource = ProductAdo.Liste_Product();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
