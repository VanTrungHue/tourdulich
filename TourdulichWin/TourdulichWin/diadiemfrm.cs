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
    public partial class diadiemfrm : Form
    {
        diadiembus d = new diadiembus();
        private int currentid;
        public diadiemfrm()
        {
            InitializeComponent();
            drvdd.DataSource = d.load();
            drvdd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbtt.DisplayMember = "tentt";
            cbtt.ValueMember = "id";
            cbtt.DataSource = d.loadtt();
            btnhuy.Visible = false;
            btnsua.Visible = false;
        }
        #region method
        private void loaddd()
        {
            drvdd.DataSource = d.load();
        }
        private void exiteditingmode()
        {
            helper.ClearOnlyTextBoxes(pndd);
            btnthem.Visible = true;
            btnsua.Visible = false;
            btnhuy.Visible = false;
            currentid = -1;
        }
        #endregion
        private void btnthem_Click(object sender, EventArgs e)
        {
            string tendd = txtdd.Text;
            int idtt = Convert.ToInt32(cbtt.SelectedValue);
            bool s = d.them(tendd, idtt);
            helper.successorerror(s);
            if(s)
            {
                helper.ClearOnlyTextBoxes(pndd);
                loaddd();
            }
        }

        private void drvdd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnhuy.Visible = true;
            btnsua.Visible = true;
            btnthem.Visible = false;
            if (drvdd.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow rows in drvdd.SelectedRows)
                {
                    currentid = Convert.ToInt32(rows.Cells[0].Value.ToString());
                    txtdd.Text= rows.Cells[1].Value.ToString();
                    cbtt.Text =rows.Cells[2].Value.ToString();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string tendd = txtdd.Text;
            int idtt = Convert.ToInt32(cbtt.SelectedValue);
            bool s = d.sua(currentid, tendd, idtt);
            helper.successorerror(s);
            if(s)
            {
                helper.ClearOnlyTextBoxes(pndd);
                loaddd();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }
    }
}
