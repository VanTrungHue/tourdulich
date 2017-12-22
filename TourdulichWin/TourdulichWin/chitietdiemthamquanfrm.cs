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
    public partial class chitietdiemthamquanfrm : Form
    {
        chitietdiemthamquanbus ct = new chitietdiemthamquanbus();
        public chitietdiemthamquanfrm()
        {
            InitializeComponent();
            
            drvctdtq.DataSource = ct.load();
            drvctdtq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbtour.DataSource = ct.loadtour();
            cbtour.DisplayMember = "tentour";
            cbtour.ValueMember = "id";
            cbdd.DataSource = ct.loaddd();
            cbdd.DisplayMember = "tendiadiem";
            cbdd.ValueMember = "id";
        }
        public void loadct()
        {
            drvctdtq.DataSource = ct.load();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            int idtour = Convert.ToInt32(cbtour.SelectedValue);
            int iddd = Convert.ToInt32(cbdd.SelectedValue);
            bool s = ct.them(idtour, iddd);
            helper.successorerror(s);
            if(s)
            {
                helper.ClearOnlyTextBoxes(pnct);
                loadct();
            }
        }
    }
}
