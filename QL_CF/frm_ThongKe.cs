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
    public partial class frm_ThongKe : Form
    {
        string matk;
        public frm_ThongKe(string matk)
        {
            InitializeComponent();
            this.matk = matk;
        }

        private void btn_dthh_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            int thang = dateTimePicker1.Value.Month;
            int nam= dateTimePicker1.Value.Year;
            try
            {
                var list= db.DOANHTHUHH(thang, nam);
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dtnv_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            int thang = dateTimePicker1.Value.Month;
            int nam = dateTimePicker1.Value.Year;
            try
            {
                var list = db.DOANHTHUNVCAONHAT(thang, nam);
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_hbcn_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            int thang = dateTimePicker1.Value.Month;
            int nam = dateTimePicker1.Value.Year;
            try
            {
                var list = db.MatHangBanChayNhat(thang, nam);
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_slbanra_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            int thang = dateTimePicker1.Value.Month;
            int nam = dateTimePicker1.Value.Year;
            try
            {
                var list = db.TinhSoLuongBanRaTheoMatHang(thang, nam);
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            var list=db.Thongkes.ToList();
            dataGridView1.DataSource=list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            var list = db.ThongkeNams.ToList();
            dataGridView1.DataSource = list;
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            frm_main main= new frm_main(matk);
            main.Show();
            this.Hide();
        }
    }
}
