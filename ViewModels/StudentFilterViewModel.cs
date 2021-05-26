using Microsoft.AspNetCore.Http;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class StudentFilterViewModel
    {
        public IList<Student> Students { get; set; }
        public string NameString { get; set; }
        public string IdString { get; set; }

      //  [Required(ErrorMessage = "Please choose profile image")]
       //[Display(Name = "Profile Picture")]
        //public IFormFile ProfilePicture { get; set; }
    }
}
