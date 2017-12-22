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
    public class doandulichbus
    {
        tourdulichEntities db = new tourdulichEntities();
        public List<khachhang> listkh()
        {
            var list = db.khachhangs.ToList();
            return list;
        }

        public bool them(doandulich ddl)
        {
            db.doanduliches.Add(ddl);
            db.SaveChanges();
            return true;
        }
        public bool sua(doandulich ddl)
        {
            try
            {
                db.Entry(ddl).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex);
                return false;
            }
        }
    }
}
