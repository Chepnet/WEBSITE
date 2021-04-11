using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Content_Management_System.Models;

namespace Content_Management_System.Controllers
{
    public class TrainingApplicationsController : Controller
    {
        private CMS db = new CMS();

        // GET: TrainingApplications
        public ActionResult Index()
        {
            return View(db.TrainingApplications.ToList());
        }

        // GET: TrainingApplications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainingApplications trainingApplications = db.TrainingApplications.Find(id);
            if (trainingApplications == null)
            {
                return HttpNotFound();
            }
            return View(trainingApplications);
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
