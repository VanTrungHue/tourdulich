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
    public partial class tinhthanhfrm : Form
    {
        private int currentid;
        tinhthanhbus t = new tinhthanhbus();
        public tinhthanhfrm()
        {
           
            InitializeComponent();
            drvtt.DataSource = t.loadtt();
            drvtt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnsua.Visible = false;
            btnhuy.Visible = false;
        }
        #region method
        private void loaddstt()
        {
            drvtt.DataSource = t.loadtt();
        }
        private void exiteditingmode()
        {
            helper.ClearOnlyTextBoxes(pntt);
            btnthem.Visible = true;
            btnsua.Visible = false;
            btnhuy.Visible = false;
            currentid = -1;
        }
        #endregion

        #region event


        private void btnthem_Click(object sender, EventArgs e)
        {
            string matt = txtmatt.Text;
            string tentt = txttentt.Text;
            bool s = t.them(matt, tentt);
            helper.successorerror(s);
            if(s)
            {
                helper.ClearOnlyTextBoxes(pntt);
                loaddstt();
            }
        }

        #endregion

        private void drvtt_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnhuy.Visible = true;
            btnsua.Visible = true;
            btnthem.Visible = false;
            if (drvtt.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in drvtt.SelectedRows)
                {
                    currentid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    txtmatt.Text = row.Cells[1].Value.ToString();
                    txttentt.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string matt = txtmatt.Text;
            string tentt = txttentt.Text;
            bool s = t.sua(currentid, matt, tentt);
            helper.successorerror(s);
            if(s)
            {
                helper.ClearOnlyTextBoxes(pntt);
                loaddstt();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }
    }
}
