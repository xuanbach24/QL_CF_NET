namespace QL_CF
{
    partial class frm_thongtin
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_slbanra = new System.Windows.Forms.Button();
            this.btn_tongtien = new System.Windows.Forms.Button();
            this.btn_capnhatLnv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(821, 362);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_slbanra
            // 
            this.btn_slbanra.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_slbanra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slbanra.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_slbanra.Location = new System.Drawing.Point(115, 99);
            this.btn_slbanra.Name = "btn_slbanra";
            this.btn_slbanra.Size = new System.Drawing.Size(237, 44);
            this.btn_slbanra.TabIndex = 2;
            this.btn_slbanra.Text = "Số Lượng Bán Ra Trong Tháng";
            this.btn_slbanra.UseVisualStyleBackColor = false;
            this.btn_slbanra.Click += new System.EventHandler(this.btn_slbanra_Click);
            // 
            // btn_tongtien
            // 
            this.btn_tongtien.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_tongtien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tongtien.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_tongtien.Location = new System.Drawing.Point(473, 99);
            this.btn_tongtien.Name = "btn_tongtien";
            this.btn_tongtien.Size = new System.Drawing.Size(242, 44);
            this.btn_tongtien.TabIndex = 3;
            this.btn_tongtien.Text = "Tổng Tiền Từng Đơn Hàng";
            this.btn_tongtien.UseVisualStyleBackColor = false;
            this.btn_tongtien.Click += new System.EventHandler(this.btn_tongtien_Click);
            // 
            // btn_capnhatLnv
            // 
            this.btn_capnhatLnv.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_capnhatLnv.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhatLnv.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_capnhatLnv.Location = new System.Drawing.Point(823, 99);
            this.btn_capnhatLnv.Name = "btn_capnhatLnv";
            this.btn_capnhatLnv.Size = new System.Drawing.Size(247, 44);
            this.btn_capnhatLnv.TabIndex = 4;
            this.btn_capnhatLnv.Text = "Thông Tin Nhân Viên";
            this.btn_capnhatLnv.UseVisualStyleBackColor = false;
            this.btn_capnhatLnv.Click += new System.EventHandler(this.btn_capnhatLnv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_xuat);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(881, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 362);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số Lượng Bán Ra Trong Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Tháng,Năm";
            // 
            // btn_xuat
            // 
            this.btn_xuat.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_xuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_xuat.Location = new System.Drawing.Point(141, 260);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(118, 55);
            this.btn_xuat.TabIndex = 1;
            this.btn_xuat.Text = "Xuất";
            this.btn_xuat.UseVisualStyleBackColor = false;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 30);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(443, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "THÔNG  TIN";
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_trangchu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_trangchu.Location = new System.Drawing.Point(60, 20);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(116, 41);
            this.btn_trangchu.TabIndex = 19;
            this.btn_trangchu.Text = "Trang Chủ";
            this.btn_trangchu.UseVisualStyleBackColor = false;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // frm_thongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1215, 568);
            this.Controls.Add(this.btn_trangchu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_capnhatLnv);
            this.Controls.Add(this.btn_tongtien);
            this.Controls.Add(this.btn_slbanra);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frm_thongtin";
            this.Text = "frm_thongtin";
            this.Load += new System.EventHandler(this.frm_thongtin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_slbanra;
        private System.Windows.Forms.Button btn_tongtien;
        private System.Windows.Forms.Button btn_capnhatLnv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_trangchu;
    }
}