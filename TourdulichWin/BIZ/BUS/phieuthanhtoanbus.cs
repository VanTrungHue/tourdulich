using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using System.Data.Entity;

namespace BIZ.BUS
{
    public class phieuthanhtoanbus
    {
        tourdulichEntities db = new tourdulichEntities();
        public List<phieuthanhtoan> showlist(int id)
        {
            var list = db.phieuthanhtoans.Where(o => o.iddoandulich == id);
            return list.ToList();
        }
        public bool them(phieuthanhtoan p)
        {
            db.phieuthanhtoans.Add(p);
            db.SaveChanges();
            return true;
        }
        public bool sua(phieuthanhtoan p)
        {
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}
