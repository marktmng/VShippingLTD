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
        RoleLogin db = new RoleLogin();
        public LoginForm()
        {
            InitializeComponent();
        }

        // login
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("spRoleLogin", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows) // read condition
                    {
                        read.Read();
                        if (read[2].ToString() == "Admin") // admin as a  receptionist role
                        {
                            RoleLogin.type = "A"; // assigned "A" for Admin/Receptionist
                        }
                        else if (read[2].ToString() == "Customer") // customer
                        {
                            RoleLogin.type = "C"; // assigned "C" for customer
                        }

                        MainPage mp = new MainPage();
                        mp.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
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
