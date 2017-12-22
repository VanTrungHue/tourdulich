using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using System.Windows.Forms;
using System.Data.Entity;

namespace BIZ
{
    
    public class loaihinhdulichbus
    {
        private tourdulichEntities db = new tourdulichEntities();
        public List<loaihinhdulich> loadloaihinh()
        {
            var list = (from loaihinh in db.loaihinhduliches
                        select new
                        {
                            id = loaihinh.id,
                            tenloaihinh = loaihinh.tenloaihinh
                        }).ToList().Select(c => new loaihinhdulich
                        {
                            id = c.id,
                            tenloaihinh = c.tenloaihinh
            }).ToList();

                       
            return list.ToList();
                
        }
        public bool them(string ten)
        {
            
            try
            {
                loaihinhdulich lh = new loaihinhdulich();
                lh.tenloaihinh = ten;
                db.loaihinhduliches.Add(lh);
                db.SaveChanges();
                
               
                return true;
             }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : "+ex);
                return false;
            }
        }
        public bool sua(int id,string ten)
        {
            try
            {
                loaihinhdulich lh = db.loaihinhduliches.First(c => c.id == id);
                lh.tenloaihinh = ten;
                db.Entry(lh).State = EntityState.Modified;
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
