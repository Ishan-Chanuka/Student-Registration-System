using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SampleCRUD.Data;
using SampleCRUD.Models;

namespace SampleCRUD.Controllers
{
    public class stufdentsController : Controller
    {
        private SampleCRUDContext db = new SampleCRUDContext();

        // GET: stufdents
        public ActionResult Index()
        {
            return View(db.stufdents.ToList());
        }

        // GET: stufdents/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            stufdent stufdent = db.stufdents.Find(id);
            if (stufdent == null)
            {
                return HttpNotFound();
            }
            return View(stufdent);
        }

        // GET: stufdents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: stufdents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Age")] stufdent stufdent)
        {
            if (ModelState.IsValid)
            {
                db.stufdents.Add(stufdent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stufdent);
        }

        // GET: stufdents/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            stufdent stufdent = db.stufdents.Find(id);
            if (stufdent == null)
            {
                return HttpNotFound();
            }
            return View(stufdent);
        }

        // POST: stufdents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Age")] stufdent stufdent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stufdent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stufdent);
        }

        // GET: stufdents/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            stufdent stufdent = db.stufdents.Find(id);
            if (stufdent == null)
            {
                return HttpNotFound();
            }
            return View(stufdent);
        }

        // POST: stufdents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            stufdent stufdent = db.stufdents.Find(id);
            db.stufdents.Remove(stufdent);
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
