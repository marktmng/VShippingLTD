namespace VShippingLTD
{
    partial class CustomerMaintenanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblphNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmDTGridView = new System.Windows.Forms.DataGridView();
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vShippingdbDataSet2 = new VShippingLTD.VShippingdbDataSet2();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vShippingdbDataSet = new VShippingLTD.VShippingdbDataSet();
            this.customersTableAdapter = new VShippingLTD.VShippingdbDataSetTableAdapters.CustomersTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRecieverName = new System.Windows.Forms.Label();
            this.lblReceiverEmail = new System.Windows.Forms.Label();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.txtReceiverEmail = new System.Windows.Forms.TextBox();
            this.vShippingdbDataSet1 = new VShippingLTD.VShippingdbDataSet1();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new VShippingLTD.VShippingdbDataSet1TableAdapters.CustomersTableAdapter();
            this.customersTableAdapter2 = new VShippingLTD.VShippingdbDataSet2TableAdapters.CustomersTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vShippingdbDataSet3 = new VShippingLTD.VShippingdbDataSet3();
            this.customersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter3 = new VShippingLTD.VShippingdbDataSet3TableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cmDTGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(59, 144);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(80, 16);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(213, 138);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(225, 22);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(59, 191);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(213, 185);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(225, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(59, 238);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(213, 232);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(59, 285);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(213, 279);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblphNumber
            // 
            this.lblphNumber.AutoSize = true;
            this.lblphNumber.Location = new System.Drawing.Point(59, 332);
            this.lblphNumber.Name = "lblphNumber";
            this.lblphNumber.Size = new System.Drawing.Size(97, 16);
            this.lblphNumber.TabIndex = 0;
            this.lblphNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(213, 326);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(225, 22);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // cmDTGridView
            // 
            this.cmDTGridView.AllowUserToAddRows = false;
            this.cmDTGridView.AllowUserToDeleteRows = false;
            this.cmDTGridView.AutoGenerateColumns = false;
            this.cmDTGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmDTGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cmDTGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.ReceiverName,
            this.ReceiverEmail});
            this.cmDTGridView.DataSource = this.customersBindingSource3;
            this.cmDTGridView.Location = new System.Drawing.Point(467, 37);
            this.cmDTGridView.Name = "cmDTGridView";
            this.cmDTGridView.ReadOnly = true;
            this.cmDTGridView.RowHeadersWidth = 51;
            this.cmDTGridView.RowTemplate.Height = 24;
            this.cmDTGridView.Size = new System.Drawing.Size(912, 501);
            this.cmDTGridView.TabIndex = 12;
            this.cmDTGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cmDTGridView_CellClick);
            // 
            // customersBindingSource2
            // 
            this.customersBindingSource2.DataMember = "Customers";
            this.customersBindingSource2.DataSource = this.vShippingdbDataSet2;
            // 
            // vShippingdbDataSet2
            // 
            this.vShippingdbDataSet2.DataSetName = "VShippingdbDataSet2";
            this.vShippingdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.vShippingdbDataSet;
            // 
            // vShippingdbDataSet
            // 
            this.vShippingdbDataSet.DataSetName = "VShippingdbDataSet";
            this.vShippingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Location = new System.Drawing.Point(50, 500);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.Location = new System.Drawing.Point(150, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 37);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(350, 500);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(78, 37);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(110, 70);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(235, 25);
            this.Title.TabIndex = 4;
            this.Title.Text = "Customer Maintenance";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClear.Location = new System.Drawing.Point(250, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 37);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRecieverName
            // 
            this.lblRecieverName.AutoSize = true;
            this.lblRecieverName.Location = new System.Drawing.Point(59, 379);
            this.lblRecieverName.Name = "lblRecieverName";
            this.lblRecieverName.Size = new System.Drawing.Size(102, 16);
            this.lblRecieverName.TabIndex = 10;
            this.lblRecieverName.Text = "Receiver Name";
            // 
            // lblReceiverEmail
            // 
            this.lblReceiverEmail.AutoSize = true;
            this.lblReceiverEmail.Location = new System.Drawing.Point(59, 426);
            this.lblReceiverEmail.Name = "lblReceiverEmail";
            this.lblReceiverEmail.Size = new System.Drawing.Size(99, 16);
            this.lblReceiverEmail.TabIndex = 10;
            this.lblReceiverEmail.Text = "Receiver Email";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Location = new System.Drawing.Point(213, 373);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(225, 22);
            this.txtReceiverName.TabIndex = 6;
            // 
            // txtReceiverEmail
            // 
            this.txtReceiverEmail.Location = new System.Drawing.Point(213, 420);
            this.txtReceiverEmail.Name = "txtReceiverEmail";
            this.txtReceiverEmail.Size = new System.Drawing.Size(225, 22);
            this.txtReceiverEmail.TabIndex = 7;
            // 
            // vShippingdbDataSet1
            // 
            this.vShippingdbDataSet1.DataSetName = "VShippingdbDataSet1";
            this.vShippingdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.vShippingdbDataSet1;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // customersTableAdapter2
            // 
            this.customersTableAdapter2.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // ReceiverName
            // 
            this.ReceiverName.DataPropertyName = "ReceiverName";
            this.ReceiverName.HeaderText = "ReceiverName";
            this.ReceiverName.MinimumWidth = 6;
            this.ReceiverName.Name = "ReceiverName";
            this.ReceiverName.ReadOnly = true;
            this.ReceiverName.Width = 125;
            // 
            // ReceiverEmail
            // 
            this.ReceiverEmail.DataPropertyName = "ReceiverEmail";
            this.ReceiverEmail.HeaderText = "ReceiverEmail";
            this.ReceiverEmail.MinimumWidth = 6;
            this.ReceiverEmail.Name = "ReceiverEmail";
            this.ReceiverEmail.ReadOnly = true;
            this.ReceiverEmail.Width = 125;
            // 
            // vShippingdbDataSet3
            // 
            this.vShippingdbDataSet3.DataSetName = "VShippingdbDataSet3";
            this.vShippingdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource3
            // 
            this.customersBindingSource3.DataMember = "Customers";
            this.customersBindingSource3.DataSource = this.vShippingdbDataSet3;
            // 
            // customersTableAdapter3
            // 
            this.customersTableAdapter3.ClearBeforeFill = true;
            // 
            // CustomerMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1403, 604);
            this.Controls.Add(this.txtReceiverEmail);
            this.Controls.Add(this.txtReceiverName);
            this.Controls.Add(this.lblReceiverEmail);
            this.Controls.Add(this.lblRecieverName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmDTGridView);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblphNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "CustomerMaintenanceForm";
            this.Text = "Customer Maintenance";
            this.Load += new System.EventHandler(this.CustomerMaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmDTGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblphNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DataGridView cmDTGridView;
        private VShippingdbDataSet vShippingdbDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private VShippingdbDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRecieverName;
        private System.Windows.Forms.Label lblReceiverEmail;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.TextBox txtReceiverEmail;
        private VShippingdbDataSet1 vShippingdbDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private VShippingdbDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter1;
        private VShippingdbDataSet2 vShippingdbDataSet2;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private VShippingdbDataSet2TableAdapters.CustomersTableAdapter customersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverEmail;
        private VShippingdbDataSet3 vShippingdbDataSet3;
        private System.Windows.Forms.BindingSource customersBindingSource3;
        private VShippingdbDataSet3TableAdapters.CustomersTableAdapter customersTableAdapter3;
    }
}