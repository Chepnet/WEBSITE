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
    public class FarmersTrainingsController : Controller
    {
        private CMS db = new CMS();

        // GET: FarmersTrainings
        public ActionResult Index()
        {
            return View(db.FarmersTrainings.ToList());
        }

        // GET: FarmersTrainings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersTraining farmersTraining = db.FarmersTrainings.Find(id);
            if (farmersTraining == null)
            {
                return HttpNotFound();
            }
            return View(farmersTraining);
        }

        // GET: FarmersTrainings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FarmersTrainings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrainingId,TrainerName,EventName,Description,TrainingTime")] FarmersTraining farmersTraining)
        {
            if (ModelState.IsValid)
            {
                db.FarmersTrainings.Add(farmersTraining);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(farmersTraining);
        }

        // GET: FarmersTrainings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersTraining farmersTraining = db.FarmersTrainings.Find(id);
            if (farmersTraining == null)
            {
                return HttpNotFound();
            }
            return View(farmersTraining);
        }

        // POST: FarmersTrainings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrainingId,TrainerName,EventName,Description,TrainingTime")] FarmersTraining farmersTraining)
        {
            if (ModelState.IsValid)
            {
                db.Entry(farmersTraining).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(farmersTraining);
        }

        // GET: FarmersTrainings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FarmersTraining farmersTraining = db.FarmersTrainings.Find(id);
            if (farmersTraining == null)
            {
                return HttpNotFound();
            }
            return View(farmersTraining);
        }

        // POST: FarmersTrainings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FarmersTraining farmersTraining = db.FarmersTrainings.Find(id);
            db.FarmersTrainings.Remove(farmersTraining);
            db.SaveChanges();
            return RedirectToAction("Index");
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
