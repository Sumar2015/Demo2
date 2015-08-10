using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using demoLog.DAL;
using demoLog.Models;

namespace demoLog.Controllers
{
    public class ReportsController : Controller
    {
        private SchoolContext db = new SchoolContext();
        // GET: Reports
        public ActionResult Index()
        {
            ReportViewModel reportViewModel = new ReportViewModel();
            reportViewModel.DateCreated = DateTime.Now;
            return View(reportViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
