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
    public class tourbus
    {
        private tourdulichEntities db = new tourdulichEntities();
        public List<tour> loadtour()
        {
            var list = db.tours.ToList();
            return list;
        }
        public List<loaihinhdulich> loadlh()
        {
            var list = db.loaihinhduliches.ToList();
            return list;
        }
        public bool them(string ten, string dd,int id)
        {
            try
            {
                tour t = new tour();

                t.tentour = ten;
                t.dacdiem = dd;
                t.idlh = id;
                db.tours.Add(t);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
                return false;
            }
        }
        public bool sua(int id,string ten,string dd, int iddl)
        {
            try
            {
                tour t = db.tours.First(o => o.id == id);
                t.tentour = ten;
                t.dacdiem = dd;
                t.idlh = iddl;
                db.Entry(t).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex);
                return false;
            }
        }
    }
}
