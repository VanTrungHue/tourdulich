using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
namespace BIZ.BUS
{
    public class nhanvienbus
    {
        tourdulichEntities db = new tourdulichEntities();
        public List<nhanvien> loadnv()
        {
            var list = db.nhanviens.ToList();
            return list;
        }
        public List<solanditour> thongkesolanditour(int id,DateTime tungay,DateTime denngay)
        {
            List<solanditour> sldts = new List<solanditour>();
            string tennv = db.nhanviens.Where(o => o.id == id).FirstOrDefault().tennhanvien;
            
            foreach(tour t in db.tours)
            {
                solanditour sl = new solanditour();
                sl.tennv = tennv;
                sl.tentour = t.tentour;
                sl.solan = (from pc in db.phancongs
                           where (pc.doandulich.idtour == t.id
                           && pc.idnhanvien == id
                           && pc.doandulich.ngaykhoihanh >= tungay
                           && pc.doandulich.ngaykhoihanh <= denngay)
                           select pc.doandulich.id).Distinct().Count();
               
                sldts.Add(sl);
            }
            return sldts;
        }
    }
}
