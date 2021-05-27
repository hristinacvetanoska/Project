using Microsoft.AspNetCore.Http;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class UploadFileVIewModel
    {
        [Display(Name = "Upload your Seminal ")]
        public IFormFile SeminalUrl { get; set; }
        public Enrollment Enrollment { get; set; }
    }
}
