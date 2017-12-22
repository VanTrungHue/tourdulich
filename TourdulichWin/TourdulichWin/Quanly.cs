using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
namespace TourdulichWin
{
    public partial class Quanly : Form
    {
        loaihinhdulichbus lh = new loaihinhdulichbus();  
        public Quanly()
        {
            InitializeComponent();
        }

        private void btnloaihinh_Click(object sender, EventArgs e)
        {
            loaihinhdulichfrm a = new loaihinhdulichfrm();
            a.Show();
            lh.loadloaihinh();
        }

        private void btntour_Click(object sender, EventArgs e)
        {
            tourfrm a = new tourfrm();
            a.Show();

        }

        private void btntinhthanh_Click(object sender, EventArgs e)
        {
            tinhthanhfrm a = new tinhthanhfrm();
            a.Show();
        }

        private void btndiadiem_Click(object sender, EventArgs e)
        {
            diadiemfrm a = new diadiemfrm();
            a.Show();
        }

        private void btngiatour_Click(object sender, EventArgs e)
        {
            giatourfrm a = new giatourfrm();
            a.Show();
        }

        private void btnchitietdiemthamquan_Click(object sender, EventArgs e)
        {
            chitietdiemthamquanfrm a = new chitietdiemthamquanfrm();
            a.Show();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            thongketourfrm a = new thongketourfrm();
            a.Show();
        }

        private void btntinhhinh_Click(object sender, EventArgs e)
        {
            tinhhinhhoatdongcuatourfrm a = new tinhhinhhoatdongcuatourfrm();
            a.Show();
        }
    }
}
