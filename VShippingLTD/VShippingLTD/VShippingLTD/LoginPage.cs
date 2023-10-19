using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VShippingLTD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // login
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Connection string SQL Server connection details
            string connectionString = "Data Source=20220739-Mark;Initial Catalog=VShippingdb;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Define SQL query
                string query = "SELECT COUNT(*) FROM Admins WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.Add(new SqlParameter("@Username", username));
                    command.Parameters.Add(new SqlParameter("@Password", password));

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Successful login - open the main form
                        MainPage mainpage = new MainPage();
                        mainpage.Show();
                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        // Display an error message for invalid credentials
                        MessageBox.Show("Please Try Agin!");
                    }
                }
            }
        }

        // exit
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // Display a message box for logout confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // exit
            }

        }
    }
}
