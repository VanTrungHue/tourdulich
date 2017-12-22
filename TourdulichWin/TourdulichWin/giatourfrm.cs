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
    public partial class giatourfrm : Form
    {
        private int currentid;
        giatourbus g = new giatourbus();
        public giatourfrm()
        {
            InitializeComponent();
            drvgt.DataSource = g.load();
            drvgt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbten.DataSource = g.loadtour();
            cbten.DisplayMember= "tentour";
            cbten.ValueMember = "id";
           
            btnhuy.Visible = false;
        }
        private void loadgt()
        {
            drvgt.DataSource = g.load();
        }
        private void exiteditingmode()
        {
            helper.ClearOnlyTextBoxes(pngt);
            btnthem.Visible = true;
            
            btnhuy.Visible = false;
            currentid = -1;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int idtour = Convert.ToInt32(cbten.SelectedValue);
            int gia = Convert.ToInt32(nudgia.Value);
            DateTime tungay = dttungay.Value.Date;
            DateTime denngay = dtdenngay.Value.Date;
            bool s = g.them(idtour, gia, tungay, denngay);
            helper.successorerror(s);
            if(s)
            {
                helper.ClearOnlyTextBoxes(pngt);
                loadgt();
            }
        }

       

    

        private void btnhuy_Click(object sender, EventArgs e)
        {
            loadgt();
            btnhuy.Visible = false;
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            drvgt.DataSource = g.listgiatourhientai();
            btnhuy.Visible = true;
        }
    }
}
