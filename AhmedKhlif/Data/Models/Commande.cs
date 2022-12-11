using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedKhlif.Data.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public int prod { get; set; }
        public int client { get; set; }
        public DateTime date { get; set; }
    }
}
