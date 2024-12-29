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
    public partial class frm_NhanVien : Form
    {
        string matk;
        public frm_NhanVien(string matk)
        {
            InitializeComponent();
            this.matk = matk;
            loadmanv();
            load_cb();
        }

        public void load_cb()
        {
            cb_chucvu.Items.Clear();
            cb_gioitinh.Items.Clear();
            cb_chucvu.Items.Add("Nhân Viên");
            cb_chucvu.Items.Add("Quản Lý");
            cb_gioitinh.Items.Add("Nam");
            cb_gioitinh.Items.Add("Nữ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db=new dbQLCFDataContext();
            DateTime ngay= DateTime.Now;
            if(txt_manv.Text==string.Empty || txt_tennv.Text==string.Empty || cb_gioitinh.Text==string.Empty|| cb_chucvu.Text==string.Empty || txt_diachi.Text==string.Empty|| txt_sdt.Text==string.Empty|| txt_matkhau.Text != string.Empty)
            {
                try
                {
                    db.THEM1NV(txt_manv.Text, txt_tennv.Text, cb_gioitinh.Text.Trim(), cb_chucvu.Text.Trim(), ngay, txt_diachi.Text, txt_sdt.Text,txt_matkhau.Text.Trim());
                    var list = db.NHANVIENs.ToList();
                    dataGridView1.DataSource = list;

                    ///////

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != string.Empty)
            {
                dbQLCFDataContext db = new dbQLCFDataContext();
                try
                {
                    db.XOANHANVIEN(txt_manv.Text.Trim());
                    var list = db.NHANVIENs.ToList();
                    dataGridView1.DataSource = list;
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_tienluong_Click(object sender, EventArgs e)
        {
            if (cb_manv.Text != string.Empty)
            {
                dbQLCFDataContext db = new dbQLCFDataContext();
                try
                {
                    var tienluong = db.TIENLUONG(cb_manv.Text.Trim());
                    lb_tienluong.Text = tienluong.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Mã Nhân Viên !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            dbQLCFDataContext db= new dbQLCFDataContext();
            var list = db.NHANVIENs.ToList();
            dataGridView1.DataSource = list;
            /////////
        }
        public void loadmanv()
        {
            cb_manv.Items.Clear();
            dbQLCFDataContext db=new dbQLCFDataContext();
            var list = db.NHANVIENs.ToList();
            foreach ( var item in list )
            {
                cb_manv.Items.Add(item.MANV);
                cb_manvnlv.Items.Add(item.MANV);
            }
        }
        private void btn_calamvc_Click(object sender, EventArgs e)
        {
            if (cb_manvnlv.Text != string.Empty)
            {
                dbQLCFDataContext db = new dbQLCFDataContext();
                try
                {
                    var calv = db.TinhSoNgayLamViec(cb_manvnlv.Text);
                    lb_calv.Text = calv.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Mã Nhân Viên !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            frm_main main = new frm_main(matk);
            main.Show();
            this.Hide();
        }

        private void btn_ctluong_Click(object sender, EventArgs e)
        {
            frm_ctLuong frm= new frm_ctLuong(matk);
            this.Hide();
            frm.Show();
        }


    }
}
