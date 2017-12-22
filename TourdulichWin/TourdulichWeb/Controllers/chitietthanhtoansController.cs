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
    public class chitietthanhtoansController : Controller
    {
        private tourdulichEntities db = new tourdulichEntities();
        chitietthanhtoanbus ct = new chitietthanhtoanbus();
        // GET: chitietthanhtoans
        public ActionResult Index(string iddoan)
        {
            int id;
            if(Int32.TryParse(iddoan,out id))
            {
                var list = ct.showlist(id).ToList();
                ViewBag.iddoan = new SelectList(db.doanduliches, "id", "tendoan");
                return View(list);
            }
            var chitietthanhtoans = db.chitietthanhtoans.Include(c => c.phieuthanhtoan);
            ViewBag.iddoan = new SelectList(db.doanduliches, "id", "tendoan");
            return View(chitietthanhtoans.ToList());
        }

        // GET: chitietthanhtoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chitietthanhtoan chitietthanhtoan = db.chitietthanhtoans.Find(id);
            if (chitietthanhtoan == null)
            {
                return HttpNotFound();
            }
            return View(chitietthanhtoan);
        }

        // GET: chitietthanhtoans/Create
        public ActionResult Create()
        {
            ViewBag.idphieuthanhtoan = new SelectList(db.phieuthanhtoans, "id", "tendoan_tenphieu");
            return View();
        }

        // POST: chitietthanhtoans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idphieuthanhtoan,idchitiet,tenchiphi,soluong,gia")] chitietthanhtoan chitietthanhtoan)
        {
            if (ModelState.IsValid)
            {
                ct.them(chitietthanhtoan);
                return RedirectToAction("Index");
            }

            ViewBag.idphieuthanhtoan = new SelectList(db.phieuthanhtoans, "id", "tendoan_tenphieu", chitietthanhtoan.idphieuthanhtoan);
            return View(chitietthanhtoan);
        }

        // GET: chitietthanhtoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chitietthanhtoan chitietthanhtoan = db.chitietthanhtoans.Find(id);
            if (chitietthanhtoan == null)
            {
                return HttpNotFound();
            }
            ViewBag.idphieuthanhtoan = new SelectList(db.phieuthanhtoans, "id", "tendoan_tenphieu", chitietthanhtoan.idphieuthanhtoan);
            return View(chitietthanhtoan);
        }

        // POST: chitietthanhtoans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idphieuthanhtoan,idchitiet,tenchiphi,soluong,gia")] chitietthanhtoan chitietthanhtoan)
        {
            if (ModelState.IsValid)
            {
               ct.sua(chitietthanhtoan);
                return RedirectToAction("Index");
            }
            ViewBag.idphieuthanhtoan = new SelectList(db.phieuthanhtoans, "id", "tendoan_tenphieu", chitietthanhtoan.idphieuthanhtoan);
            return View(chitietthanhtoan);
        }

        // GET: chitietthanhtoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            chitietthanhtoan chitietthanhtoan = db.chitietthanhtoans.Find(id);
            if (chitietthanhtoan == null)
            {
                return HttpNotFound();
            }
            return View(chitietthanhtoan);
        }

        // POST: chitietthanhtoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            chitietthanhtoan chitietthanhtoan = db.chitietthanhtoans.Find(id);
            db.chitietthanhtoans.Remove(chitietthanhtoan);
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
