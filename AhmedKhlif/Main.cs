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
    public partial class Main : Form
    {

        public Client MainAccount { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Product f2 = new Product();
            f2.MdiParent = this;
            f2.Show();
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.MdiParent = this;
            a.MainAccount = MainAccount;
            a.Show();
        }
    }
}
