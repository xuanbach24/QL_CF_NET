namespace QL_CF
{
    partial class frm_ban
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_banmoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bancu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_doiban = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhatsl = new System.Windows.Forms.Button();
            this.cb_tenmon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tenban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.gb_qlban = new System.Windows.Forms.GroupBox();
            this.btn_xoaban = new System.Windows.Forms.Button();
            this.txt_themtenban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maban = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_themban = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_qlban.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(644, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bàn";
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_trangchu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_trangchu.Location = new System.Drawing.Point(34, 29);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(116, 44);
            this.btn_trangchu.TabIndex = 26;
            this.btn_trangchu.Text = "Trang Chủ";
            this.btn_trangchu.UseVisualStyleBackColor = false;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(536, 328);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.cb_banmoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_bancu);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn_doiban);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1047, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 242);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi Bàn";
            // 
            // cb_banmoi
            // 
            this.cb_banmoi.FormattingEnabled = true;
            this.cb_banmoi.Location = new System.Drawing.Point(157, 117);
            this.cb_banmoi.Name = "cb_banmoi";
            this.cb_banmoi.Size = new System.Drawing.Size(160, 31);
            this.cb_banmoi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Bàn Mới";
            // 
            // txt_bancu
            // 
            this.txt_bancu.Enabled = false;
            this.txt_bancu.Location = new System.Drawing.Point(157, 61);
            this.txt_bancu.Name = "txt_bancu";
            this.txt_bancu.Size = new System.Drawing.Size(160, 30);
            this.txt_bancu.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Bàn Cũ";
            // 
            // btn_doiban
            // 
            this.btn_doiban.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_doiban.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doiban.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_doiban.Location = new System.Drawing.Point(157, 166);
            this.btn_doiban.Name = "btn_doiban";
            this.btn_doiban.Size = new System.Drawing.Size(160, 46);
            this.btn_doiban.TabIndex = 2;
            this.btn_doiban.Text = "Đổi Bàn";
            this.btn_doiban.UseVisualStyleBackColor = false;
            this.btn_doiban.Click += new System.EventHandler(this.btn_doiban_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(602, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 286);
            this.dataGridView1.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Bisque;
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_capnhatsl);
            this.groupBox2.Controls.Add(this.cb_tenmon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(602, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 242);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đồ Ăn, Uống";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_xoa.Location = new System.Drawing.Point(290, 166);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(108, 46);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa Món";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhatsl
            // 
            this.btn_capnhatsl.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_capnhatsl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhatsl.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_capnhatsl.Location = new System.Drawing.Point(157, 166);
            this.btn_capnhatsl.Name = "btn_capnhatsl";
            this.btn_capnhatsl.Size = new System.Drawing.Size(108, 46);
            this.btn_capnhatsl.TabIndex = 8;
            this.btn_capnhatsl.Text = "Cập Nhật SL";
            this.btn_capnhatsl.UseVisualStyleBackColor = false;
            this.btn_capnhatsl.Click += new System.EventHandler(this.btn_capnhatsl_Click);
            // 
            // cb_tenmon
            // 
            this.cb_tenmon.FormattingEnabled = true;
            this.cb_tenmon.Location = new System.Drawing.Point(126, 47);
            this.cb_tenmon.Name = "cb_tenmon";
            this.cb_tenmon.Size = new System.Drawing.Size(160, 31);
            this.cb_tenmon.TabIndex = 7;
            this.cb_tenmon.SelectedIndexChanged += new System.EventHandler(this.cb_tenmon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(126, 110);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(160, 30);
            this.txt_soluong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Món";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_them.Location = new System.Drawing.Point(37, 166);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(108, 46);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm Món";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Bisque;
            this.groupBox3.Controls.Add(this.txt_tongtien);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_tenban);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_thanhtoan);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1047, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 286);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh Toán";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(157, 128);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(160, 30);
            this.txt_tongtien.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng Tiền :";
            // 
            // txt_tenban
            // 
            this.txt_tenban.Enabled = false;
            this.txt_tenban.Location = new System.Drawing.Point(157, 65);
            this.txt_tenban.Name = "txt_tenban";
            this.txt_tenban.Size = new System.Drawing.Size(160, 30);
            this.txt_tenban.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên Bàn";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_thanhtoan.Location = new System.Drawing.Point(157, 199);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(160, 46);
            this.btn_thanhtoan.TabIndex = 2;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // gb_qlban
            // 
            this.gb_qlban.BackColor = System.Drawing.Color.Bisque;
            this.gb_qlban.Controls.Add(this.btn_xoaban);
            this.gb_qlban.Controls.Add(this.txt_themtenban);
            this.gb_qlban.Controls.Add(this.label7);
            this.gb_qlban.Controls.Add(this.txt_maban);
            this.gb_qlban.Controls.Add(this.label8);
            this.gb_qlban.Controls.Add(this.btn_themban);
            this.gb_qlban.Enabled = false;
            this.gb_qlban.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_qlban.Location = new System.Drawing.Point(34, 433);
            this.gb_qlban.Name = "gb_qlban";
            this.gb_qlban.Size = new System.Drawing.Size(536, 212);
            this.gb_qlban.TabIndex = 30;
            this.gb_qlban.TabStop = false;
            this.gb_qlban.Text = "Quản Lý Bàn";
            // 
            // btn_xoaban
            // 
            this.btn_xoaban.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_xoaban.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaban.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_xoaban.Location = new System.Drawing.Point(281, 145);
            this.btn_xoaban.Name = "btn_xoaban";
            this.btn_xoaban.Size = new System.Drawing.Size(117, 46);
            this.btn_xoaban.TabIndex = 8;
            this.btn_xoaban.Text = "Xóa Bàn";
            this.btn_xoaban.UseVisualStyleBackColor = false;
            this.btn_xoaban.Click += new System.EventHandler(this.btn_xoaban_Click);
            // 
            // txt_themtenban
            // 
            this.txt_themtenban.Location = new System.Drawing.Point(157, 94);
            this.txt_themtenban.Name = "txt_themtenban";
            this.txt_themtenban.Size = new System.Drawing.Size(160, 30);
            this.txt_themtenban.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên Bàn";
            // 
            // txt_maban
            // 
            this.txt_maban.Location = new System.Drawing.Point(157, 38);
            this.txt_maban.Name = "txt_maban";
            this.txt_maban.Size = new System.Drawing.Size(160, 30);
            this.txt_maban.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã Bàn";
            // 
            // btn_themban
            // 
            this.btn_themban.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_themban.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themban.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_themban.Location = new System.Drawing.Point(148, 145);
            this.btn_themban.Name = "btn_themban";
            this.btn_themban.Size = new System.Drawing.Size(117, 46);
            this.btn_themban.TabIndex = 2;
            this.btn_themban.Text = "Thêm Bàn";
            this.btn_themban.UseVisualStyleBackColor = false;
            this.btn_themban.Click += new System.EventHandler(this.btn_themban_Click);
            // 
            // frm_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1451, 673);
            this.Controls.Add(this.gb_qlban);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_trangchu);
            this.Controls.Add(this.label1);
            this.Name = "frm_ban";
            this.Text = "frm_ban";
            this.Load += new System.EventHandler(this.frm_ban_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_qlban.ResumeLayout(false);
            this.gb_qlban.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_trangchu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_banmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bancu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_doiban;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_capnhatsl;
        private System.Windows.Forms.ComboBox cb_tenmon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tenban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.GroupBox gb_qlban;
        private System.Windows.Forms.TextBox txt_themtenban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maban;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_themban;
        private System.Windows.Forms.Button btn_xoaban;
        private System.Windows.Forms.Button btn_xoa;
    }
}