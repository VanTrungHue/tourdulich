namespace TourdulichWin
{
    partial class chitietdiemthamquanfrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbtour = new System.Windows.Forms.ComboBox();
            this.cbdd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.drvctdtq = new System.Windows.Forms.DataGridView();
            this.pnct = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drvctdtq)).BeginInit();
            this.pnct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chi tiết điểm tham quan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên tour :";
            // 
            // cbtour
            // 
            this.cbtour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtour.FormattingEnabled = true;
            this.cbtour.Location = new System.Drawing.Point(301, 72);
            this.cbtour.Name = "cbtour";
            this.cbtour.Size = new System.Drawing.Size(260, 32);
            this.cbtour.TabIndex = 22;
            // 
            // cbdd
            // 
            this.cbdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdd.FormattingEnabled = true;
            this.cbdd.Location = new System.Drawing.Point(301, 130);
            this.cbdd.Name = "cbdd";
            this.cbdd.Size = new System.Drawing.Size(260, 32);
            this.cbdd.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên địa điểm :";
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(438, 189);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 35);
            this.btnthem.TabIndex = 25;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // drvctdtq
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvctdtq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.drvctdtq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drvctdtq.DefaultCellStyle = dataGridViewCellStyle2;
            this.drvctdtq.Location = new System.Drawing.Point(9, 230);
            this.drvctdtq.Name = "drvctdtq";
            this.drvctdtq.Size = new System.Drawing.Size(689, 245);
            this.drvctdtq.TabIndex = 26;
            // 
            // pnct
            // 
            this.pnct.Controls.Add(this.label1);
            this.pnct.Controls.Add(this.drvctdtq);
            this.pnct.Controls.Add(this.label2);
            this.pnct.Controls.Add(this.btnthem);
            this.pnct.Controls.Add(this.cbtour);
            this.pnct.Controls.Add(this.cbdd);
            this.pnct.Controls.Add(this.label3);
            this.pnct.Location = new System.Drawing.Point(12, 12);
            this.pnct.Name = "pnct";
            this.pnct.Size = new System.Drawing.Size(723, 590);
            this.pnct.TabIndex = 27;
            // 
            // chitietdiemthamquanfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(747, 614);
            this.Controls.Add(this.pnct);
            this.Name = "chitietdiemthamquanfrm";
            this.Text = "chitietdiemthamquanfrm";
            ((System.ComponentModel.ISupportInitialize)(this.drvctdtq)).EndInit();
            this.pnct.ResumeLayout(false);
            this.pnct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtour;
        private System.Windows.Forms.ComboBox cbdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView drvctdtq;
        private System.Windows.Forms.Panel pnct;
    }
}