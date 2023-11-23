namespace VShippingLTD
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.hmAnim = new System.Windows.Forms.PictureBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.Lgn = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hmAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // hmAnim
            // 
            this.hmAnim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hmAnim.Image = ((System.Drawing.Image)(resources.GetObject("hmAnim.Image")));
            this.hmAnim.Location = new System.Drawing.Point(37, 58);
            this.hmAnim.Name = "hmAnim";
            this.hmAnim.Size = new System.Drawing.Size(1427, 779);
            this.hmAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hmAnim.TabIndex = 0;
            this.hmAnim.TabStop = false;
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(37, 30);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(789, 22);
            this.searchBar.TabIndex = 1;
            this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lgn
            // 
            this.Lgn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lgn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Lgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lgn.Location = new System.Drawing.Point(1338, 20);
            this.Lgn.Name = "Lgn";
            this.Lgn.Size = new System.Drawing.Size(76, 32);
            this.Lgn.TabIndex = 4;
            this.Lgn.Text = "&Login";
            this.Lgn.UseVisualStyleBackColor = false;
            this.Lgn.Click += new System.EventHandler(this.Lgn_Click);
            // 
            // btnext
            // 
            this.btnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnext.BackColor = System.Drawing.Color.Red;
            this.btnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.Location = new System.Drawing.Point(1420, 20);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(80, 32);
            this.btnext.TabIndex = 5;
            this.btnext.Text = "Ex&it";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(832, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(910, 28);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 27);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Clear";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1550, 849);
            this.ControlBox = false;
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.Lgn);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.hmAnim);
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Text = "Home Page";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.hmAnim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hmAnim;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button Lgn;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClean;
    }
}