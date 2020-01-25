using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DFEJobs.Models
{
    public class Job
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(100)]
        public string School { get; set; }

        [Required(ErrorMessage = "Salary must be a number e.g. 30000")]
        public int Salary { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Application> Applications { get; set; }

    }
}