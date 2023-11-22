using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VShippingLTD
{
    class RoleLogin
    {
        public SqlConnection con;

        public RoleLogin()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString);
        }

        public static string type; // created public static type
    }
}
