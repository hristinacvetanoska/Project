using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Course
    {
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string Title { get; set; }

            public int Credits { get; set; }

            public int Semester { get; set; }

            [StringLength(100)]
            public string Programme { get; set; }

            [StringLength(25)]
            [Display(Name = "Education level")]
            public string EducationLevel { get; set; }

            [Display(Name = "First teacher")]
            public int? FirstTeacherId { get; set; }

            [Display(Name = "First teacher")]
            [NotMapped]
            public Teacher Teacher1 { get; set; }

            [Display(Name = "Second teacher")]
            public int? SecondTeacherId { get; set; }

            [Display(Name = "Second teacher")]
            [NotMapped]
            public Teacher Teacher2 { get; set; }

            public ICollection<Enrollment> Students { get; set; }
        }
}