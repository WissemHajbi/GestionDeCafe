using AhmedKhlif.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedKhlif.Data
{
    public class ProductAdo
    {
        public static DataTable Liste_Product()
        {
            DataTable tab = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Product", DbContext.ConnectionString);
            da.Fill(tab);
            return tab;
        }

        public static bool Exist(int id)
        {
            SqlCommand cmd = new SqlCommand($"select * from Product where Id = {id}", DbContext._connexion);
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

        public static void Add(Models.Product p)
        {
            SqlCommand cmd = new SqlCommand($"insert into Product(Id,nom_pr,prix_pr,categ_pr) values ({p.Id},'{p.nom_pr}',{p.prix_pr},'{p.categ_pr}')", DbContext._connexion);
            cmd.ExecuteNonQuery();
        }

        public static void Delete(int Id)
        {
            SqlCommand cmd = new SqlCommand($"delete from Product where Id = {Id}", DbContext._connexion);
            cmd.ExecuteNonQuery();
        }

        public static void Modify(Models.Product p)
        {
            SqlCommand cmdmaj = new SqlCommand($"update Product set nom_pr='{p.nom_pr}',prix_pr={p.prix_pr}, categ_pr='{p.categ_pr}' where Id ={p.Id}", DbContext._connexion);
            cmdmaj.ExecuteNonQuery();
        }

        public static int GetLastId()
        {
            SqlCommand cmd = new SqlCommand($"select MAX(id) from Product", DbContext._connexion);
            return (int)cmd.ExecuteScalar();
        }

    }
}
