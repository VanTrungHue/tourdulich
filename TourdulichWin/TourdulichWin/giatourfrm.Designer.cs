namespace TourdulichWin
{
    partial class giatourfrm
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
            this.btnthem = new System.Windows.Forms.Button();
            this.drvgt = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbten = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudgia = new System.Windows.Forms.NumericUpDown();
            this.dttungay = new System.Windows.Forms.DateTimePicker();
            this.dtdenngay = new System.Windows.Forms.DateTimePicker();
            this.btnhuy = new System.Windows.Forms.Button();
            this.pngt = new System.Windows.Forms.Panel();
            this.btnxem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drvgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudgia)).BeginInit();
            this.pngt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(428, 298);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 35);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // drvgt
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvgt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.drvgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drvgt.DefaultCellStyle = dataGridViewCellStyle6;
            this.drvgt.Location = new System.Drawing.Point(25, 352);
            this.drvgt.Name = "drvgt";
            this.drvgt.Size = new System.Drawing.Size(689, 245);
            this.drvgt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đến ngày :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Từ ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên tour :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giá tour";
            // 
            // cbten
            // 
            this.cbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbten.FormattingEnabled = true;
            this.cbten.Location = new System.Drawing.Point(291, 75);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(260, 32);
            this.cbten.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giá tour :";
            // 
            // nudgia
            // 
            this.nudgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudgia.Location = new System.Drawing.Point(291, 130);
            this.nudgia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudgia.Name = "nudgia";
            this.nudgia.Size = new System.Drawing.Size(260, 29);
            this.nudgia.TabIndex = 23;
            this.nudgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dttungay
            // 
            this.dttungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttungay.Location = new System.Drawing.Point(291, 186);
            this.dttungay.Name = "dttungay";
            this.dttungay.Size = new System.Drawing.Size(327, 29);
            this.dttungay.TabIndex = 24;
            // 
            // dtdenngay
            // 
            this.dtdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdenngay.Location = new System.Drawing.Point(291, 238);
            this.dtdenngay.Name = "dtdenngay";
            this.dtdenngay.Size = new System.Drawing.Size(327, 29);
            this.dtdenngay.TabIndex = 25;
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(591, 14);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(123, 35);
            this.btnhuy.TabIndex = 26;
            this.btnhuy.Text = "Hủy xem";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // pngt
            // 
            this.pngt.Controls.Add(this.btnxem);
            this.pngt.Controls.Add(this.label1);
            this.pngt.Controls.Add(this.btnhuy);
            this.pngt.Controls.Add(this.label2);
            this.pngt.Controls.Add(this.dtdenngay);
            this.pngt.Controls.Add(this.label3);
            this.pngt.Controls.Add(this.dttungay);
            this.pngt.Controls.Add(this.label4);
            this.pngt.Controls.Add(this.nudgia);
            this.pngt.Controls.Add(this.drvgt);
            this.pngt.Controls.Add(this.label5);
            this.pngt.Controls.Add(this.btnthem);
            this.pngt.Controls.Add(this.cbten);
            this.pngt.Location = new System.Drawing.Point(12, 12);
            this.pngt.Name = "pngt";
            this.pngt.Size = new System.Drawing.Size(723, 609);
            this.pngt.TabIndex = 27;
            // 
            // btnxem
            // 
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(177, 298);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(199, 35);
            this.btnxem.TabIndex = 27;
            this.btnxem.Text = "Xem giá tour hiện tại";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // giatourfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(747, 629);
            this.Controls.Add(this.pngt);
            this.Name = "giatourfrm";
            this.Text = "giatourfrm";
            ((System.ComponentModel.ISupportInitialize)(this.drvgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudgia)).EndInit();
            this.pngt.ResumeLayout(false);
            this.pngt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView drvgt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudgia;
        private System.Windows.Forms.DateTimePicker dttungay;
        private System.Windows.Forms.DateTimePicker dtdenngay;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Panel pngt;
        private System.Windows.Forms.Button btnxem;
    }
}