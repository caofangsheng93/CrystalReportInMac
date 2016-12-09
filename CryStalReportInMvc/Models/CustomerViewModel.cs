using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryStalReportInMvc.Models
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerZipCode { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerCity { get; set; }
    }
}