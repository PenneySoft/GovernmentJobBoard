using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DFEJobs.Models;

namespace DFEJobs.ViewModels
{
    public class JobAppListViewModel
    {
        public Job Job { get; set; }
        public IEnumerable<Application> Applications { get; set; }
    }
}