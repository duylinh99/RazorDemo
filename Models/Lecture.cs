using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie{
    public class Lecture{
        [Key]
        public int LectureID { get; set; }
        public string LectureName { get; set; }
    }
}