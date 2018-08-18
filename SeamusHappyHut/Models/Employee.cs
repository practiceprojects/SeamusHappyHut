using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeamusHappyHut.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [DisplayName("Email")]
        public string EmployeeEmail { get; set; }
        [DisplayName("Phone #")]
        public string EmployeePhone { get; set; }
        [DisplayName("Employee Number")]
        public string EmployeeNum { get; set; }
        [DisplayName("Emergency Contact 1")]
        public string EmergencyContactOne { get; set; }
        [DisplayName("Emergency Contact 2")]
        public string EmergencyContactTwo { get; set; }
        [DisplayName("Start Date")]
        public string DateStarted { get; set; }
    }
}