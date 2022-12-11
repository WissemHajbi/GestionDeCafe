using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhmedKhlif.Data.Models;
using System.Windows.Forms;

namespace AhmedKhlif.Data
{
    public class LigneCommandeAdo
    {
        public static DataTable Liste_LigneCommandes(int id)
        {
            DataTable tab = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"select Id,prod,nom_prod,qte,prix_l from LigneCommande where client = {id} and payed = 'false'", DbContext.ConnectionString);
            da.Fill(tab);
            return tab;
        }

        public static void Add(LigneCommande l)
        {
            SqlCommand cmd = new SqlCommand($"insert into LigneCommande(Id,id_Cmd,prod,qte,nom_prod,client,prix_l) values({l.Id},{l.id_Cmd},{l.prod},{l.qte},'{l.nom_prod}',{l.client},{l.prix_l});", DbContext._connexion);
            cmd.ExecuteNonQuery();
        }

        public static bool Exist(int id)
        {
            SqlCommand cmd = new SqlCommand($"select * from LigneCommande where Id = {id}", DbContext._connexion);
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

        public static void Modify(LigneCommande l)
        {
            SqlCommand cmdmaj = new SqlCommand($"update LigneCommande set qte = {l.qte} where Id = {l.Id}", DbContext._connexion);
            cmdmaj.ExecuteNonQuery();
        }

        public static void Delete(int Id)
        {
            SqlCommand cmd = new SqlCommand($"delete from LigneCommande where Id = {Id}", DbContext._connexion);
            cmd.ExecuteNonQuery();
        }

        public static int GetLastId()
        {
            SqlCommand cmd = new SqlCommand($"select MAX(Id) from LigneCommande", DbContext._connexion);
            return (int)cmd.ExecuteScalar();
        }

        public static int GetLastNumCmd()
        {
            SqlCommand cmd = new SqlCommand($"select MAX(id_Cmd) from LigneCommande", DbContext._connexion);
            return (int)cmd.ExecuteScalar();
        }

        public static int GetTotal(Client c)
        {
            SqlCommand cmd = new SqlCommand($"select SUM(prix_l) from LigneCommande where client = {c.Id} and payed = 'false'", DbContext._connexion);
            try
            {
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static void Buy(Client c)
        {
            SqlCommand cmdmaj = new SqlCommand($"update LigneCommande set payed = 'true' where client = {c.Id}", DbContext._connexion);
            cmdmaj.ExecuteNonQuery();
        }
    }
}
