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
    public class chitietdoandulichesController : Controller
    {
        private tourdulichEntities db = new tourdulichEntities();
        chitietdoandulichbus ctddlbus = new chitietdoandulichbus();
        // GET: chitietdoanduliches
        public ActionResult Index(string iddoan)
        {
            int id;
            if (Int32.TryParse(iddoan, out id))
            {
               var list =  ctddlbus.showlist(id).ToList();
                ViewBag.iddoan = new SelectList(db.doanduliches, "id", "tendoan");
                return View(list);
            }
            var chitietdoanduliches = db.chitietdoanduliches.Include(c => c.doandulich).Include(c => c.khachhang);
            ViewBag.iddoan = new SelectList(db.doanduliches, "id", "tendoan");
            return View(chitietdoanduliches.ToList());
        }
      

        // GET: chitietdoanduliches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chitietdoandulich chitietdoandulich = db.chitietdoanduliches.Find(id);
            if (chitietdoandulich == null)
            {
                return HttpNotFound();
            }
            return View(chitietdoandulich);
        }

        // GET: chitietdoanduliches/Create
        public ActionResult Create()
        {
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan");
            ViewBag.idkhachhang = new SelectList(db.khachhangs, "id", "socmnd_tenkh");
            return View();
        }

        // POST: chitietdoanduliches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,iddoandulich,idkhachhang")] chitietdoandulich chitietdoandulich)
        {
            if (ModelState.IsValid)
            {
                db.chitietdoanduliches.Add(chitietdoandulich);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", chitietdoandulich.iddoandulich);
            ViewBag.idkhachhang = new SelectList(db.khachhangs, "id", "socmnd_tenkh", chitietdoandulich.idkhachhang);
            return View(chitietdoandulich);
        }

        // GET: chitietdoanduliches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chitietdoandulich chitietdoandulich = db.chitietdoanduliches.Find(id);
            if (chitietdoandulich == null)
            {
                return HttpNotFound();
            }
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", chitietdoandulich.iddoandulich);
            ViewBag.idkhachhang = new SelectList(db.khachhangs, "id", "socmnd_tenkh", chitietdoandulich.idkhachhang);
            return View(chitietdoandulich);
        }

        // POST: chitietdoanduliches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,iddoandulich,idkhachhang")] chitietdoandulich chitietdoandulich)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chitietdoandulich).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", chitietdoandulich.iddoandulich);
            ViewBag.idkhachhang = new SelectList(db.khachhangs, "id", "socmnd_tenkh", chitietdoandulich.idkhachhang);
            return View(chitietdoandulich);
        }

        // GET: chitietdoanduliches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chitietdoandulich chitietdoandulich = db.chitietdoanduliches.Find(id);
            if (chitietdoandulich == null)
            {
                return HttpNotFound();
            }
            return View(chitietdoandulich);
        }

        // POST: chitietdoanduliches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            chitietdoandulich chitietdoandulich = db.chitietdoanduliches.Find(id);
            db.chitietdoanduliches.Remove(chitietdoandulich);
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
