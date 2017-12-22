using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ENTITIES;
using BIZ.BUS;

namespace TourdulichWeb.Controllers
{
    public class doandulichesController : Controller
    {
        private tourdulichEntities db = new tourdulichEntities();
        doandulichbus d = new doandulichbus();
        // GET: doanduliches
        public ActionResult Index()
        {
            var doanduliches = db.doanduliches.Include(d => d.tour);
            return View(doanduliches.ToList());
        }

        // GET: doanduliches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doandulich doandulich = db.doanduliches.Find(id);
            if (doandulich == null)
            {
                return HttpNotFound();
            }
            return View(doandulich);
        }

        // GET: doanduliches/Create
        public ActionResult Create()
        {
            ViewBag.idtour = new SelectList(db.tours, "id", "tentour");
            return View();
        }

        // POST: doanduliches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idtour,ngaykhoihanh,ngayketthuc,chuongtrinhthamquan,tendoan")] doandulich doandulich)
        {
            if (ModelState.IsValid)
            {
                db.doanduliches.Add(doandulich);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idtour = new SelectList(db.tours, "id", "tentour", doandulich.idtour);
            return View(doandulich);
        }

        // GET: doanduliches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doandulich doandulich = db.doanduliches.Find(id);
            if (doandulich == null)
            {
                return HttpNotFound();
            }
            ViewBag.idtour = new SelectList(db.tours, "id", "tentour", doandulich.idtour);
            return View(doandulich);
        }

        // POST: doanduliches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idtour,ngaykhoihanh,ngayketthuc,chuongtrinhthamquan,tendoan")] doandulich doandulich)
        {
            if (ModelState.IsValid)
            {
                d.sua(doandulich);
                return RedirectToAction("Index");
            }
            ViewBag.idtour = new SelectList(db.tours, "id", "tentour", doandulich.idtour);
            return View();
        }

        // GET: doanduliches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doandulich doandulich = db.doanduliches.Find(id);
            if (doandulich == null)
            {
                return HttpNotFound();
            }
            return View(doandulich);
        }

        // POST: doanduliches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            doandulich doandulich = db.doanduliches.Find(id);
            db.doanduliches.Remove(doandulich);
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
