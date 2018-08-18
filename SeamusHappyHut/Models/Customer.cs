using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeamusHappyHut.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [DisplayName("Name")]
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [DisplayName("Favorite Drink")]
        public string FaveDrink { get; set; }
        [DisplayName("Favorite Meal")]
        public string FaveMeal { get; set; }
        [DisplayName("Largest Bill")]
        public int LargestBill { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}