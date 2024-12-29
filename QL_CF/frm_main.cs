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
    public partial class frm_main : Form
    {
        dbQLCFDataContext db=new dbQLCFDataContext();
        string matk = "";
        public frm_main(string matk)
        {
            InitializeComponent();
            this.matk = matk;
            var role = db.NHANVIENs.FirstOrDefault(x => x.MANV == matk);
            string chucvu=role.CHUCVU.Trim();
            if (chucvu == "Quản Lý")
            {
                btn_thongke.Enabled = true;
                btn_thongtin.Enabled = true;
                btn_nhanvien.Enabled = true;
                btn_hoadon.Enabled = true;
            }
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            frm_NhanVien nv= new frm_NhanVien(matk);
            this.Hide();
            nv.Show();
        }


        private void btn_thongke_Click(object sender, EventArgs e)
        {
            frm_ThongKe tk = new frm_ThongKe(matk);
            this.Hide();
            tk.Show();
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            frm_thongtin frm= new frm_thongtin(matk);
            this.Hide();
            frm.Show();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Application.Exit();

            // Khởi động lại ứng dụng
            Application.Restart();
        }

        private void btn_Ban_Click(object sender, EventArgs e)
        {
            frm_ban frm=new frm_ban(matk);
            this.Hide();
            frm.Show();
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            frm_Kho frm=new frm_Kho(matk);
            this.Hide();
            frm.Show();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            frm_HoaDon frm=new frm_HoaDon(matk);
            this.Hide();
            frm.Show();
        }

        private void btn_saoluu_Click(object sender, EventArgs e)
        {
            frm_saoluu frm = new frm_saoluu();
            frm.Show();
        }
    }
}
