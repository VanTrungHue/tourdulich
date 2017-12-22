using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class thongkechiphi
    {

        public string tenloaiphieu { get; set; }
        public List<chitietthanhtoan> ctcps { get; set; }
        public string tong { get; set; }
        public thongkechiphi(List<chitietthanhtoan> cts, int i)
        {
            ctcps = cts;
            switch (i)
            {
                case 1: tenloaiphieu = "Phiếu thanh toán cho khách sạn"; break;
                case 2: tenloaiphieu = "Phiếu thanh toán cho các bữa ăn"; break;
                case 3: tenloaiphieu = "Phiếu thanh toán cho các phương tiện"; break;
                case 4: tenloaiphieu = "Phiếu thanh toán cho chi phí khác"; break;
                case 5: tenloaiphieu = "Tổng các chi phí"; break;
            }
            decimal tongs = 0;
            if (cts != null)
            {
                foreach (chitietthanhtoan ct in ctcps)
                {
                    decimal gia = (decimal)ct.gia;
                    int sl = (int)ct.soluong;
                    ct.tongs = sl * gia;
                    tongs += ct.tongs;
                }
            }
            tong = String.Format("{0:C}", tongs);
        }
    }
}
