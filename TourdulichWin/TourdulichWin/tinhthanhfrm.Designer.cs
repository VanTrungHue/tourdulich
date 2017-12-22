namespace TourdulichWin
{
    partial class tinhthanhfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttentt = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.drvtt = new System.Windows.Forms.DataGridView();
            this.pntt = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drvtt)).BeginInit();
            this.pntt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tỉnh thành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã tỉnh thành :";
            // 
            // txtmatt
            // 
            this.txtmatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatt.Location = new System.Drawing.Point(294, 76);
            this.txtmatt.Name = "txtmatt";
            this.txtmatt.Size = new System.Drawing.Size(260, 29);
            this.txtmatt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên tỉnh thành :";
            // 
            // txttentt
            // 
            this.txttentt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentt.Location = new System.Drawing.Point(294, 138);
            this.txttentt.Name = "txttentt";
            this.txttentt.Size = new System.Drawing.Size(260, 29);
            this.txttentt.TabIndex = 6;
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(431, 197);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(123, 35);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(294, 197);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 35);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // drvtt
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvtt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.drvtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drvtt.DefaultCellStyle = dataGridViewCellStyle6;
            this.drvtt.Location = new System.Drawing.Point(14, 258);
            this.drvtt.Name = "drvtt";
            this.drvtt.Size = new System.Drawing.Size(689, 245);
            this.drvtt.TabIndex = 13;
            this.drvtt.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.drvtt_CellMouseDoubleClick);
            // 
            // pntt
            // 
            this.pntt.Controls.Add(this.btnhuy);
            this.pntt.Controls.Add(this.label1);
            this.pntt.Controls.Add(this.drvtt);
            this.pntt.Controls.Add(this.label2);
            this.pntt.Controls.Add(this.btnsua);
            this.pntt.Controls.Add(this.txtmatt);
            this.pntt.Controls.Add(this.btnthem);
            this.pntt.Controls.Add(this.label3);
            this.pntt.Controls.Add(this.txttentt);
            this.pntt.Location = new System.Drawing.Point(12, 12);
            this.pntt.Name = "pntt";
            this.pntt.Size = new System.Drawing.Size(723, 590);
            this.pntt.TabIndex = 14;
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(580, 12);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(123, 35);
            this.btnhuy.TabIndex = 14;
            this.btnhuy.Text = "Hủy sửa";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // tinhthanhfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(747, 614);
            this.Controls.Add(this.pntt);
            this.Name = "tinhthanhfrm";
            this.Text = "tinhthanhfrm";
            ((System.ComponentModel.ISupportInitialize)(this.drvtt)).EndInit();
            this.pntt.ResumeLayout(false);
            this.pntt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttentt;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView drvtt;
        private System.Windows.Forms.Panel pntt;
        private System.Windows.Forms.Button btnhuy;
    }
}