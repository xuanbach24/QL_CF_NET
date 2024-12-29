using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CF
{
    public partial class frm_Kho : Form
    {
        dbQLCFDataContext db=new dbQLCFDataContext();
        string matk;
        public frm_Kho(string matk)
        {
            InitializeComponent();
            load_cb();
            loaddata();
            var role = db.NHANVIENs.FirstOrDefault(x => x.MANV == matk);
            string chucvu = role.CHUCVU.Trim();
            txt_giaban.Clear();
            txt_giasp.Clear();
            txt_giatien.Clear();
            txt_hhmoi.Clear();
            this.matk = matk;
            if (chucvu == "Quản Lý")
            {
                gb_kho.Enabled = true;
                btn_NhapHang.Enabled = true;
            }
        }
        public void load_cb()
        {
            var list = db.NGUYENLIEUs.ToList();
            foreach (var item in list)
            {
                cb_tenhang.Items.Add(item.TENNL);
            }
            var ncc=db.NHACUNGCAPs.ToList();
            var loaihang=db.LOAIHANGs.ToList();
            foreach (var item in loaihang)
            {
                cb_tenlh.Items.Add(item.TENLH);
            }
            foreach (var item in ncc)
            {
                cb_tenncc.Items.Add(item.TENNCC);
            }
        }
        public void loaddata()
        {
            var list = db.KHOs.Select(x => new{
                                        x.MAHH,
                                        x.TENHH,
                                        x.GIASP,
                                        x.SOLUONGTON
                                    }).ToList();
            dataGridView1.DataSource = list;
        }
        private void btn_capnhatgia_Click(object sender, EventArgs e)
        {
            if(txt_giasp.Text==string.Empty || cb_tenhang.Text != string.Empty)
            {
                try
                {
                    var mahh = db.KHOs.FirstOrDefault(x => x.TENHH == cb_tenhang.Text.Trim());
                    decimal gia = Decimal.Parse(txt_giasp.Text.ToString());
                    db.CapNhatGiaSanPham(mahh.MAHH, gia);
                    MessageBox.Show("Thành Công");
                    loaddata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public string MANL()
        {
            string mahd = "";
            var lastCustomerCode = db.NGUYENLIEUs
                         .Where(hd => hd.MANL.StartsWith("NL"))
                         .OrderByDescending(hd => hd.MANL)
                         .Select(hd => hd.MANL)
                         .FirstOrDefault();
            if (string.IsNullOrEmpty(lastCustomerCode))
            {
                mahd = "NL001";
                return mahd;
            }
            else
            {
                int lastNumber = int.Parse(lastCustomerCode.Substring(2));
                mahd = $"NL{(lastNumber + 1):D3}";
                return mahd;
            }

        }
        public string MAHH()
        {
            string mahd = "";
            var lastCustomerCode = db.KHOs
                         .Where(hd => hd.MAHH.StartsWith("HH"))
                         .OrderByDescending(hd => hd.MAHH)
                         .Select(hd => hd.MAHH)
                         .FirstOrDefault();
            if (string.IsNullOrEmpty(lastCustomerCode))
            {
                mahd = "HH001";
                return mahd;
            }
            else
            {
                int lastNumber = int.Parse(lastCustomerCode.Substring(2));
                mahd = $"HH{(lastNumber + 1):D3}";
                return mahd;
            }

        }
        private void btn_themhang_Click(object sender, EventArgs e)
        {
            if(txt_hhmoi.Text==string.Empty || cb_tenhang.Text==string.Empty || cb_tenlh.Text==string.Empty || cb_tenncc.Text==string.Empty || txt_giasp.Text != string.Empty)
            {
                string manl = MANL();
                string mahh = MAHH();
                var mancc = db.NHACUNGCAPs.FirstOrDefault(x => x.TENNCC == cb_tenncc.Text.Trim());
                var malh = db.LOAIHANGs.FirstOrDefault(x => x.TENLH == cb_tenlh.Text.Trim());
                int giatien = int.Parse(txt_giatien.Text);
                int giaban = int.Parse(txt_giaban.Text);
                db.THEMHH(mahh, manl, txt_hhmoi.Text, mancc.MANCC, malh.MALH, giatien, giaban);
                MessageBox.Show("Thành Công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            frm_main frm=new frm_main(matk);
            this.Hide();
            frm.Show();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            frm_nhaphang frm=new frm_nhaphang(matk);
            this.Hide();
            frm.Show();
        }
    }
}
