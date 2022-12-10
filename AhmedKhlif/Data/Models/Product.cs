using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedKhlif.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string nom_pr { get; set; }
        public float prix_pr { get; set; }
        public string categ_pr { get; set; }
    }
}
