using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIZ.BUS;
using ENTITIES;
using System.Data;
using System.Data.Entity;
using System.Linq;
using TourdulichWeb.Models;

namespace TourdulichWeb.Controllers
{
    public class thongkenhanvienController : Controller
    {
        // GET: thongkenhanvien
        nhanvienbus nv = new nhanvienbus();
        tourdulichEntities db = new tourdulichEntities();
        public ActionResult Index(string idnhanvien, string tungay, string denngay)
        {
            int id;
            List<solanditour> sls = null;
            DateTime startdate, enddate;
            if (int.TryParse(idnhanvien, out id) && DateTime.TryParse(tungay, out startdate) && DateTime.TryParse(denngay, out enddate))
            {
                sls = nv.thongkesolanditour(id, startdate, enddate);
            }
            thongkenhanvienviewmodel tknvvm = new thongkenhanvienviewmodel();
            tknvvm.sldts = sls;
            ViewBag.idnhanvien = new SelectList(db.nhanviens, "id", "socmnd_tennv");
            return View(tknvvm);
        }
    }
}