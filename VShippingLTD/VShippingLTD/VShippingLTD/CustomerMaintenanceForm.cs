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

namespace VShippingLTD
{
    public partial class CustomerMaintenanceForm : Form
    {
        private void ClearControls()
        {
            txtCustomerID.Text = string.Empty;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtReceiverName.Text = "";
            txtReceiverEmail.Text = "";
        }

        public CustomerMaintenanceForm()
        {
            InitializeComponent();
        }

        private void CustomerMaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vShippingdbDataSet3.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter3.Fill(this.vShippingdbDataSet3.Customers);
            
            // Load data into the DataGridView
            RefreshDataGridView();
        }

        // Method to refresh the DataGridView
        private void RefreshDataGridView()
        {
            this.customersTableAdapter.Fill(this.vShippingdbDataSet.Customers);
        }

        // add customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerID.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID");
                return; // Exit the method if the customer ID is invalid
            }

            string cs = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            try
            {
                objSqlConnection.Open();
                string InsertCommand = "INSERT INTO Customers VALUES ('" + txtFirstName.Text + "', '"
                + txtLastName.Text + "', '"
                + txtEmail.Text + "', '"
                + txtPhoneNumber.Text + "','"
                + txtReceiverName.Text + "', '"
                + txtReceiverEmail.Text + "')";

                SqlCommand objSqlCommand = new SqlCommand(InsertCommand, objSqlConnection);
                objSqlCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Added");

                // After adding, refresh the DataGridView
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry Try Again" + ex.Message);
            }
            finally
            {
                objSqlConnection.Close();
            }
            //ClearControls();
        }

        private void cmDTGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerID.Text = cmDTGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(); // customerID is in the first column (index 0).
            txtFirstName.Text = cmDTGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString(); //  First Name is in the second column (index 1).
            txtLastName.Text = cmDTGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(); //  Last Name is in the third column (index 2).
            txtEmail.Text = cmDTGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(); // Email is in the fourth column (index 3).
            txtPhoneNumber.Text = cmDTGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(); //  Phone Number is in the fifth column (index 4).
            txtReceiverName.Text = cmDTGridView.Rows[e.RowIndex].Cells[5].FormattedValue.ToString(); //  Receiver Name is in the sixth column (index 5).
            txtReceiverEmail.Text = cmDTGridView.Rows[e.RowIndex].Cells[6].FormattedValue.ToString(); //  Receiver Email is in the seventh column (index 6).
        }

        // method
        private void UpdateCustomer(int customerId, string firstName, string lastName, string email, string phoneNumber, string receiverName, string receiverEmail)
        {
            string cs = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
            using (SqlConnection objSqlConnection = new SqlConnection(cs))
            {
                try
                {
                    objSqlConnection.Open();
                    string UpdateCommand = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, ReceiverName = @ReceiverName, ReceiverEmail = @ReceiverEmail  WHERE CustomerID = @CustomerID";
                    SqlCommand objSqlCommand = new SqlCommand(UpdateCommand, objSqlConnection);
                    objSqlCommand.Parameters.AddWithValue("@CustomerID", customerId);
                    objSqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                    objSqlCommand.Parameters.AddWithValue("@LastName", lastName);
                    objSqlCommand.Parameters.AddWithValue("@Email", email);
                    objSqlCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    objSqlCommand.Parameters.AddWithValue("@ReceiverName", receiverName);
                    objSqlCommand.Parameters.AddWithValue("@ReceiverEmail", receiverEmail);
                    objSqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully Updated");

                    // After updating, refresh the DataGridView
                    RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed: " + ex.Message);
                }
                ClearControls();
            }
        }

        // Event handler for the "Update" button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerID.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string receiverName = txtReceiverName.Text;
            string receiverEmail = txtReceiverEmail.Text;

            UpdateCustomer(customerId, firstName, lastName, email, phoneNumber, receiverName, receiverEmail);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerID.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            string cs = ConfigurationManager.ConnectionStrings["VShippingdbConnectionString"].ConnectionString;
            using (SqlConnection objSqlConnection = new SqlConnection(cs))
            {
                try
                {
                    objSqlConnection.Open();
                    string DeleteCommand = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                    SqlCommand objSqlCommand = new SqlCommand(DeleteCommand, objSqlConnection);
                    objSqlCommand.Parameters.AddWithValue("@CustomerID", customerId);
                    int rowsAffected = objSqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer removed successfully");
                        RefreshDataGridView(); // Refresh the DataGridView after removing a customer.
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Customer with the specified ID does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing customer: " + ex.Message);
                }
            }
        }
    }
}
