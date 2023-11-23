using System;
using System.Data;
using System.Windows.Forms;

namespace VShippingLTD
{
    public partial class LoginForm : Form // Inheritance: LoginForm inherits from Form
    {
        RoleLogin db = new RoleLogin(); // Encapsulation: Private field encapsulated within the class

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e) // Encapsulation and Polymorphism: Event handler for the login button
        {
            try
            {
                // Authenticate user using the RoleLogin class
                bool isAuthenticated = db.AuthenticateUser(txtUsername.Text, txtPassword.Text);

                if (isAuthenticated)
                {
                    // Polymorphism: Creating an instance of MainPage, a different class
                    MainPage mp = new MainPage(); 
                    mp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Encapsulation and Polymorphism: Event handler for the exit button
        private void btnExit_Click_1(object sender, EventArgs e) // button for hide this form and show home page
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                HomeForm hm = new HomeForm();
                hm.Show();
                this.Hide();
            }
        }
    }
}
