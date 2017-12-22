using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIZ.BUS;
using ENTITIES;
namespace TourdulichWeb.Controllers
{
    public class thongkechiphiController : Controller
    {
        thongkechiphibus tk = new thongkechiphibus();
        tourdulichEntities db = new tourdulichEntities();
        chitietthanhtoanbus cttt = new chitietthanhtoanbus();
        // GET: thongkechiphi
        public ActionResult Index(string iddoandulich, string idloaiphieu)
        {
            int j, iddl;
            List<chitietthanhtoan> cts = null;

            if (int.TryParse(idloaiphieu, out j) && int.TryParse(iddoandulich, out iddl))
            {
                if (j == 5) cts = tk.chiphi(iddl);
                else cts = tk.chiphi(iddl, j);
            }
            thongkechiphi thongke = new thongkechiphi(cts, j);
            ViewBag.iddoandulich = new SelectList(db.doanduliches, "id", "tendoan");
            ViewBag.idloaiphieu = new SelectList(cttt.listnew(), "id", "tenloaiphieu");
            return View(thongke);
        }
    }
}