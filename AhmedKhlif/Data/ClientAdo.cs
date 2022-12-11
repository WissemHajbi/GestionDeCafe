using AhmedKhlif.Data.Models;
using AhmedKhlif.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedKhlif.Data
{
    internal class ClientAdo
    {
        public static bool Login(string nom, string mdp)
        {
            SqlCommand cmd = new SqlCommand($"select * from Client where nom_cl = '{nom}' and Mdp = '{mdp}'", DbContext._connexion);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.HasRows == true)
            {
                da.Close();
                return true;
            }
            else
            {
                da.Close();
                return false;
            }
        }

        public static void Register(Client c)
        {
            SqlCommand cmd = new SqlCommand($"insert into Client(Id,nom_cl,prenom_cl,tel_cl,Mdp) values ({c.Id},'{c.nom_cl}','{c.prenom_cl}','{c.tel_cl}','{c.Mdp}')", DbContext._connexion);
            cmd.ExecuteNonQuery();
        }
    }
}
