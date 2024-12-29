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
    public partial class frm_nhaphang : Form
    {
        public dbQLCFDataContext db= new dbQLCFDataContext();
        string matk;
        public frm_nhaphang(string matk)
        {
            InitializeComponent();
            load_cb();
            txt_maPN.Clear();
            txt_soluong.Clear();
            txt_thanhtien.Clear();
            this.matk = matk;
        }
        public string MAHOADON()
        {
            string mahd = "";
            var lastCustomerCode = db.HOADONNHAPHANGs
                         .Where(hd => hd.MAHDNH.StartsWith("HDNH"))
                         .OrderByDescending(hd => hd.MAHDNH)
                         .Select(hd => hd.MAHDNH)
                         .FirstOrDefault();
            if (string.IsNullOrEmpty(lastCustomerCode))
            {
                mahd = "HDNH001";
                return mahd;
            }
            else
            {
                int lastNumber = int.Parse(lastCustomerCode.Substring(4));
                mahd = $"HDNH{(lastNumber + 1):D3}";
                return mahd;
            }

        }

        private void btn_taoPN_Click(object sender, EventArgs e)
        {
            string mahd=MAHOADON();
            DateTime dateTime = DateTime.Now;
            dateTime.ToString("yyyy-MM-dd");
            db.ThemHoaDonNhapHang(mahd, matk, dateTime);
            txt_maPN.Text = mahd;
            groupBox1.Enabled = true;
            MessageBox.Show("Thành công");
        }

        public void load_cb()
        {
            var hh = db.NGUYENLIEUs.ToList();
            foreach (var h in hh)
            {
                cb_tenhh.Items.Add(h.TENNL);
            }
        }

        public void load_data()
        {
            var list=db.CHITIETNHAPHANGs.Where(x=>x.MAHDNH==txt_maPN.Text.Trim()).ToList();
            dataGridView1.DataSource = list;
        }

        private void btn_Nhaphang_Click(object sender, EventArgs e)
        {
            if(cb_tenhh.Text==string.Empty || txt_soluong.Text != string.Empty)
            {
                try
                {
                    var manl = db.NGUYENLIEUs.FirstOrDefault(x => x.TENNL == cb_tenhh.Text.Trim());
                    int solg = int.Parse(txt_soluong.Text.Trim());
                    int thanhtien = int.Parse(txt_thanhtien.Text.Trim());

                    db.ThemChiTietNhapHang(manl.MANL, txt_maPN.Text.Trim(), solg, thanhtien);
                    MessageBox.Show("Thành công");
                    load_data();
                }
                catch (Exception ex)
                {

                }

                load_data();
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            var tinhtien=db.NGUYENLIEUs.FirstOrDefault(x=>x.TENNL==cb_tenhh.Text.Trim());
            int tongtien = int.Parse(txt_soluong.Text) * int.Parse(tinhtien.GIATIEN.ToString());
            txt_thanhtien.Text = tongtien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main(matk);
            this.Hide();
            frm.Show();
        }
    }
}
