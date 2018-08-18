using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeamusHappyHut.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string Item { get; set; }
        [DisplayName("Price")]
        public double ItemPrice { get; set; }
    }
}