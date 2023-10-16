namespace VShippingLTD
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.parcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Entry = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Shipmentdt = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.vsTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmMenu,
            this.parcelMenu,
            this.Shipmentdt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1576, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmMenu
            // 
            this.cmMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmMenu.Name = "cmMenu";
            this.cmMenu.Size = new System.Drawing.Size(175, 24);
            this.cmMenu.Text = "Customer Maintenance";
            this.cmMenu.Click += new System.EventHandler(this.cmMenu_Click);
            // 
            // parcelMenu
            // 
            this.parcelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.parcelMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Entry,
            this.Search});
            this.parcelMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.parcelMenu.Name = "parcelMenu";
            this.parcelMenu.Size = new System.Drawing.Size(62, 24);
            this.parcelMenu.Text = "Parcel";
            // 
            // Entry
            // 
            this.Entry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(224, 26);
            this.Entry.Text = "Entry";
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(224, 26);
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Shipmentdt
            // 
            this.Shipmentdt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Shipmentdt.Name = "Shipmentdt";
            this.Shipmentdt.Size = new System.Drawing.Size(136, 24);
            this.Shipmentdt.Text = "Shipment Details";
            this.Shipmentdt.Click += new System.EventHandler(this.Shipmentdt_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(1501, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 28);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log&out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // vsTitle
            // 
            this.vsTitle.AutoSize = true;
            this.vsTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.vsTitle.Location = new System.Drawing.Point(389, 144);
            this.vsTitle.Name = "vsTitle";
            this.vsTitle.Size = new System.Drawing.Size(629, 76);
            this.vsTitle.TabIndex = 2;
            this.vsTitle.Text = "Victory Shipping LTD";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 760);
            this.Controls.Add(this.vsTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmMenu;
        private System.Windows.Forms.ToolStripMenuItem parcelMenu;
        private System.Windows.Forms.ToolStripMenuItem Entry;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem Shipmentdt;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label vsTitle;
    }
}