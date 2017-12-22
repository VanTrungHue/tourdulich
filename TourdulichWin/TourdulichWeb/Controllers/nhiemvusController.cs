using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ENTITIES;

namespace TourdulichWeb.Controllers
{
    public class nhiemvusController : Controller
    {
        private tourdulichEntities db = new tourdulichEntities();

        // GET: nhiemvus
        public ActionResult Index()
        {
            return View(db.nhiemvus.ToList());
        }

        // GET: nhiemvus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhiemvu nhiemvu = db.nhiemvus.Find(id);
            if (nhiemvu == null)
            {
                return HttpNotFound();
            }
            return View(nhiemvu);
        }

        // GET: nhiemvus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nhiemvus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tennhiemvu")] nhiemvu nhiemvu)
        {
            if (ModelState.IsValid)
            {
                db.nhiemvus.Add(nhiemvu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhiemvu);
        }

        // GET: nhiemvus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhiemvu nhiemvu = db.nhiemvus.Find(id);
            if (nhiemvu == null)
            {
                return HttpNotFound();
            }
            return View(nhiemvu);
        }

        // POST: nhiemvus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tennhiemvu")] nhiemvu nhiemvu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhiemvu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhiemvu);
        }

        // GET: nhiemvus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhiemvu nhiemvu = db.nhiemvus.Find(id);
            if (nhiemvu == null)
            {
                return HttpNotFound();
            }
            return View(nhiemvu);
        }

        // POST: nhiemvus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nhiemvu nhiemvu = db.nhiemvus.Find(id);
            db.nhiemvus.Remove(nhiemvu);
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
