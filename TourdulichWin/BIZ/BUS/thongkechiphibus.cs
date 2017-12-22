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


    public class thongkechiphibus
    {
        tourdulichEntities db = new tourdulichEntities();
        public decimal tongchiphi(int iddoandulich)
        {
            return (decimal)db.chitietthanhtoans.Where(c => c.phieuthanhtoan.doandulich.id == iddoandulich).Sum(c => c.soluong * c.gia);
        }
        public decimal tongchiphi(IEnumerable<doandulich> ddls)
        {
            decimal tong = 0;
            foreach (doandulich ddl in ddls)
            {
                tong += tongchiphi(ddl.id);
            }
            return tong;
        }
        public List<chitietthanhtoan> chiphi(int iddoandulich,int i)
        {
            var list = db.chitietthanhtoans.Where(o => o.phieuthanhtoan.iddoandulich == iddoandulich && o.phieuthanhtoan.idloaiphieu == i);
            return list.ToList();
        }
        public List<chitietthanhtoan> chiphi(int iddoandulich)
        {
            var list = db.chitietthanhtoans.Where(o => o.phieuthanhtoan.iddoandulich == iddoandulich).OrderBy(o => o.phieuthanhtoan.loaiphieu.id);
            return list.ToList();
        }
     
    }
}
