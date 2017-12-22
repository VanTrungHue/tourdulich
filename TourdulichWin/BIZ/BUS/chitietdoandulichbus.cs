using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;

namespace BIZ.BUS
{
    public class chitietdoandulichbus
    {
        tourdulichEntities db = new tourdulichEntities();
        public List<chitietdoandulich> showlist(int iddoanr)
        {
            var list = db.chitietdoanduliches.Where(o => o.doandulich.id == iddoanr);
            return list.ToList();
        }
    }
}
