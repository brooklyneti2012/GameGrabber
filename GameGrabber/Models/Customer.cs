using System;
using System.Collections.Generic;

namespace GameGrabber.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Product Product { get; set; }





    }
}