namespace QL_CF
{
    partial class frm_Kho
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
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.gb_kho = new System.Windows.Forms.GroupBox();
            this.txt_giatien = new System.Windows.Forms.TextBox();
            this.txt_hhmoi = new System.Windows.Forms.TextBox();
            this.cb_tenlh = new System.Windows.Forms.ComboBox();
            this.cb_tenncc = new System.Windows.Forms.ComboBox();
            this.btn_themhang = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tenhang = new System.Windows.Forms.ComboBox();
            this.txt_giasp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_capnhatgia = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_kho.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_trangchu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_trangchu.Location = new System.Drawing.Point(31, 34);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(116, 44);
            this.btn_trangchu.TabIndex = 28;
            this.btn_trangchu.Text = "Trang Chủ";
            this.btn_trangchu.UseVisualStyleBackColor = false;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(494, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 52);
            this.label1.TabIndex = 27;
            this.label1.Text = "Kho";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 359);
            this.dataGridView1.TabIndex = 29;
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_NhapHang.Enabled = false;
            this.btn_NhapHang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapHang.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_NhapHang.Location = new System.Drawing.Point(877, 98);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(169, 91);
            this.btn_NhapHang.TabIndex = 30;
            this.btn_NhapHang.Text = "Nhập Hàng";
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // gb_kho
            // 
            this.gb_kho.BackColor = System.Drawing.Color.Bisque;
            this.gb_kho.Controls.Add(this.txt_giaban);
            this.gb_kho.Controls.Add(this.label8);
            this.gb_kho.Controls.Add(this.txt_giatien);
            this.gb_kho.Controls.Add(this.txt_hhmoi);
            this.gb_kho.Controls.Add(this.cb_tenlh);
            this.gb_kho.Controls.Add(this.cb_tenncc);
            this.gb_kho.Controls.Add(this.btn_themhang);
            this.gb_kho.Controls.Add(this.label7);
            this.gb_kho.Controls.Add(this.label6);
            this.gb_kho.Controls.Add(this.label5);
            this.gb_kho.Controls.Add(this.label4);
            this.gb_kho.Controls.Add(this.label3);
            this.gb_kho.Controls.Add(this.cb_tenhang);
            this.gb_kho.Controls.Add(this.txt_giasp);
            this.gb_kho.Controls.Add(this.label2);
            this.gb_kho.Controls.Add(this.btn_capnhatgia);
            this.gb_kho.Controls.Add(this.label20);
            this.gb_kho.Enabled = false;
            this.gb_kho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_kho.Location = new System.Drawing.Point(31, 98);
            this.gb_kho.Name = "gb_kho";
            this.gb_kho.Size = new System.Drawing.Size(367, 490);
            this.gb_kho.TabIndex = 31;
            this.gb_kho.TabStop = false;
            this.gb_kho.Text = "KHO";
            // 
            // txt_giatien
            // 
            this.txt_giatien.Location = new System.Drawing.Point(157, 351);
            this.txt_giatien.Name = "txt_giatien";
            this.txt_giatien.Size = new System.Drawing.Size(136, 30);
            this.txt_giatien.TabIndex = 31;
            // 
            // txt_hhmoi
            // 
            this.txt_hhmoi.Location = new System.Drawing.Point(157, 230);
            this.txt_hhmoi.Name = "txt_hhmoi";
            this.txt_hhmoi.Size = new System.Drawing.Size(136, 30);
            this.txt_hhmoi.TabIndex = 30;
            // 
            // cb_tenlh
            // 
            this.cb_tenlh.FormattingEnabled = true;
            this.cb_tenlh.Location = new System.Drawing.Point(157, 307);
            this.cb_tenlh.Name = "cb_tenlh";
            this.cb_tenlh.Size = new System.Drawing.Size(137, 31);
            this.cb_tenlh.TabIndex = 29;
            // 
            // cb_tenncc
            // 
            this.cb_tenncc.FormattingEnabled = true;
            this.cb_tenncc.Location = new System.Drawing.Point(157, 266);
            this.cb_tenncc.Name = "cb_tenncc";
            this.cb_tenncc.Size = new System.Drawing.Size(137, 31);
            this.cb_tenncc.TabIndex = 28;
            // 
            // btn_themhang
            // 
            this.btn_themhang.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_themhang.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themhang.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_themhang.Location = new System.Drawing.Point(157, 438);
            this.btn_themhang.Name = "btn_themhang";
            this.btn_themhang.Size = new System.Drawing.Size(137, 46);
            this.btn_themhang.TabIndex = 27;
            this.btn_themhang.Text = "Thêm Hàng ";
            this.btn_themhang.UseVisualStyleBackColor = false;
            this.btn_themhang.Click += new System.EventHandler(this.btn_themhang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Giá Tiền Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tên Loại Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tên Nhà Cung Cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Thêm Hàng Hóa Mới -------------------------------";
            // 
            // cb_tenhang
            // 
            this.cb_tenhang.FormattingEnabled = true;
            this.cb_tenhang.Location = new System.Drawing.Point(157, 57);
            this.cb_tenhang.Name = "cb_tenhang";
            this.cb_tenhang.Size = new System.Drawing.Size(137, 31);
            this.cb_tenhang.TabIndex = 21;
            // 
            // txt_giasp
            // 
            this.txt_giasp.Location = new System.Drawing.Point(157, 103);
            this.txt_giasp.Name = "txt_giasp";
            this.txt_giasp.Size = new System.Drawing.Size(136, 30);
            this.txt_giasp.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Giá Sản Phẩm";
            // 
            // btn_capnhatgia
            // 
            this.btn_capnhatgia.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_capnhatgia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhatgia.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_capnhatgia.Location = new System.Drawing.Point(170, 151);
            this.btn_capnhatgia.Name = "btn_capnhatgia";
            this.btn_capnhatgia.Size = new System.Drawing.Size(123, 46);
            this.btn_capnhatgia.TabIndex = 15;
            this.btn_capnhatgia.Text = "Cập Nhật Giá";
            this.btn_capnhatgia.UseVisualStyleBackColor = false;
            this.btn_capnhatgia.Click += new System.EventHandler(this.btn_capnhatgia_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "Tên Hàng Hóa";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(157, 395);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(136, 30);
            this.txt_giaban.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Giá Bán";
            // 
            // frm_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1096, 600);
            this.Controls.Add(this.gb_kho);
            this.Controls.Add(this.btn_NhapHang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_trangchu);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_Kho";
            this.Text = "frm_Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_kho.ResumeLayout(false);
            this.gb_kho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_trangchu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.GroupBox gb_kho;
        private System.Windows.Forms.Button btn_capnhatgia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_tenhang;
        private System.Windows.Forms.TextBox txt_giasp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_giatien;
        private System.Windows.Forms.TextBox txt_hhmoi;
        private System.Windows.Forms.ComboBox cb_tenlh;
        private System.Windows.Forms.ComboBox cb_tenncc;
        private System.Windows.Forms.Button btn_themhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label label8;
    }
}