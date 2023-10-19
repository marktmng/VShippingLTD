using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VShippingLTD;

namespace VShippingLTD
{
    public class Parcel
    {
        // properties for parcel
        public int ParcelID { get; set; }

        public int CustomerID { get; set; }

        public string ParcelName { get; set; }

        public string ParcelDescription { get; set; }

        public decimal Price { get; set; }

        public string Address { get; set; }

        public decimal Weight { get; set; }

    }
}
