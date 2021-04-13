using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameGrabber.Models
{
    public class Customer
    {
        
        public int CustomerID { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Display (Name = "Fisrt name")]
        public string FirstMidName { get; set; }
        [Required]
        [Display(Name = "Adress")]
        public string Address { get; set; }
        [Required]
        [Display (Name = "Phone number")]
        public int PhoneNumber { get; set; }
        [Required]
        [Display (Name = "ItemPurchased" )]
         public string ItemPurchased { get; set; }
        





    }
}