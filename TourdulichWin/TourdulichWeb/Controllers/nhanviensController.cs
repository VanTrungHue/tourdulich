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
    public class nhanviensController : Controller
    {
        private tourdulichEntities db = new tourdulichEntities();

        // GET: nhanviens
        public ActionResult Index()
        {
            var nhanviens = db.nhanviens.Include(n => n.gioitinh1);
            return View(nhanviens.ToList());
        }

        // GET: nhanviens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhanvien nhanvien = db.nhanviens.Find(id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien);
        }

        // GET: nhanviens/Create
        public ActionResult Create()
        {
            ViewBag.gioitinh = new SelectList(db.gioitinhs, "id", "tengioitinh");
            return View();
        }

        // POST: nhanviens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tennhanvien,socmnd,diachi,gioitinh,sodienthoai")] nhanvien nhanvien)
        {
            if (ModelState.IsValid)
            {
                db.nhanviens.Add(nhanvien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.gioitinh = new SelectList(db.gioitinhs, "id", "tengioitinh", nhanvien.gioitinh);
            return View(nhanvien);
        }

        // GET: nhanviens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhanvien nhanvien = db.nhanviens.Find(id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.gioitinh = new SelectList(db.gioitinhs, "id", "tengioitinh", nhanvien.gioitinh);
            return View(nhanvien);
        }

        // POST: nhanviens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tennhanvien,socmnd,diachi,gioitinh,sodienthoai")] nhanvien nhanvien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanvien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.gioitinh = new SelectList(db.gioitinhs, "id", "tengioitinh", nhanvien.gioitinh);
            return View(nhanvien);
        }

        // GET: nhanviens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhanvien nhanvien = db.nhanviens.Find(id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien);
        }

        // POST: nhanviens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nhanvien nhanvien = db.nhanviens.Find(id);
            db.nhanviens.Remove(nhanvien);
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
