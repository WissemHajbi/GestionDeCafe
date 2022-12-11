using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedKhlif.Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string nom_cl { get; set; }
        public string prenom_cl { get; set; }
        public string tel_cl { get; set; }
        public string Mdp { get; set; }

        public string role_cl { get; set; }
    }
}
