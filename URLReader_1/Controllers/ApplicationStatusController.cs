using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Query;
using System.Web.Mvc;
using URLReader.Models;
using URLReader_1.Models;

namespace URLReader_1.Controllers
{
    public class ApplicationStatusController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ApplicationStatus
        public ActionResult Index()
        {
            return View(db.ApplicationStatus.ToList());
        }

        // GET: ApplicationStatus/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationStatus applicationStatus = db.ApplicationStatus.Find(id);
            if (applicationStatus == null)
            {
                return HttpNotFound();
            }
            return View(applicationStatus);
        }

        // GET: ApplicationStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WebAppID,ExecutedTime,Success,TaskTime,HealthStatus,HSResponseTime")] ApplicationStatus applicationStatus)
        {
            if (ModelState.IsValid)
            {
                db.ApplicationStatus.Add(applicationStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicationStatus);
        }

        // GET: ApplicationStatus/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationStatus applicationStatus = db.ApplicationStatus.Find(id);
            if (applicationStatus == null)
            {
                return HttpNotFound();
            }
            return View(applicationStatus);
        }

        // POST: ApplicationStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WebAppID,ExecutedTime,Success,TaskTime,HealthStatus,HSResponseTime")] ApplicationStatus applicationStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicationStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicationStatus);
        }

        // GET: ApplicationStatus/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationStatus applicationStatus = db.ApplicationStatus.Find(id);
            if (applicationStatus == null)
            {
                return HttpNotFound();
            }
            return View(applicationStatus);
        }

        // POST: ApplicationStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ApplicationStatus applicationStatus = db.ApplicationStatus.Find(id);
            db.ApplicationStatus.Remove(applicationStatus);
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
