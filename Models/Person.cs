using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Person{
        [Key]
        public int PersonID { get; set; }
        public string PersonName { get; set; }
    }
}