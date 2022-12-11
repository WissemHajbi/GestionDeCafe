using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedKhlif.Data.Models
{
    public class LigneCommande
    {
        public int Id { get; set; }
        public int id_Cmd { get; set; }
        public int prod { get; set; }
        public int qte { get; set; }
        public string nom_prod { get; set; }
        public int client { get; set; }
        public string payed { get; set; }
        public decimal prix_l { get; set; }
    }
}
