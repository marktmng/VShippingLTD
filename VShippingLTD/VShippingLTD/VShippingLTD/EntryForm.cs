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
using Excel = Microsoft.Office.Interop.Excel;

namespace VShippingLTD
{
    public partial class ParcelEntryForm : Form
    {
        private ParcelManager parcelManager; // call the ParcelManager

        public ParcelEntryForm()
        {
            InitializeComponent();
            parcelManager = new ParcelManager(); // declare new parcelManager
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
            DataTable dataTable = parcelManager.GetParcels(searchTerm);
            parceLDTGview.DataSource = dataTable;
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
            parcelManager.InsertParcel(newParcel);

            // Clear the text boxes after inserting the parcel
            ClearControls();

            // Refresh the DataGridView to display the newly added parcel
            RefreshDataGridView();

            // Display success message
            MessageBox.Show("Parcel successfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            parcelManager.UpdateParcel(updatedParcel);

            // Clear the text boxes after updating the parcel
            ClearControls(); //clear
            RefreshDataGridView(); // refresh


            // Display success message
            MessageBox.Show("Parcel successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        // delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Retrieve the ParcelID from the text box
            if (!int.TryParse(txtParcelID.Text, out int parcelID))
            {
                MessageBox.Show("Invalid Parcel ID");
                return;
            }

            // Call a method to delete the parcel from the database
            parcelManager.DeleteParcel(parcelID);

            // Clear the text boxes after deleting the parcel
            ClearControls();

            // Refresh the DataGridView to reflect the updated data after deletion
            RefreshDataGridView();

            // Display success message
            MessageBox.Show("Parcel successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        // clear
        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearControls();
        }


        private void btnext_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form
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

        // export button
        private void btnExport_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel File|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcel(parceLDTGview, filePath); // mentioned datagridview

                MessageBox.Show("File Exported");
            }
        }

        // button search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            RefreshDataGridView(searchTerm);
            ClearControls();
        }
    }
}
