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
    public class tinhthanhbus
    {
        private tourdulichEntities db = new tourdulichEntities();
        public List<tinhthanh> loadtt()
        {
            var list = db.tinhthanhs.ToList();
            return list;
        }
        public bool them(string matt,string tentt)
        {
            try
            {
                tinhthanh t = new tinhthanh();
                t.matt = matt;
                t.tentt = tentt;
                db.tinhthanhs.Add(t);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex);
                return false;
            }
        }
        public bool sua(int id,string matt,string tentt)
        {
            try
            {
                tinhthanh t = db.tinhthanhs.First(o => o.id == id);
                t.matt = matt;
                t.tentt = tentt;
                db.Entry(t).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
                return false;
            }
        }
    }
}
