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
    public partial class tourfrm : Form
    {
        private int currentid;
        tourbus tour = new tourbus();
        public tourfrm()
        {
            InitializeComponent();
            drvtour.DataSource = tour.loadtour();
            drvtour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cblh.DataSource = tour.loadlh();
            cblh.DisplayMember = "tenloaihinh";
            cblh.ValueMember = "id";
            btnsua.Visible = false;
            btnhuy.Visible = false;
        }
        public void loadtourdl()
        {
            drvtour.DataSource = tour.loadtour();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string dd = txtdd.Text;
            int iddl = Convert.ToInt32(cblh.SelectedValue);
            bool s = tour.them(ten, dd, iddl);
            helper.successorerror(s);
            if(s)
            {
                helper.ClearOnlyTextBoxes(pntour);
                loadtourdl();
            }
        }

        private void drvtour_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnhuy.Visible = true;
            btnsua.Visible = true;
            btnthem.Visible = false;
            if(drvtour.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow rows in drvtour.SelectedRows)
                {
                    currentid = Convert.ToInt32(rows.Cells[0].Value.ToString());
                    txtten.Text = rows.Cells[1].Value.ToString();
                    txtdd.Text = rows.Cells[2].Value.ToString();
                    cblh.Text = rows.Cells[3].Value.ToString();

                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string dd = txtdd.Text;
            int iddl = Convert.ToInt32(cblh.SelectedValue);
            bool s = tour.sua(currentid,ten, dd, iddl);
            helper.successorerror(s);
            if(s)
            {
                exiteditingmode();
                loadtourdl();
            }
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }
        private void exiteditingmode()
        {
            helper.ClearOnlyTextBoxes(pntour);
            btnthem.Visible = true;
            btnsua.Visible = false;
            btnhuy.Visible = false;
            currentid = -1;
        }
    }
}
