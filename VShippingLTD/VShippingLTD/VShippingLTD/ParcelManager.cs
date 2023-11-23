using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using VShippingLTD;

namespace VShippingLTD
{
    public class ParcelManager // Business Logic Layer: ParcelManager class responsible for managing parcels in the system
    {
        private string connectionString; // Encapsulation: Connection string for the database

        public ParcelManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
        }

        // for searchTerm 
        public DataTable GetParcels(string searchTerm = null) // Business Logic and Encapsulation: GetParcels method retrieves parcels from the database
        {

            using (SqlConnection connection = new SqlConnection(connectionString)) // opening database connection
            {
                connection.Open();
                string selectCommand = "SELECT * FROM Parcels"; // construcct sql command

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    selectCommand += " WHERE ParcelName LIKE @SearchTerm";
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


        // insert command
        public void InsertParcel(Parcel parcel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("spInsertParcel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Business Logic: Adding parameters for the stored procedure
                    command.Parameters.Add(new SqlParameter("@ParcelID", parcel.ParcelID));
                    command.Parameters.Add(new SqlParameter("@CustomerID", parcel.CustomerID));
                    command.Parameters.Add(new SqlParameter("@ParcelName", parcel.ParcelName));
                    command.Parameters.Add(new SqlParameter("@ParcelDescription", parcel.ParcelDescription));
                    command.Parameters.Add(new SqlParameter("@Price", parcel.Price));
                    command.Parameters.Add(new SqlParameter("@Address", parcel.Address));
                    command.Parameters.Add(new SqlParameter("@Weight", parcel.Weight));

                    command.ExecuteNonQuery();
                }
            }
        }

        // update command
        public void UpdateParcel(Parcel parcel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("spUpdateParcel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Business Logic: Adding parameters for the stored procedure
                    command.Parameters.Add(new SqlParameter("@ParcelID", parcel.ParcelID));
                    command.Parameters.Add(new SqlParameter("@CustomerID", parcel.CustomerID));
                    command.Parameters.Add(new SqlParameter("@ParcelName", parcel.ParcelName));
                    command.Parameters.Add(new SqlParameter("@ParcelDescription", parcel.ParcelDescription));
                    command.Parameters.Add(new SqlParameter("@Price", parcel.Price));
                    command.Parameters.Add(new SqlParameter("@Address", parcel.Address));
                    command.Parameters.Add(new SqlParameter("@Weight", parcel.Weight));

                    command.ExecuteNonQuery();
                }
            }
        }

        // delete command
        public void DeleteParcel(int parcelID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("spDeleteParcel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Business Logic: Adding parameters for the stored procedure
                    command.Parameters.Add(new SqlParameter("@ParcelID", parcelID));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
