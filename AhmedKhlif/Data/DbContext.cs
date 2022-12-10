using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedKhlif.Data
{
    public class DbContext
    {
        public static SqlConnection _connexion;

        public static string ConnextionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
            Initial Catalog=AhmedKhlifbd";

        public static void Open()
        {
            _connexion= new SqlConnection(ConnextionString);
            if(_connexion.State == ConnectionState.Closed)
            {
                _connexion.Open();
            }
        }

        public static void Close()
        {
            if (_connexion.State == ConnectionState.Open)
            {
                _connexion.Close();
            }
        }
    }
}
