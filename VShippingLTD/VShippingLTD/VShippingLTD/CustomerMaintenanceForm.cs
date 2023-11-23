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
using Excel = Microsoft.Office.Interop.Excel;

namespace VShippingLTD
{
    public partial class CustomerMaintenanceForm : Form
    {
        private CustomerBLL customerBLL;

        public CustomerMaintenanceForm()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
        }

        private void CustomerMaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vShippingdbDataSet5.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter4.Fill(this.vShippingdbDataSet5.Customers); // latest
            
            // Load data into the DataGridView
            RefreshDataGridView();
        }

        // Method to refresh the DataGridView
        private void RefreshDataGridView(string searchTerm = null)
        {
            DataTable dt = customerBLL.GetCustomers(searchTerm);
            cmDTGridView.DataSource = dt;
        }

        // search
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            RefreshDataGridView(searchTerm);
            ClearControls();

        }


        private void ClearControls()
        {
            txtCustomerID.Text = string.Empty;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtReceiverName.Text = "";
            txtReceiverEmail.Text = "";
            txtSearch.Text = "";
        }

   

        // add
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            bool success = customerBLL.AddCustomer(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text, txtReceiverName.Text, txtReceiverEmail.Text);

            if (success)
            {
                MessageBox.Show("Successfully Added");
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Sorry, try again.");
            }

            ClearControls();
        }

        // datagridview
        private void cmDTGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerID.Text = cmDTGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString(); // customerID is in the first column (index 0).
            txtFirstName.Text = cmDTGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString(); //  First Name is in the second column (index 1).
            txtLastName.Text = cmDTGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(); //  Last Name is in the third column (index 2).
            txtEmail.Text = cmDTGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(); // Email is in the fourth column (index 3).
            txtPhoneNumber.Text = cmDTGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(); //  Phone Number is in the fifth column (index 4).
            txtReceiverName.Text = cmDTGridView.Rows[e.RowIndex].Cells[5].FormattedValue.ToString(); //  Receiver Name is in the sixth column (index 5).
            txtReceiverEmail.Text = cmDTGridView.Rows[e.RowIndex].Cells[6].FormattedValue.ToString(); //  Receiver Email is in the seventh column (index 6).
        }


        // update
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerID.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            bool success = customerBLL.UpdateCustomer(customerId, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text, txtReceiverName.Text, txtReceiverEmail.Text);

            if (success)
            {
                MessageBox.Show("Successfully Updated");
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            ClearControls();
        }

        //delete
        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(txtCustomerID.Text, out customerId))
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            bool success = customerBLL.DeleteCustomer(customerId);

            if (success)
            {
                MessageBox.Show("Customer removed successfully");
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Customer removal failed.");
            }

            ClearControls();
        }

        //clear
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            this.Close(); // close this app
        }

        // export
        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            // create new excel application
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            // create workbook
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // copy column headers and make them bold
            for (int j = 0; j < dataGridView.Columns.Count; j++)
            {
                worksheet.Cells[1, j + 1] = dataGridView.Columns[j].HeaderText; // provides each columns name
                worksheet.Cells[1, j + 1].font.bold = true; // header names bold
            }

            // copy data from our dataGridView to Excel

            for (int i = 0; i < dataGridView.Rows.Count; i++) // iterates through all rows
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++) // iterates through every column for a specific rows
                {
                    // the argument to add the data from our DTG to excel
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;

                }
            }

            // save the workbook
            workbook.SaveAs(filePath);

            // clean up our resources - optional
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel File|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel(cmDTGridView, filePath); // mentioned datagridview

                MessageBox.Show("File Exported");
            }
        }
    }
}
