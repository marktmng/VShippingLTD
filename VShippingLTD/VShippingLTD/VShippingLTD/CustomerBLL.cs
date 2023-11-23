using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace VShippingLTD
{
    public class CustomerBLL
    {
        private string connectionString;

        public CustomerBLL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
        }

        public DataTable GetCustomers(string searchTerm = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectCommand = "SELECT * FROM Customers";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    selectCommand += " WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm";
                }

                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public bool AddCustomer(string firstName, string lastName, string email, string phoneNumber, string receiverName, string receiverEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertCommand = "INSERT INTO Customers VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @ReceiverName, @ReceiverEmail)";

                using (SqlCommand command = new SqlCommand(insertCommand, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@ReceiverName", receiverName);
                    command.Parameters.AddWithValue("@ReceiverEmail", receiverEmail);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateCustomer(int customerId, string firstName, string lastName, string email, string phoneNumber, string receiverName, string receiverEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateCommand = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, ReceiverName = @ReceiverName, ReceiverEmail = @ReceiverEmail WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(updateCommand, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@ReceiverName", receiverName);
                    command.Parameters.AddWithValue("@ReceiverEmail", receiverEmail);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteCommand = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(deleteCommand, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
