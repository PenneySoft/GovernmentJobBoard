using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DFEJobs.Models;
using DFEJobs.ViewModels;
using PagedList;

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

        // GET: Jobs
        public ActionResult Index(string currentDept, string deptSearch, string sortOrder, string currentTitle, string titleSearch, int? page, string currentLocation, string locationSearch)
        {

            // Take URL "sort" parameters and store in ViewBag
            ViewBag.CurrentSort = sortOrder;
            ViewBag.TitleSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.SalarySortParm = sortOrder == "Salary" ? "salary_desc" : "Salary";

            if (titleSearch != null)
            {
                page = 1;
            }
            else
            {
                titleSearch = currentTitle;
            }

            ViewBag.CurrentTitle = titleSearch;

            if (locationSearch != null)
            {
                page = 1;
            }
            else
            {
                locationSearch = currentLocation;
            }

            if (deptSearch != null)
            {
                page = 1;
            }
            else
            {
                deptSearch = currentDept;
            }

            ViewBag.CurrentLocation = locationSearch;

            var jobs = from j in _context.Job
                       select j;

            // Apply search criteria (if present)
            if (!String.IsNullOrEmpty(titleSearch))
            {
                jobs = jobs
                    .Where(s => s.Title
                    .Contains(titleSearch));
            }

            if (!String.IsNullOrEmpty(locationSearch))
            {
                jobs = jobs
                    .Where(s => s.Location
                    .Contains(locationSearch));
            }

            // Apply department search
            if (!String.IsNullOrEmpty(deptSearch))
            {
                jobs = jobs
                    .Where(j => j.Department
                    .Contains(deptSearch));
                ViewBag.Message = deptSearch;
                currentDept = deptSearch;
            }
            else
            {
                ViewBag.Message = "Job";
            }

            ViewBag.CurrentDept = currentDept;
            ViewBag.Message += " Vacancies";

            // Ordering table data
            switch (sortOrder)
            {
                case "title_desc":
                    jobs = jobs.OrderByDescending(j => j.Title);
                    break;
                case "Salary":
                    jobs = jobs.OrderBy(j => j.Salary);
                    break;
                case "salary_desc":
                    jobs = jobs.OrderByDescending(j => j.Salary);
                    break;
                default:  // Default: Title ascending 
                    jobs = jobs.OrderBy(j => j.Title);
                    break;
            }

            // Show many jobs found in search
            ViewBag.JobCount = jobs.Count();

            // Pagination
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(jobs.ToPagedList(pageNumber, pageSize));
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