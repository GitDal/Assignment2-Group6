using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2_EF_Core.Models
{
    public class Exercise
    {
        [Required]
        public int Number { get; set; }
        [Required]
        public string Lecture { get; set; }
        [Required]
        public string HelpWhere { get; set; }
    }
}
