using System;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ClsConexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AB020OHN;Initial Catalog=DBbanco;Integrated Security=True");
    }
}
