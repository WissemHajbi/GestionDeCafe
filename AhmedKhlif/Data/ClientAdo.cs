using AhmedKhlif.Data.Models;
using AhmedKhlif.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

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

        public static Client GetClient(string nom, string mdp)
        {
            Client c = new Client();
            SqlCommand cmd = new SqlCommand($"select id, nom_cl, prenom_cl, tel_cl, mdp, role_cl, solde from Client where nom_cl = '{nom}' and Mdp = '{mdp}'", DbContext._connexion);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            { 
                c.Id = reader.GetInt32(0);
                c.nom_cl = reader.GetString(1);
                c.prenom_cl = reader.GetString(2);
                c.tel_cl = reader.GetString(3);
                c.Mdp = reader.GetString(4);
                c.role_cl = reader.GetString(5);
                c.solde = reader.GetInt32(6);
            }
            return c;
        }

        public static void Register(Client c)
        {
            SqlCommand cmd = new SqlCommand($"insert into Client(Id,nom_cl,prenom_cl,tel_cl,Mdp) values ({c.Id},'{c.nom_cl}','{c.prenom_cl}','{c.tel_cl}','{c.Mdp}')", DbContext._connexion);
            cmd.ExecuteNonQuery();
        }
    
        public static int GetLastId()
        {
            SqlCommand cmd = new SqlCommand($"select MAX(id) from Client", DbContext._connexion);
            return (int)cmd.ExecuteScalar();
        }

        public static void Buy(Client c, int total)
        {
            SqlCommand cmdmaj = new SqlCommand($"update Client set solde = {c.solde - total} where Id = {c.Id}", DbContext._connexion);
            cmdmaj.ExecuteNonQuery();
        }
    }
}
