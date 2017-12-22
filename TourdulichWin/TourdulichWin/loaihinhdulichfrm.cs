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
using ENTITIES;

namespace TourdulichWin
{
    public partial class loaihinhdulichfrm : Form
    {
        private int currentid ;
        loaihinhdulichbus lh = new loaihinhdulichbus();
        public loaihinhdulichfrm()
        {
            InitializeComponent();
            drvlh.DataSource = lh.loadloaihinh();
            drvlh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnsua.Visible = false;
            btnhuy.Visible = false;
        }
        #region method
        public void loadlh()
        {
            drvlh.DataSource = lh.loadloaihinh();
        }
        private void exiteditingmode()
        {
            helper.ClearOnlyTextBoxes(pnloaihinh);
            btnthem.Visible = true;
            btnsua.Visible = false;
            btnhuy.Visible = false;
            currentid = -1;
        }
        #endregion
        #region event
        private void btnthem_Click(object sender, EventArgs e)
        {
           
            string ten = txtlh.Text;
            bool s = lh.them(ten);
            helper.successorerror(s);
            if (s)
            {
                helper.ClearOnlyTextBoxes(pnloaihinh);
                
                loadlh();
            }
            
        }
        

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ten = txtlh.Text;
            bool s = lh.sua(currentid, ten);
            helper.successorerror(s);
            if(s)
            {
                exiteditingmode();
                
                loadlh();
                
            }
           
        }

       

        private void drvlh_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            btnsua.Visible = true;
            btnhuy.Visible = true;
            btnthem.Visible = false;
            if (drvlh.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in drvlh.SelectedRows)
                {
                    currentid = Convert.ToInt32(row.Cells[0].Value.ToString());
                    txtlh.Text = row.Cells[1].Value.ToString();

                }
                   
            }
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            exiteditingmode();
        }
        #endregion


    }
}
