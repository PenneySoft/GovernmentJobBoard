using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DFEJobs.Models;
using DFEJobs.ViewModels;
using System.Data.Entity;

namespace DFEJobs.Controllers
{
    [Authorize(Roles = "CanCreateJobs")]
    public class ApplicationsController : Controller
    {

        // Database access
        private ApplicationDbContext _context;
        public ApplicationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Applications
        public ActionResult Index(int id)
        {
            var job = _context.Job.Include(a => a.Applications)
                .SingleOrDefault(j => j.Id == id);

            if (job == null)
            {
                return HttpNotFound();
            }

            var viewModel = new JobAppListViewModel
            {

            };

            return View(job);
        }
    }
}