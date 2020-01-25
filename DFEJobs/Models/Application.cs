using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DFEJobs.Models
{
    public class Application
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Cover Letter")]
        public string CoverLetter { get; set; }

        public int JobId { get; set; }
    }
}