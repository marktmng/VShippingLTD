using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VShippingLTD
{
    class RoleLogin // Business Logic Layer: RoleLogin class responsible for user authentication
    {
        public SqlConnection con; // Encapsulation: Private field for database connection

        public RoleLogin()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString);
        }

        public static string type; // created public static type

        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (con)
                {
                    con.Open();

                    // SqlCommand for executing stored procedure
                    SqlCommand cmd = new SqlCommand("spRoleLogin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader read = cmd.ExecuteReader(); // SqlDataReader for reading the results of the stored procedure

                    if (read.HasRows) // Check if the user is authenticated
                    {
                        read.Read();
                        if (read[2].ToString() == "Admin") // admin as a receptionist role
                        {
                            type = "A"; // assigned "A" for Admin/Receptionist
                        }
                        else if (read[2].ToString() == "Customer") // customer
                        {
                            type = "C"; // assigned "C" for customer
                        }

                        return true; // Authentication successful
                    }

                    return false; // Authentication failed
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
