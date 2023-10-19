using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VShippingLTD
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Display a message box for logout confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User confirmed the logout
                this.Close(); // Close the current form
                LoginForm loginpage = new LoginForm();
                loginpage.Show(); // Show the login page
            }
        }

        private void cmMenu_Click(object sender, EventArgs e)
        {
            CustomerMaintenanceForm customerMaintenanceForm = new CustomerMaintenanceForm();
            customerMaintenanceForm.ShowDialog(); //show customer maintenance
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            ParcelEntryForm entryform = new ParcelEntryForm();
            entryform.ShowDialog(); //show data entry form
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm();
            searchform.ShowDialog(); //show search form
        }

        private void Shipmentdt_Click(object sender, EventArgs e)
        {
            ShipmentDetailsForm shipmentdtform = new ShipmentDetailsForm();
            shipmentdtform.ShowDialog(); //show shipment details form
        }
    }
}
