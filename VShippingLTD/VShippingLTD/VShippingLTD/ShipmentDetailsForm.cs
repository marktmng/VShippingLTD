﻿using System;
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
    public partial class ShipmentDetailsForm : Form
    {
        public ShipmentDetailsForm()
        {
            InitializeComponent();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form
        }
    }
}
