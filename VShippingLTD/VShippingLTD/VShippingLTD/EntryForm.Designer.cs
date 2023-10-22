namespace VShippingLTD
{
    partial class ParcelEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParcelEntryForm));
            this.Panel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.parceLDTGview = new System.Windows.Forms.DataGridView();
            this.parcelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vShippingdbDataSet4 = new VShippingLTD.VShippingdbDataSet4();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtParcelDes = new System.Windows.Forms.TextBox();
            this.txtParcelName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtParcelID = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parcelsTableAdapter = new VShippingLTD.VShippingdbDataSet4TableAdapters.ParcelsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parceLDTGview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.pictureBox1);
            this.Panel.Controls.Add(this.btnDelete);
            this.Panel.Controls.Add(this.btnClean);
            this.Panel.Controls.Add(this.btnUpd);
            this.Panel.Controls.Add(this.btnInsert);
            this.Panel.Controls.Add(this.parceLDTGview);
            this.Panel.Controls.Add(this.txtWeight);
            this.Panel.Controls.Add(this.txtAddress);
            this.Panel.Controls.Add(this.txtPrice);
            this.Panel.Controls.Add(this.txtParcelDes);
            this.Panel.Controls.Add(this.txtParcelName);
            this.Panel.Controls.Add(this.txtCustID);
            this.Panel.Controls.Add(this.txtParcelID);
            this.Panel.Controls.Add(this.Title);
            this.Panel.Controls.Add(this.label7);
            this.Panel.Controls.Add(this.label6);
            this.Panel.Controls.Add(this.label5);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1351, 670);
            this.Panel.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(322, 555);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClean.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClean.Location = new System.Drawing.Point(228, 555);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(78, 37);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Clear";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpd.Location = new System.Drawing.Point(134, 555);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(78, 37);
            this.btnUpd.TabIndex = 9;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInsert.Location = new System.Drawing.Point(40, 555);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(78, 37);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // parceLDTGview
            // 
            this.parceLDTGview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parceLDTGview.AutoGenerateColumns = false;
            this.parceLDTGview.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.parceLDTGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parceLDTGview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcelIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.parcelNameDataGridViewTextBoxColumn,
            this.parcelDescriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.parceLDTGview.DataSource = this.parcelsBindingSource;
            this.parceLDTGview.Location = new System.Drawing.Point(451, 46);
            this.parceLDTGview.Name = "parceLDTGview";
            this.parceLDTGview.RowHeadersWidth = 51;
            this.parceLDTGview.RowTemplate.Height = 24;
            this.parceLDTGview.Size = new System.Drawing.Size(881, 569);
            this.parceLDTGview.TabIndex = 12;
            this.parceLDTGview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parceLDTGview_CellContentClick);
            // 
            // parcelIDDataGridViewTextBoxColumn
            // 
            this.parcelIDDataGridViewTextBoxColumn.DataPropertyName = "ParcelID";
            this.parcelIDDataGridViewTextBoxColumn.HeaderText = "ParcelID";
            this.parcelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parcelIDDataGridViewTextBoxColumn.Name = "parcelIDDataGridViewTextBoxColumn";
            this.parcelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // parcelNameDataGridViewTextBoxColumn
            // 
            this.parcelNameDataGridViewTextBoxColumn.DataPropertyName = "ParcelName";
            this.parcelNameDataGridViewTextBoxColumn.HeaderText = "ParcelName";
            this.parcelNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parcelNameDataGridViewTextBoxColumn.Name = "parcelNameDataGridViewTextBoxColumn";
            this.parcelNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // parcelDescriptionDataGridViewTextBoxColumn
            // 
            this.parcelDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ParcelDescription";
            this.parcelDescriptionDataGridViewTextBoxColumn.HeaderText = "ParcelDescription";
            this.parcelDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parcelDescriptionDataGridViewTextBoxColumn.Name = "parcelDescriptionDataGridViewTextBoxColumn";
            this.parcelDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 125;
            // 
            // parcelsBindingSource
            // 
            this.parcelsBindingSource.DataMember = "Parcels";
            this.parcelsBindingSource.DataSource = this.vShippingdbDataSet4;
            // 
            // vShippingdbDataSet4
            // 
            this.vShippingdbDataSet4.DataSetName = "VShippingdbDataSet4";
            this.vShippingdbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWeight.Location = new System.Drawing.Point(205, 467);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(195, 22);
            this.txtWeight.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAddress.Location = new System.Drawing.Point(205, 421);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrice.Location = new System.Drawing.Point(205, 375);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(195, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // txtParcelDes
            // 
            this.txtParcelDes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtParcelDes.Location = new System.Drawing.Point(205, 329);
            this.txtParcelDes.Name = "txtParcelDes";
            this.txtParcelDes.Size = new System.Drawing.Size(195, 22);
            this.txtParcelDes.TabIndex = 4;
            // 
            // txtParcelName
            // 
            this.txtParcelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtParcelName.Location = new System.Drawing.Point(205, 283);
            this.txtParcelName.Name = "txtParcelName";
            this.txtParcelName.Size = new System.Drawing.Size(195, 22);
            this.txtParcelName.TabIndex = 3;
            // 
            // txtCustID
            // 
            this.txtCustID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustID.Location = new System.Drawing.Point(205, 237);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(195, 22);
            this.txtCustID.TabIndex = 2;
            // 
            // txtParcelID
            // 
            this.txtParcelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtParcelID.Location = new System.Drawing.Point(205, 191);
            this.txtParcelID.Name = "txtParcelID";
            this.txtParcelID.Size = new System.Drawing.Size(195, 22);
            this.txtParcelID.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(122, 96);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(84, 25);
            this.Title.TabIndex = 50;
            this.Title.Text = "Parcels";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Weight";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Parcel Description";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Parcel Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Parcel ID";
            // 
            // parcelsTableAdapter
            // 
            this.parcelsTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // ParcelEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1386, 694);
            this.Controls.Add(this.Panel);
            this.Name = "ParcelEntryForm";
            this.ShowIcon = false;
            this.Text = "Parcel Entry";
            this.Load += new System.EventHandler(this.ParcelEntryForm_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parceLDTGview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vShippingdbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView parceLDTGview;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtParcelDes;
        private System.Windows.Forms.TextBox txtParcelName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtParcelID;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private VShippingdbDataSet4 vShippingdbDataSet4;
        private System.Windows.Forms.BindingSource parcelsBindingSource;
        private VShippingdbDataSet4TableAdapters.ParcelsTableAdapter parcelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}