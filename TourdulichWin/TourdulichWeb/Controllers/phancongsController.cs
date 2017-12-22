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
    public class phancongsController : Controller
    {
        private tourdulichEntities db = new tourdulichEntities();

        // GET: phancongs
        public ActionResult Index()
        {
            var phancongs = db.phancongs.Include(p => p.doandulich).Include(p => p.nhanvien).Include(p => p.nhiemvu);
            return View(phancongs.ToList());
        }

        // GET: phancongs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phancong phancong = db.phancongs.Find(id);
            if (phancong == null)
            {
                return HttpNotFound();
            }
            return View(phancong);
        }

        // GET: phancongs/Create
        public ActionResult Create()
        {
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan");
            ViewBag.idnhanvien = new SelectList(db.nhanviens, "id", "tennhanvien");
            ViewBag.idnhiemvu = new SelectList(db.nhiemvus, "id", "tennhiemvu");
            return View();
        }

        // POST: phancongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idnhanvien,idnhiemvu,iddoandulich")] phancong phancong)
        {
            if (ModelState.IsValid)
            {
                db.phancongs.Add(phancong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", phancong.iddoandulich);
            ViewBag.idnhanvien = new SelectList(db.nhanviens, "id", "tennhanvien", phancong.idnhanvien);
            ViewBag.idnhiemvu = new SelectList(db.nhiemvus, "id", "tennhiemvu", phancong.idnhiemvu);
            return View(phancong);
        }

        // GET: phancongs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phancong phancong = db.phancongs.Find(id);
            if (phancong == null)
            {
                return HttpNotFound();
            }
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", phancong.iddoandulich);
            ViewBag.idnhanvien = new SelectList(db.nhanviens, "id", "tennhanvien", phancong.idnhanvien);
            ViewBag.idnhiemvu = new SelectList(db.nhiemvus, "id", "tennhiemvu", phancong.idnhiemvu);
            return View(phancong);
        }

        // POST: phancongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idnhanvien,idnhiemvu,iddoandulich")] phancong phancong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phancong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", phancong.iddoandulich);
            ViewBag.idnhanvien = new SelectList(db.nhanviens, "id", "tennhanvien", phancong.idnhanvien);
            ViewBag.idnhiemvu = new SelectList(db.nhiemvus, "id", "tennhiemvu", phancong.idnhiemvu);
            return View(phancong);
        }

        // GET: phancongs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phancong phancong = db.phancongs.Find(id);
            if (phancong == null)
            {
                return HttpNotFound();
            }
            return View(phancong);
        }

        // POST: phancongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            phancong phancong = db.phancongs.Find(id);
            db.phancongs.Remove(phancong);
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
