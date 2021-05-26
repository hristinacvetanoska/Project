using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class EnrollmentFilterViewModel
    {
        public IEnumerable<Enrollment> Enrollments { get; set; }
        public int Year { get; set; }
    }
}
