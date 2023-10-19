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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.parcelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Entry = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Shipmentdt = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.vsTitle = new System.Windows.Forms.Label();
            this.GIPHYBOX = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GIPHYBOX)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1382, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmMenu
            // 
            this.cmMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmMenu.Name = "cmMenu";
            this.cmMenu.Size = new System.Drawing.Size(175, 26);
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
            this.parcelMenu.Size = new System.Drawing.Size(62, 26);
            this.parcelMenu.Text = "Parcel";
            // 
            // Entry
            // 
            this.Entry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(136, 26);
            this.Entry.Text = "Entry";
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(136, 26);
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Shipmentdt
            // 
            this.Shipmentdt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Shipmentdt.Name = "Shipmentdt";
            this.Shipmentdt.Size = new System.Drawing.Size(136, 26);
            this.Shipmentdt.Text = "Shipment Details";
            this.Shipmentdt.Click += new System.EventHandler(this.Shipmentdt_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(1302, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 28);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log&out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // vsTitle
            // 
            this.vsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vsTitle.AutoSize = true;
            this.vsTitle.BackColor = System.Drawing.Color.Transparent;
            this.vsTitle.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTitle.ForeColor = System.Drawing.Color.White;
            this.vsTitle.Location = new System.Drawing.Point(416, 586);
            this.vsTitle.Name = "vsTitle";
            this.vsTitle.Size = new System.Drawing.Size(476, 52);
            this.vsTitle.TabIndex = 2;
            this.vsTitle.Text = "Victory Shipping LTD";
            // 
            // GIPHYBOX
            // 
            this.GIPHYBOX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GIPHYBOX.Image = ((System.Drawing.Image)(resources.GetObject("GIPHYBOX.Image")));
            this.GIPHYBOX.Location = new System.Drawing.Point(385, 146);
            this.GIPHYBOX.Name = "GIPHYBOX";
            this.GIPHYBOX.Size = new System.Drawing.Size(567, 437);
            this.GIPHYBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GIPHYBOX.TabIndex = 3;
            this.GIPHYBOX.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1382, 760);
            this.Controls.Add(this.GIPHYBOX);
            this.Controls.Add(this.vsTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GIPHYBOX)).EndInit();
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
        private System.Windows.Forms.PictureBox GIPHYBOX;
    }
}