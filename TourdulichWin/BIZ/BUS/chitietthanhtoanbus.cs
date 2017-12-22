using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ENTITIES;
namespace BIZ.BUS
{
    public class chitietthanhtoanbus
    {
        tourdulichEntities db = new tourdulichEntities();
        public List<phieuthanhtoan> getidphieu(int id)
        {
            var list = db.phieuthanhtoans.Where(o => o.id == id);
            return list.ToList();
        }
        public List<chitietthanhtoan> showlist(int id)
        {
            var list = db.chitietthanhtoans.Where(o => o.phieuthanhtoan.iddoandulich==id);
            return list.ToList();
        }
        public List<loaiphieu> listnew()
        {
            loaiphieu l = new loaiphieu();
            l.id = 5;
            l.tenloaiphieu = "Tổng chi phí";
            var loaiphieus = db.loaiphieux.ToList();
            loaiphieus.Add(l);
            return loaiphieus;
        }
        public bool them(chitietthanhtoan ct )
        {
            db.chitietthanhtoans.Add(ct);
            db.SaveChanges();
            return true;
        }
        public bool sua(chitietthanhtoan ct)
        {
            db.Entry(ct).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}
