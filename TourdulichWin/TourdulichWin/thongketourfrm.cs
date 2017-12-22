using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ.BUS;

namespace TourdulichWin
{
    public partial class thongketourfrm : Form
    {
        thongketourbus tk = new thongketourbus();
        giatourbus g = new giatourbus();
        public thongketourfrm()
        {
            InitializeComponent();
            cbtour.DataSource = g.loadtour();
            cbtour.DisplayMember = "tentour";
            cbtour.ValueMember = "id";
            drvtk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            int idtour = Convert.ToInt32(cbtour.SelectedValue);
            DateTime tungay = Convert.ToDateTime(dttungay.Value);
            DateTime denngay = Convert.ToDateTime(dtdenngay.Value);
            drvtk.DataSource = tk.listthongkedoanhthu(idtour, tungay, denngay);
        }
    }
}
