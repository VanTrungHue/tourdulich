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
   public class chitietdiemthamquanbus
    {
        private tourdulichEntities db = new tourdulichEntities();
        public List<chitietdiemthamquan> load()
        {
            var list = db.chitietdiemthamquans.ToList();
            return list;
        }
        public List<tour> loadtour()
        {
            var list = db.tours.ToList();
            return list;
        }
        public List<diadiem> loaddd()
        {
            var list = db.diadiems.ToList();
            return list;
        }
        public bool them(int idtour, int iddiadiem)
        {
            try
            {
                chitietdiemthamquan c = new chitietdiemthamquan();
                c.idtour = idtour;
                c.iddiadiem = iddiadiem;
                db.chitietdiemthamquans.Add(c);
                db.SaveChanges();
                
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex);
                return false;
            }
        }

    }
}
