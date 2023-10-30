namespace VShippingLTD
{
    partial class ShipmentDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentDetailsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnRmv = new System.Windows.Forms.Button();
            this.btnNeat = new System.Windows.Forms.Button();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.dtGV = new System.Windows.Forms.DataGridView();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.txtpTo = new System.Windows.Forms.TextBox();
            this.txtpFrom = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtCstIID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRmv);
            this.panel1.Controls.Add(this.btnNeat);
            this.panel1.Controls.Add(this.btnUpdt);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.dtGV);
            this.panel1.Controls.Add(this.txtReceiverName);
            this.panel1.Controls.Add(this.txtSenderName);
            this.panel1.Controls.Add(this.txtpTo);
            this.panel1.Controls.Add(this.txtpFrom);
            this.panel1.Controls.Add(this.txtPID);
            this.panel1.Controls.Add(this.txtCstIID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 599);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnext);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 136);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(125, 54);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(375, 48);
            this.Title.TabIndex = 32;
            this.Title.Text = "Shipments Details";
            // 
            // btnRmv
            // 
            this.btnRmv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRmv.BackColor = System.Drawing.Color.Red;
            this.btnRmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmv.Location = new System.Drawing.Point(370, 473);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(90, 37);
            this.btnRmv.TabIndex = 28;
            this.btnRmv.Text = "Remove";
            this.btnRmv.UseVisualStyleBackColor = false;
            // 
            // btnNeat
            // 
            this.btnNeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNeat.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeat.Location = new System.Drawing.Point(270, 473);
            this.btnNeat.Name = "btnNeat";
            this.btnNeat.Size = new System.Drawing.Size(78, 37);
            this.btnNeat.TabIndex = 27;
            this.btnNeat.Text = "Clear";
            this.btnNeat.UseVisualStyleBackColor = false;
            // 
            // btnUpdt
            // 
            this.btnUpdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdt.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdt.Location = new System.Drawing.Point(170, 473);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(78, 37);
            this.btnUpdt.TabIndex = 26;
            this.btnUpdt.Text = "Update";
            this.btnUpdt.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlus.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(70, 473);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(78, 37);
            this.btnPlus.TabIndex = 25;
            this.btnPlus.Text = "Add";
            this.btnPlus.UseVisualStyleBackColor = false;
            // 
            // dtGV
            // 
            this.dtGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtGV.Location = new System.Drawing.Point(561, 142);
            this.dtGV.Name = "dtGV";
            this.dtGV.RowHeadersWidth = 51;
            this.dtGV.RowTemplate.Height = 24;
            this.dtGV.Size = new System.Drawing.Size(614, 431);
            this.dtGV.TabIndex = 29;
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverName.Location = new System.Drawing.Point(236, 423);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(292, 22);
            this.txtReceiverName.TabIndex = 24;
            // 
            // txtSenderName
            // 
            this.txtSenderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderName.Location = new System.Drawing.Point(236, 379);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(292, 22);
            this.txtSenderName.TabIndex = 23;
            // 
            // txtpTo
            // 
            this.txtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpTo.Location = new System.Drawing.Point(236, 335);
            this.txtpTo.Name = "txtpTo";
            this.txtpTo.Size = new System.Drawing.Size(292, 22);
            this.txtpTo.TabIndex = 22;
            // 
            // txtpFrom
            // 
            this.txtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpFrom.Location = new System.Drawing.Point(236, 291);
            this.txtpFrom.Name = "txtpFrom";
            this.txtpFrom.Size = new System.Drawing.Size(292, 22);
            this.txtpFrom.TabIndex = 21;
            // 
            // txtPID
            // 
            this.txtPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.Location = new System.Drawing.Point(236, 247);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(292, 22);
            this.txtPID.TabIndex = 20;
            // 
            // txtCstIID
            // 
            this.txtCstIID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCstIID.Location = new System.Drawing.Point(236, 203);
            this.txtCstIID.Name = "txtCstIID";
            this.txtCstIID.Size = new System.Drawing.Size(292, 22);
            this.txtCstIID.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Receiver Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sender Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Parcel to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Parcel from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Parcel ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer ID";
            // 
            // btnext
            // 
            this.btnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnext.BackColor = System.Drawing.Color.Gold;
            this.btnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.Location = new System.Drawing.Point(1093, 66);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(80, 32);
            this.btnext.TabIndex = 34;
            this.btnext.Text = "&Close";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // ShipmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1218, 623);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "ShipmentDetailsForm";
            this.ShowIcon = false;
            this.Text = "Shipment Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.Button btnNeat;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.DataGridView dtGV;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.TextBox txtpTo;
        private System.Windows.Forms.TextBox txtpFrom;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtCstIID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnext;
    }
}