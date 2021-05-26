using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class TeacherFilterViewModel
    {
        public IList<Teacher> Teachers { get; set; }
        public string NameString { get; set; }
        public string DegreeString { get; set; }
        public string RankString { get; set; }
    }
}
