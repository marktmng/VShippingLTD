using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VShippingLTD
{
    public partial class HomeForm : Form
    {
        private DataGridView parceLDTGview;

        private ParcelEntryForm parcelEntryForm;
        private ParcelManager parcelManager;

        public HomeForm()
        {
            InitializeComponent();
            parcelEntryForm = new ParcelEntryForm();

            // Initialize parcelManager
            parcelManager = new ParcelManager();

            // Subscribe to the SearchButtonClicked event in ParcelEntryForm
            parcelEntryForm.GetSearchButton().Click += btnSearch_Click;

            // Initialize parceLDTGview if not already done in the designer
            parceLDTGview = new DataGridView();
            Controls.Add(parceLDTGview);

            //// Center the DataGridView
            parceLDTGview.Location = new Point((ClientSize.Width - parceLDTGview.Width) / 5, (ClientSize.Height - parceLDTGview.Height) / 3);

            // Set Anchor property to keep it centered if the form is resized
            parceLDTGview.Anchor = AnchorStyles.None;

            parceLDTGview.BringToFront();

            // Initialize visibility of the DataGridView
            parceLDTGview.Visible = false;

            // Set the size of the DataGridView
            parceLDTGview.Size = new Size(700, 150); // Adjust the width and height as needed
        }

        private void Lgn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            LoginForm lgnfrm = new LoginForm();
            lgnfrm.ShowDialog(); //show LoginForm
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            // Display a message box for logout confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // exit
            }
        }

        public void RefreshDataGridView(string searchTerm = null)
        {
            // Your existing logic to refresh the DataGridView
            DataTable dataTable = parcelManager.GetParcels(searchTerm);
            parceLDTGview.DataSource = dataTable;

        }

        private void PerformSearch()
        {
            ParcelEntryForm parcelEntryForm = new ParcelEntryForm();
            string searchTerm = parcelEntryForm.GetSearchTerm();
            RefreshDataGridView(searchTerm);


            //// Handle visibility based on the search term
            //parceLDTGview.Visible = !string.IsNullOrEmpty(searchTerm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
            string searchTerm = searchBar.Text; // search by Parcel Name
            RefreshDataGridView(searchTerm);
            parceLDTGview.Visible = true; // parcelDTGview visible
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            // Clear the search bar
            parcelEntryForm.ClearSearchBar();

            // Hide the DataGridView when search bar is cleared
            parceLDTGview.Visible = false;

            ClearControls();
        }

        private void ClearControls()
        {
            // Clear the text boxes after inserting the parcel
            searchBar.Text = "";
        }
    }
}
