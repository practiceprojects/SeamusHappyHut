using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeamusHappyHut.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        [DisplayName("Street Address")]
        public int StreetAddress { get; set; }
        [DisplayName("Street Name")]
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
