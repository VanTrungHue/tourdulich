namespace TourdulichWin
{
    partial class diadiemfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtt = new System.Windows.Forms.ComboBox();
            this.pndd = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            this.drvdd = new System.Windows.Forms.DataGridView();
            this.pndd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(454, 203);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(123, 35);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(317, 203);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 35);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thuộc tỉnh :";
            // 
            // txtdd
            // 
            this.txtdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdd.Location = new System.Drawing.Point(317, 82);
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(260, 29);
            this.txtdd.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên địa điểm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Địa điểm";
            // 
            // cbtt
            // 
            this.cbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtt.FormattingEnabled = true;
            this.cbtt.Location = new System.Drawing.Point(317, 139);
            this.cbtt.Name = "cbtt";
            this.cbtt.Size = new System.Drawing.Size(260, 32);
            this.cbtt.TabIndex = 22;
            // 
            // pndd
            // 
            this.pndd.Controls.Add(this.btnhuy);
            this.pndd.Controls.Add(this.label1);
            this.pndd.Controls.Add(this.cbtt);
            this.pndd.Controls.Add(this.label2);
            this.pndd.Controls.Add(this.drvdd);
            this.pndd.Controls.Add(this.txtdd);
            this.pndd.Controls.Add(this.btnsua);
            this.pndd.Controls.Add(this.label3);
            this.pndd.Controls.Add(this.btnthem);
            this.pndd.Location = new System.Drawing.Point(12, 12);
            this.pndd.Name = "pndd";
            this.pndd.Size = new System.Drawing.Size(723, 590);
            this.pndd.TabIndex = 23;
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(585, 18);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(123, 35);
            this.btnhuy.TabIndex = 23;
            this.btnhuy.Text = "Hủy sửa";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // drvdd
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.drvdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drvdd.DefaultCellStyle = dataGridViewCellStyle6;
            this.drvdd.Location = new System.Drawing.Point(19, 264);
            this.drvdd.Name = "drvdd";
            this.drvdd.Size = new System.Drawing.Size(689, 245);
            this.drvdd.TabIndex = 21;
            this.drvdd.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drvdd_CellMouseDoubleClick);
            // 
            // diadiemfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(747, 614);
            this.Controls.Add(this.pndd);
            this.Name = "diadiemfrm";
            this.Text = "diadiemfrm";
            this.pndd.ResumeLayout(false);
            this.pndd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtt;
        private System.Windows.Forms.Panel pndd;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.DataGridView drvdd;
    }
}