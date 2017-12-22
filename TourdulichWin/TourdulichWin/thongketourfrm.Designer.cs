namespace TourdulichWin
{
    partial class thongketourfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtdenngay = new System.Windows.Forms.DateTimePicker();
            this.dttungay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btntk = new System.Windows.Forms.Button();
            this.drvtk = new System.Windows.Forms.DataGridView();
            this.pntk = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drvtk)).BeginInit();
            this.pntk.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thống kê tour";
            // 
            // cbtour
            // 
            this.cbtour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtour.FormattingEnabled = true;
            this.cbtour.Location = new System.Drawing.Point(282, 57);
            this.cbtour.Name = "cbtour";
            this.cbtour.Size = new System.Drawing.Size(260, 32);
            this.cbtour.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên tour :";
            // 
            // dtdenngay
            // 
            this.dtdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdenngay.Location = new System.Drawing.Point(282, 164);
            this.dtdenngay.Name = "dtdenngay";
            this.dtdenngay.Size = new System.Drawing.Size(327, 29);
            this.dtdenngay.TabIndex = 29;
            // 
            // dttungay
            // 
            this.dttungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttungay.Location = new System.Drawing.Point(282, 112);
            this.dttungay.Name = "dttungay";
            this.dttungay.Size = new System.Drawing.Size(327, 29);
            this.dttungay.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Đến ngày :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Từ ngày :";
            // 
            // btntk
            // 
            this.btntk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntk.Location = new System.Drawing.Point(486, 213);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(123, 35);
            this.btntk.TabIndex = 30;
            this.btntk.Text = "Thống kê";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // drvtk
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvtk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.drvtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drvtk.DefaultCellStyle = dataGridViewCellStyle2;
            this.drvtk.Location = new System.Drawing.Point(19, 267);
            this.drvtk.Name = "drvtk";
            this.drvtk.Size = new System.Drawing.Size(689, 245);
            this.drvtk.TabIndex = 31;
            // 
            // pntk
            // 
            this.pntk.Controls.Add(this.label1);
            this.pntk.Controls.Add(this.drvtk);
            this.pntk.Controls.Add(this.label2);
            this.pntk.Controls.Add(this.btntk);
            this.pntk.Controls.Add(this.cbtour);
            this.pntk.Controls.Add(this.dtdenngay);
            this.pntk.Controls.Add(this.label3);
            this.pntk.Controls.Add(this.dttungay);
            this.pntk.Controls.Add(this.label4);
            this.pntk.Location = new System.Drawing.Point(12, 12);
            this.pntk.Name = "pntk";
            this.pntk.Size = new System.Drawing.Size(723, 590);
            this.pntk.TabIndex = 32;
            // 
            // thongketourfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(747, 614);
            this.Controls.Add(this.pntk);
            this.Name = "thongketourfrm";
            this.Text = "thongketourfrm";
            ((System.ComponentModel.ISupportInitialize)(this.drvtk)).EndInit();
            this.pntk.ResumeLayout(false);
            this.pntk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtdenngay;
        private System.Windows.Forms.DateTimePicker dttungay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.DataGridView drvtk;
        private System.Windows.Forms.Panel pntk;
    }
}