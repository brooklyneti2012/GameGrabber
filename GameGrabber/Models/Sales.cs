using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGrabber.Models
{
    public class Sales
    {
        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
