using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie{
    public class Employee{
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
    }
}