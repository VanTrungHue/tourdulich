namespace TourdulichWin
{
    partial class loaihinhdulichfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtlh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.drvlh = new System.Windows.Forms.DataGridView();
            this.pnloaihinh = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drvlh)).BeginInit();
            this.pnloaihinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlh
            // 
            this.txtlh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlh.Location = new System.Drawing.Point(290, 63);
            this.txtlh.Name = "txtlh";
            this.txtlh.Size = new System.Drawing.Size(260, 29);
            this.txtlh.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên loại hình :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(259, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "Loại hình du lịch";
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(427, 116);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(123, 35);
            this.btnsua.TabIndex = 22;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(290, 116);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 35);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // drvlh
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvlh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.drvlh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drvlh.DefaultCellStyle = dataGridViewCellStyle4;
            this.drvlh.Location = new System.Drawing.Point(2, 222);
            this.drvlh.Name = "drvlh";
            this.drvlh.Size = new System.Drawing.Size(689, 245);
            this.drvlh.TabIndex = 23;
            this.drvlh.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drvlh_CellMouseDoubleClick);
            // 
            // pnloaihinh
            // 
            this.pnloaihinh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnloaihinh.Controls.Add(this.btnhuy);
            this.pnloaihinh.Controls.Add(this.label11);
            this.pnloaihinh.Controls.Add(this.drvlh);
            this.pnloaihinh.Controls.Add(this.label2);
            this.pnloaihinh.Controls.Add(this.btnsua);
            this.pnloaihinh.Controls.Add(this.txtlh);
            this.pnloaihinh.Controls.Add(this.btnthem);
            this.pnloaihinh.Location = new System.Drawing.Point(12, 12);
            this.pnloaihinh.Name = "pnloaihinh";
            this.pnloaihinh.Size = new System.Drawing.Size(723, 590);
            this.pnloaihinh.TabIndex = 24;
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(568, 11);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(123, 35);
            this.btnhuy.TabIndex = 24;
            this.btnhuy.Text = "Hủy sửa";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // loaihinhdulichfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(747, 614);
            this.Controls.Add(this.pnloaihinh);
            this.Name = "loaihinhdulichfrm";
            this.Text = "loaihinhdulichfrm";
            ((System.ComponentModel.ISupportInitialize)(this.drvlh)).EndInit();
            this.pnloaihinh.ResumeLayout(false);
            this.pnloaihinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtlh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView drvlh;
        private System.Windows.Forms.Panel pnloaihinh;
        private System.Windows.Forms.Button btnhuy;
    }
}