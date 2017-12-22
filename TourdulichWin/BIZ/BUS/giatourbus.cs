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
    public class giatourbus
    {
        private tourdulichEntities db = new tourdulichEntities();
        public List<giatour> load()
        {
            var list = db.giatours.ToList();
            return list;
        }
        public List<tour> loadtour()
        {
            var list = db.tours.ToList();
            return list;
        }
        public  List<giatour> listgiatourhientai()
        {
            DateTime a = DateTime.Now;
            List<giatour> gts = new List<giatour>();
            foreach(tour t in db.tours)
            {
                giatour gt = new giatour();
                if (db.giatours.Any(o => o.tungay < a && o.denngay > a && o.idtour == t.id))
                {
                    gt = db.giatours.Where(o => o.tungay < a && o.denngay > a && o.idtour == t.id).OrderByDescending(o => o.id).FirstOrDefault();
                }
                else
                {
                    gt.id = 0;
                    gt.tentour = t.tentour;
                    gt.gia = 0;
                    gt.tungay = a;
                    gt.denngay = a;
                }
                gts.Add(gt);
            }
            return gts;
        }
        public bool them(int idtour,decimal gia,DateTime tungay , DateTime denngay)
        {
            try { 
                giatour g = new giatour();
                g.idtour = idtour;
                g.gia = gia;
                g.tungay = tungay;
                g.denngay = denngay;
                db.giatours.Add(g);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex);
                return false;
            }
        }
        public bool sua(int id, int idtour, decimal gia, DateTime tungay, DateTime denngay)
        {
            try
            {
                giatour g = db.giatours.First(o => o.id == id);
                g.idtour = idtour;
                g.gia = gia;
                g.tungay = tungay;
                g.denngay = denngay;
                db.Entry(g).State = EntityState.Modified;
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
