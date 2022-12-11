using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedKhlif.Data
{
    public class CommandeAdo
    {
        public static DataTable Liste_Commandes()
        {
            DataTable tab = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from LigneCOmmand", DbContext.ConnectionString);
            da.Fill(tab);
            return tab;
        }
    }
}
