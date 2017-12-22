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
    public class phieuthanhtoansController : Controller
    {
        private tourdulichEntities db = new tourdulichEntities();
        phieuthanhtoanbus p = new phieuthanhtoanbus();
        // GET: phieuthanhtoans
        public ActionResult Index(string iddoan)
        {
            int id;
            if(Int32.TryParse(iddoan,out id))
            {
                var list = p.showlist(id);
                ViewBag.iddoan = new SelectList(db.doanduliches, "id", "tendoan");
                return View(list);
            }
            var phieuthanhtoans = db.phieuthanhtoans.Include(p => p.doandulich).Include(p => p.loaiphieu);
            ViewBag.iddoan = new SelectList(db.doanduliches, "id", "tendoan");
            return View(phieuthanhtoans.ToList());
        }

        // GET: phieuthanhtoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phieuthanhtoan phieuthanhtoan = db.phieuthanhtoans.Find(id);
            if (phieuthanhtoan == null)
            {
                return HttpNotFound();
            }
            return View(phieuthanhtoan);
        }

        // GET: phieuthanhtoans/Create
        public ActionResult Create()
        {
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan");
            ViewBag.idloaiphieu = new SelectList(db.loaiphieux, "id", "tenloaiphieu");
            return View();
        }

        // POST: phieuthanhtoans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tenphieu,idloaiphieu,iddoandulich,ngaytao")] phieuthanhtoan phieuthanhtoan)
        {
            if (ModelState.IsValid)
            {
                p.them(phieuthanhtoan);
                return RedirectToAction("Index");
            }

            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", phieuthanhtoan.iddoandulich);
            ViewBag.idloaiphieu = new SelectList(db.loaiphieux, "id", "tenloaiphieu", phieuthanhtoan.idloaiphieu);
            return View(phieuthanhtoan);
        }

        // GET: phieuthanhtoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phieuthanhtoan phieuthanhtoan = db.phieuthanhtoans.Find(id);
            if (phieuthanhtoan == null)
            {
                return HttpNotFound();
            }
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", phieuthanhtoan.iddoandulich);
            ViewBag.idloaiphieu = new SelectList(db.loaiphieux, "id", "tenloaiphieu", phieuthanhtoan.idloaiphieu);
            return View(phieuthanhtoan);
        }

        // POST: phieuthanhtoans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tenphieu,idloaiphieu,iddoandulich,ngaytao")] phieuthanhtoan phieuthanhtoan)
        {
            if (ModelState.IsValid)
            {
                p.sua(phieuthanhtoan);
                return RedirectToAction("Index");
            }
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan", phieuthanhtoan.iddoandulich);
            ViewBag.idloaiphieu = new SelectList(db.loaiphieux, "id", "tenloaiphieu", phieuthanhtoan.idloaiphieu);
            return View(phieuthanhtoan);
        }

        // GET: phieuthanhtoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phieuthanhtoan phieuthanhtoan = db.phieuthanhtoans.Find(id);
            if (phieuthanhtoan == null)
            {
                return HttpNotFound();
            }
            return View(phieuthanhtoan);
        }

        // POST: phieuthanhtoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            phieuthanhtoan phieuthanhtoan = db.phieuthanhtoans.Find(id);
            db.phieuthanhtoans.Remove(phieuthanhtoan);
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
