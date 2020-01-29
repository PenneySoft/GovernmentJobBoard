using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DFEJobs.Models;
using DFEJobs.ViewModels;

namespace DFEJobs.Controllers
{
    public class JobsController : Controller
    {

        // Database access
        private ApplicationDbContext _context;
        public JobsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        /*
        // GET: Jobs
        public ActionResult Index()
        {
            ViewBag.Message = "Job Vacancies";

            // Gets all job from Job table in database
            var jobs = _context.Job.ToList();

            return View(jobs);
        }
        */

        // GET: Jobs
        public ActionResult Index(String dept)
        {

            var jobs = from j in _context.Job
                       select j;

            if (!String.IsNullOrEmpty(dept))
            {
                jobs = jobs
                    .Where(j => j.Department
                    .Contains(dept));
                ViewBag.Message = dept;
            }
            else
            {
                ViewBag.Message = "Job";
            }

            ViewBag.Message += " Vacancies";

            // Gets all job from Job table in database
            /*
            jobs = _context.Job.ToList()
                .Where(j => j.Department
                .Contains(dept));

            */

            return View(jobs);
        }



        // GET: Jobs/id
        public ActionResult Details(int id)
        {
            // Gets row in Job table where row Id is equal to parameter passed to JobsController
            var job = _context.Job.SingleOrDefault(j => j.Id == id);

            // If job id is not in database, throws 404 error
            if (job == null)
            {
                return HttpNotFound();
            }

            return View(job);
        }



        // POST: Jobs
        [Authorize(Roles = "CanCreateJobs")]
        public ActionResult Create()
        {
            ViewBag.Message = "Create a new job vacancy";
            return View();
        }

        // POST: Jobs
        [HttpPost]
        [Authorize(Roles = "CanCreateJobs")]
        public ActionResult Add(Job job)
        {
            // If form requirements aren't met, reload form with validation messages
            if (!ModelState.IsValid)
            {
                return View("Create");
            }

            // Takes the job created in the form, adds to Job table in the database, and saves changes to database.
            _context.Job.Add(job);
            _context.SaveChanges();

            return RedirectToAction("Create", "Jobs");
        }


        public ActionResult Apply(int id)
        {
            ViewBag.JobId = id;

            var job = _context.Job.SingleOrDefault(j => j.Id == id);

            if (job == null)
            {
                return HttpNotFound();
            }

            var viewModel = new JobApplicationViewModel
            {
                Job = job,
                Application = new Application { JobId = id }
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult ApplyAdd(Application application)
        {

            if (!ModelState.IsValid)
                return HttpNotFound();

            _context.Applications.Add(application);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}