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
    public partial class LogIn : Form
    {

        public bool UserSuccessfullyAuthenticated { get; private set; }
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            try
            {
                DbContext.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (nomTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner votre nom !");
                nomTextBox.Focus();
            }
            else if (mdpTextBox.Text.Length == 0)
            {
                MessageBox.Show("donner votre mot de passe !");
                mdpTextBox.Focus();
            }
            else
            {
                try
                {
                    if (ClientAdo.Login(nomTextBox.Text, mdpTextBox.Text))
                    {
                        UserSuccessfullyAuthenticated = true;
                        Close();
                    }
                    else
                    {
                        // clear the textBoxes
                        nomTextBox.Clear();
                        mdpTextBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void nomLabel_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
