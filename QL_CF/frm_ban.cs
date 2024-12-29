using DevExpress.Utils.Serializing;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CF
{
    public partial class frm_ban : Form
    {
        public dbQLCFDataContext db=new dbQLCFDataContext();
        string matk;
        public frm_ban(string matk)
        {
            InitializeComponent();
            this.matk = matk;
            load_tenmon();
            load_banmoi();
        }
        private void frm_ban_Load(object sender, EventArgs e)
        {
            var role = db.NHANVIENs.FirstOrDefault(x => x.MANV == matk);
            string chucvu = role.CHUCVU.Trim();
            LoadTables();

            flowLayoutPanel1.Refresh();
            if (chucvu == "Quản Lý")
            {
                gb_qlban.Enabled = true;
            }
        }
        void LoadTables()
        {
            // Xóa các bàn cũ
            flowLayoutPanel1.Controls.Clear();

            // Lấy dữ liệu bàn từ cơ sở dữ liệu
            var tables = db.BANs.ToList();

            foreach (var table in tables)
            {
                Button btnTable = new Button
                {
                    Width = 80,
                    Height = 80,
                    Text = $"{table.TENBAN}",
                    Tag = table.MABAN
                };

                // Đổi màu sắc tùy theo trạng thái bàn
                if (table.THUOCTINH == "0")
                {
                    btnTable.BackColor = Color.Green;
                    // Bàn trống - màu xanh
                }
                else if (table.THUOCTINH == "1")
                {
                    btnTable.BackColor = Color.Red;  // Bàn có khách - màu đỏ
                }
                // Gắn sự kiện click nếu cần
                btnTable.Click += BtnTable_Click;

                // Thêm nút bàn vào flowLayoutPanel
                flowLayoutPanel1.Controls.Add(btnTable);
            }

            // Đảm bảo làm mới flowLayoutPanel để cập nhật giao diện
            flowLayoutPanel1.Refresh();
        }

        string maban ="";

        void BtnTable_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db=new dbQLCFDataContext();
            Button btn = sender as Button;
            maban = btn.Tag.ToString();
            var tenban=db.BANs.FirstOrDefault(x=>x.MABAN==maban);
            var hoadon=db.HOADONBANHANGs
                            .Where(hd => hd.MABAN == maban)
                            .OrderByDescending(hd => hd.MAHDBH)
                            .FirstOrDefault();
            txt_bancu.Text = tenban.TENBAN;
            txt_tenban.Text = tenban.TENBAN;

            MessageBox.Show($"Bạn đã chọn {btn.Text}");
            if(tenban.THUOCTINH == "1")
            {
                btn_capnhatsl.Enabled = true;
                btn_thanhtoan.Enabled = true;
                btn_xoa.Enabled = true;
                if (hoadon != null)
                {
                    txt_tongtien.Text = hoadon.TONGTIEN?.ToString() ?? "0";
                }
                loadgridview();

            }
            else
            {
                btn_capnhatsl.Enabled = false;
                btn_thanhtoan.Enabled = false;
                btn_xoa.Enabled = false;
                dataGridView1.DataSource = null;
                txt_tongtien.Text = "0";
            }
        }

        private void btn_themban_Click(object sender, EventArgs e)
        {
            try
            {
                db.THEMBAN(txt_maban.Text.Trim(),txt_themtenban.Text.Trim());
                MessageBox.Show("Thành Công");
                LoadTables();
                load_banmoi();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn Đã Trùng Mã Bàn");
            }
        }

        private void btn_xoaban_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            var check = db.BANs.FirstOrDefault(x => x.MABAN == txt_maban.Text.Trim());
            if (check != null)
            {
                if(check.THUOCTINH !="1")
                {

                    db.XOABAN(txt_maban.Text.Trim());
                    MessageBox.Show("Thành Công");
                    LoadTables();
                    load_banmoi();
                }
                else
                {
                    MessageBox.Show("Bàn Đang Có Khách Không Thể Xóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Không Có Mã Bàn Này","Cảnh Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

              
        public string MAHOADON()
        {
            string mahd = "";
            var lastCustomerCode = db.HOADONBANHANGs
                         .Where(hd => hd.MAHDBH.StartsWith("HDBH"))
                         .OrderByDescending(hd => hd.MAHDBH)
                         .Select(hd => hd.MAHDBH)
                         .FirstOrDefault();
            if (string.IsNullOrEmpty(lastCustomerCode))
            {
                mahd = "HDBH001";
                return mahd;
            }
            else
            {
                int lastNumber = int.Parse(lastCustomerCode.Substring(4));
                mahd = $"HDBH{(lastNumber + 1):D3}";
                return mahd;
            }
            
        }

        public void load_tenmon()
        {
            var list=db.KHOs.ToList();
            foreach (var item in list)
            {
                cb_tenmon.Items.Add(item.TENHH);
            }
        }

        public void load_banmoi()
        {
            cb_banmoi.Items.Clear();
            var list=db.BANs.ToList();
            foreach(var item in list)
            {
                cb_banmoi.Items.Add(item.TENBAN);
            }
        }
        public void loadgridview()
        {
            var ktkhach = db.BANs.FirstOrDefault(x => x.MABAN == maban);
            var bancu = db.HOADONBANHANGs
                                        .Where(hd => hd.MABAN == maban)
                                        .OrderByDescending(hd => hd.MAHDBH)
                                        .Select(hd => hd.MAHDBH)
                                        .FirstOrDefault();
            var truyvan = from kho in db.KHOs
                          join ctbh in db.CHITIETBANHANGs on kho.MAHH equals ctbh.MAHH
                          where ctbh.MAHDBH == bancu
                          select new
                          {
                              ctbh.MAHDBH,
                              kho.TENHH,
                              kho.GIASP,
                              ctbh.SOLUONG,
                          };

            dataGridView1.DataSource = truyvan;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (cb_tenmon.Text != string.Empty || txt_soluong.Text != string.Empty)
            {
                var ktkhach = db.BANs.FirstOrDefault(x => x.MABAN == maban);
                var mahh = db.KHOs.FirstOrDefault(x => x.TENHH == cb_tenmon.Text.Trim());
                int sl = int.Parse(txt_soluong.Text.Trim());
                var kho = db.KHOs.FirstOrDefault(x => x.MAHH == mahh.MAHH);
                int slton = int.Parse(kho.SOLUONGTON.ToString());
                int soluong = int.Parse(txt_soluong.Text);
                var bancu = db.HOADONBANHANGs
                                        .Where(hd => hd.MABAN == maban)
                                        .OrderByDescending(hd => hd.MAHDBH)
                                        .Select(hd => hd.MAHDBH)
                                        .FirstOrDefault();
                if (ktkhach.THUOCTINH == "0")
                {


                    if (sl <= slton)
                    {
                        string mahd = MAHOADON();
                        db.ThemHoaDonBanHang(mahd, matk, maban);
                        db.CAPNHATBAN(maban);
                        db.ThemChiTietBanHang(mahd, mahh.MAHH, soluong);
                        MessageBox.Show("Thêm Thành Công");
                        db.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                        foreach (Button btn in flowLayoutPanel1.Controls)
                        {
                            if (btn.Tag.ToString() == maban)
                            {
                                btn.BackColor = Color.Red; // Bàn mới trở thành bàn có khách
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số Lượng Trong Kho Không Đủ, Chỉ Còn: " + slton + "");
                    }
                }
                else
                {
                    if (sl <= slton)
                    {
                        db.ThemChiTietBanHang(bancu, mahh.MAHH, soluong);
                        MessageBox.Show("Thêm Thành Công");
                        db.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu

                    }
                    else
                    {
                        MessageBox.Show("Số Lượng Trong Kho Không Đủ, Chỉ Còn: " + slton + "");
                    }
                }
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Refresh();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.BANs);
                loadgridview();
                frm_ban_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void btn_capnhatsl_Click(object sender, EventArgs e)
        {
            if(cb_tenmon.Text==string.Empty || txt_soluong.Text != string.Empty)
            {
                
                var bancu = db.HOADONBANHANGs
                                        .Where(hd => hd.MABAN == maban)
                                        .OrderByDescending(hd => hd.MAHDBH)
                                        .Select(hd => hd.MAHDBH)
                                        .FirstOrDefault();
                int soluong = int.Parse(txt_soluong.Text);
                var mahh = db.KHOs.FirstOrDefault(x => x.TENHH == cb_tenmon.Text.Trim());
                var kho = db.KHOs.FirstOrDefault(x => x.MAHH == mahh.MAHH);
                int slton = int.Parse(kho.SOLUONGTON.ToString());

                if (soluong <= slton)
                {

                    db.THAYDOISL(bancu, mahh.MAHH, soluong);
                    db.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                    MessageBox.Show("Thành Công");
                }
                else
                {
                    MessageBox.Show("Số Lượng Trong Kho Không Đủ, Chỉ Còn: " + slton + "");
                }
                loadgridview();

            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu !!","Cảnh Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (cb_tenmon.Text != string.Empty)
            {
                var bancu = db.HOADONBANHANGs
                                        .Where(hd => hd.MABAN == maban)
                                        .OrderByDescending(hd => hd.MAHDBH)
                                        .Select(hd => hd.MAHDBH)
                                        .FirstOrDefault();
                var mahh = db.KHOs.FirstOrDefault(x => x.TENHH == cb_tenmon.Text.Trim());
                db.XOAHH(bancu, mahh.MAHH);
                MessageBox.Show("Xóa Thành Công");
                db.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                loadgridview();
                load_banmoi();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btn_doiban_Click(object sender, EventArgs e)
        {
            if (cb_banmoi.Text != string.Empty)
            {
                var mabancu = db.BANs.FirstOrDefault(x => x.MABAN == maban);
                var mabanmoi = db.BANs.FirstOrDefault(x => x.TENBAN == cb_banmoi.Text.Trim());
                var bancu = db.HOADONBANHANGs
                                 .Where(hd => hd.MABAN == maban)
                                 .OrderByDescending(hd => hd.MAHDBH)
                                 .Select(hd => hd.MAHDBH)
                                 .FirstOrDefault();

                if (mabanmoi.THUOCTINH == "0" && mabancu.THUOCTINH == "1") // Nếu bàn mới không có khách
                {
                    db.DOIBAN(bancu, mabancu.MABAN, mabanmoi.MABAN);
                    db.SubmitChanges();  // Lưu thay đổi vào cơ sở dữ liệu
                    foreach (Button btn in flowLayoutPanel1.Controls)
                    {
                        if (btn.Tag.ToString() == mabancu.MABAN)
                        {
                            btn.BackColor = Color.Green; // Bàn cũ trở thành bàn trống

                        }
                        else if (btn.Tag.ToString() == mabanmoi.MABAN)
                        {
                            btn.BackColor = Color.Red; // Bàn mới trở thành bàn có khách
                        }
                    }
                    MessageBox.Show("Đã Đổi Bàn Thành Công");
                }
                else
                {
                    MessageBox.Show("Lỗi Đổi Bàn ");
                }
                flowLayoutPanel1.Refresh();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.BANs);
                frm_ban_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db=new dbQLCFDataContext();
            var hoadon = db.HOADONBANHANGs
                            .Where(hd => hd.MABAN == maban)
                            .OrderByDescending(hd => hd.MAHDBH)
                            .FirstOrDefault();
            string mahd = "";
            mahd=hoadon.MAHDBH.Trim();
            var capnhat=db.BANs.FirstOrDefault(x=>x.MABAN==maban.Trim());
            capnhat.THUOCTINH = "0";
            db.SubmitChanges();
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.Tag.ToString() == maban)
                {
                    btn.BackColor = Color.Green; // Bàn mới trở thành bàn có khách
                }
            }
            inhoaodon frm=new inhoaodon(mahd);
            frm.Show();
            txt_tenban.Text=txt_tongtien.Text=string.Empty;
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main(matk);
            this.Hide();
            frm.Show();
        }

        private void cb_tenmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbQLCFDataContext db= new dbQLCFDataContext();
            try
            {
                var ban = db.BANs.FirstOrDefault(x => x.MABAN == maban);
                var hoadon = db.HOADONBANHANGs
                            .Where(hd => hd.MABAN == maban)
                            .OrderByDescending(hd => hd.MAHDBH)
                            .FirstOrDefault();
                var hanghoa = db.KHOs.FirstOrDefault(x => x.TENHH == cb_tenmon.Text.Trim());
                if (ban.THUOCTINH == "1")
                {
                    var chitiet = db.CHITIETBANHANGs.FirstOrDefault(x => x.MAHDBH == hoadon.MAHDBH && x.MAHH == hanghoa.MAHH);
                    if (chitiet != null)
                    {
                        btn_capnhatsl.Enabled = true;
                        btn_them.Enabled = false;
                        btn_xoa.Enabled = true;
                    }
                    else
                    {
                        btn_capnhatsl.Enabled = false;
                        btn_them.Enabled = true;
                        btn_xoa.Enabled = false;
                    }
                }
                else
                {
                    btn_them.Enabled=true;
                }
                
            }catch (Exception ex)
            {

            }
            
        }
    }
}
