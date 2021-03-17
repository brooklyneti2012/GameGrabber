using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameGrabber.Models
{
    public class Customer
    {
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstMidName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
         public Product Product { get; set; }
        





    }
}