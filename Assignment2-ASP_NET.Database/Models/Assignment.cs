using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment2_ASP_NET.Database.Models
{
    public class Assignment
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HelpRequestId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Help Where")]
        public string HelpWhere { get; set; }
        
        [Display(Name = "Course Tag")]
        public string CourseId { get; set; }
        public string TeacherId { get; set; }
        public bool Open { get; set; }

        //Navigational properties
        public List<StudentAssignment> Students { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
