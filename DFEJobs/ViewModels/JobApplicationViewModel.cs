using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFEJobs.Models;

namespace DFEJobs.ViewModels
{
    public class JobApplicationViewModel
    {
        public Job Job { get; set; }
        public Application Application { get; set; }
    }
}