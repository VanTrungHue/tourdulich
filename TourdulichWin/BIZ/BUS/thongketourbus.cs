using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

using System.Windows.Forms;
using System.Data.Entity;

namespace BIZ.BUS
{
    public class thongketourbus
    {
        tourdulichEntities db = new tourdulichEntities();
        thongkechiphibus tkcpb = new thongkechiphibus();
        
       public List<chitietdoanhthu>listthongkedoanhthu(int idtourdulich,DateTime tungay,DateTime dennngay)
        {
            var doan = db.doanduliches.Where(o => o.idtour == idtourdulich && o.ngaykhoihanh >= tungay.Date && o.ngaykhoihanh <= dennngay.Date);
            List<chitietdoanhthu> ct = new List<chitietdoanhthu>();
                foreach(doandulich d in doan)
            {
                chitietdoanhthu c = new chitietdoanhthu();
                c.tendoan = d.tendoan;
                c.tentour = d.tour.tentour;
                c.gia = (decimal)db.giatours.OrderByDescending(o => o.id).FirstOrDefault(o => o.tungay <= d.ngaykhoihanh && o.denngay >= d.ngaykhoihanh && o.idtour == idtourdulich).gia;
                c.soluongkhach = db.chitietdoanduliches.Where(o => o.iddoandulich == d.id).Count();
                c.tong = c.gia * c.soluongkhach;
                c.tongchiphi = tkcpb.tongchiphi(d.id);
                c.doanhthu = c.tong - c.tongchiphi;
                ct.Add(c);
            }
            return ct;
        }
        public decimal tongdoanhthu(int idtour)
        {
            decimal tong = 0;
            var doan = db.doanduliches.Where(o => o.idtour == idtour);
            foreach (doandulich d in doan)
            {
                decimal gia = (decimal)db.giatours.OrderByDescending(o => o.id)
                    .FirstOrDefault(o => o.tungay <= d.ngaykhoihanh &&
                    o.denngay >= d.ngaykhoihanh &&
                    o.idtour == idtour).gia;
                int soluongkhach = db.chitietdoanduliches.Where(o => o.iddoandulich == d.id).Count();
                tong += gia * soluongkhach;
            }
            return tong;
        }
        public List<tinhhinhhoatdongcuatour>tinhhinhhoatdong()
        {
            List<tinhhinhhoatdongcuatour> thhdct = new List<tinhhinhhoatdongcuatour>();
            var tour = db.tours.ToList();
            foreach(tour t in tour)
            {
                tinhhinhhoatdongcuatour th = new tinhhinhhoatdongcuatour();
                th.tentour = t.tentour;
                var doan = db.doanduliches.Where(o => o.idtour == t.id);
                th.soluongdoandulich = doan.Count();
                th.tongchiphi = tkcpb.tongchiphi(doan);
                th.tong = tongdoanhthu(t.id);
                th.tongdoanhthu = th.tong - th.tongchiphi;
                thhdct.Add(th);
            }
            return thhdct;
        }
    }
}
