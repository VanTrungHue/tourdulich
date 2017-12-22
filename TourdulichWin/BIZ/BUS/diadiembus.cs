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
    public class diadiembus
    {
        private tourdulichEntities db = new tourdulichEntities();
        public List<diadiem>load()
        {
            var list = db.diadiems.ToList();
            return list;
        }
        public List<tinhthanh> loadtt()
        {
            var list = db.tinhthanhs.ToList();
            return list;
        }
        public bool them(string tendd , int idtt)
        {
            try
            {
                diadiem d = new diadiem();
                d.tendiadiem = tendd;
                d.idtt = idtt;
                db.diadiems.Add(d);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex);
                return false;
            }
            

        }
        public bool sua(int id,string tendd,int idtt)
        {
            try
            {
                diadiem d = db.diadiems.First(o => o.id == id);
                d.tendiadiem = tendd;
                d.idtt = idtt;
                db.Entry(d).State = EntityState.Modified;
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
