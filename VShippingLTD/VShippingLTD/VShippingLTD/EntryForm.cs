using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VShippingLTD;

namespace VShippingLTD
{
    public partial class ParcelEntryForm : Form
    {
        public ParcelEntryForm()
        {
            InitializeComponent();
        }

        private void ParcelEntryForm_Load(object sender, EventArgs e)
        {
            // Load data into the DataGridView
            RefreshDataGridView();
        }


        private void ClearControls()
        {
            // Clear the text boxes after inserting the parcel
            txtParcelID.Text = "";
            txtCustID.Text = "";
            txtParcelName.Text = "";
            txtParcelDes.Text = "";
            txtPrice.Text = "";
            txtAddress.Text = "";
            txtWeight.Text = "";
        }

        private void RefreshDataGridView(string searchTerm = null)
        {
            string con = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                string selectCommand = "SELECT * FROM Parcels";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Add a WHERE clause to filter by parcel name or other criteria containing the search term.
                    selectCommand += " WHERE ParcelName LIKE @SearchTerm";
                }

                using (SqlCommand command = new SqlCommand(selectCommand, connection))
                {
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        // Add the search parameter if a search term is provided.
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        parceLDTGview.DataSource = dataTable;
                    }
                }
            }
        }


        // datagridview
        private void parceLDTGview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = parceLDTGview.Rows[e.RowIndex];
                txtParcelID.Text = row.Cells[0].Value.ToString();
                txtCustID.Text = row.Cells[1].Value.ToString();
                txtParcelName.Text = row.Cells[2].Value.ToString();
                txtParcelDes.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                txtAddress.Text = row.Cells[5].Value.ToString();
                txtWeight.Text = row.Cells[6].Value.ToString();
            }

        }

        // add 
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Retrieve the values entered by the user from the text boxes
            int parcelID;
            if (!int.TryParse(txtParcelID.Text, out parcelID))
            {
                MessageBox.Show("Invalid Parcel ID");
                return;
            }

            int customerID;
            if (!int.TryParse(txtCustID.Text, out customerID))
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            string parcelName = txtParcelName.Text;
            string parcelDescription = txtParcelDes.Text;

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid Price");
                return;
            }

            string address = txtAddress.Text;

            decimal weight;
            if (!decimal.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("Invalid Weight");
                return;
            }

            // Create a Parcel object and set its properties
            Parcel newParcel = new Parcel
            {
                ParcelID = parcelID,
                CustomerID = customerID,
                ParcelName = parcelName,
                ParcelDescription = parcelDescription,
                Price = price,
                Address = address,
                Weight = weight
            };

            // Call a method to insert the parcel into the database
            InsertParcel(newParcel);

            // Clear the text boxes after inserting the parcel
            ClearControls();

            // Refresh the DataGridView to display the newly added parcel
            RefreshDataGridView();
        }

        private void InsertParcel(Parcel parcel)
        {
            string con = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("spInsertParcel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the ParcelID parameter to the stored procedure
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

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        // update
        private void btnUpd_Click(object sender, EventArgs e)
        {
            // Retrieve the values entered by the user from the text boxes
            int parcelID;
            if (!int.TryParse(txtParcelID.Text, out parcelID))
            {
                MessageBox.Show("Invalid Parcel ID");
                return;
            }

            int customerID;
            if (!int.TryParse(txtCustID.Text, out customerID))
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            string parcelName = txtParcelName.Text;
            string parcelDescription = txtParcelDes.Text;

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid Price");
                return;
            }

            string address = txtAddress.Text;

            decimal weight;
            if (!decimal.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("Invalid Weight");
                return;
            }

            // Create a Parcel object and set its properties
            Parcel updatedParcel = new Parcel
            {
                ParcelID = parcelID,
                CustomerID = customerID,
                ParcelName = parcelName,
                ParcelDescription = parcelDescription,
                Price = price,
                Address = address,
                Weight = weight
            };

            // Call a method to update the parcel in the database
            UpdateParcel(updatedParcel);

            // Clear the text boxes after updating the parcel
            ClearControls();

            // Refresh the DataGridView to display the updated parcel
            RefreshDataGridView();
        }

        private void UpdateParcel(Parcel parcel)
        {
            string con = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("spUpdateParcel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the parameters needed for the update operation
                    command.Parameters.Add(new SqlParameter("@ParcelID", parcel.ParcelID));
                    command.Parameters.Add(new SqlParameter("@CustomerID", parcel.CustomerID));
                    command.Parameters.Add(new SqlParameter("@ParcelName", parcel.ParcelName));
                    command.Parameters.Add(new SqlParameter("@ParcelDescription", parcel.ParcelDescription));
                    command.Parameters.Add(new SqlParameter("@Price", parcel.Price));
                    command.Parameters.Add(new SqlParameter("@Address", parcel.Address));
                    command.Parameters.Add(new SqlParameter("@Weight", parcel.Weight));

                    // Execute the update command
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Retrieve the ParcelID from the text box
            if (!int.TryParse(txtParcelID.Text, out int parcelID))
            {
                MessageBox.Show("Invalid Parcel ID");
                return;
            }

            // Call a method to delete the parcel from the database
            DeleteParcel(parcelID);

            // Clear the text boxes after deleting the parcel
            ClearControls();

            // Refresh the DataGridView to reflect the updated data after deletion
            RefreshDataGridView();
        }

        private void DeleteParcel(int parcelID)
        {
            string con = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("spDeleteParcel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the ParcelID parameter to the stored procedure for deletion
                    command.Parameters.Add(new SqlParameter("@ParcelID", parcelID));

                    // Execute the delete command
                    command.ExecuteNonQuery();
                }
            }

        }

        private void btnext_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form
        }
    }
}
