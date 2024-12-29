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
    public partial class frm_HoaDon : Form
    {
        string matk;
        string mahoadon = "";
        public frm_HoaDon(string matk)
        {
            InitializeComponent();
            this.matk = matk;
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_hdnh_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            var list = db.HOADONNHAPHANGs.Select(x => new {x.MAHDNH,x.MANV,x.NGAYHBNH});
            dataGridView1.DataSource=list;
            cb_timkiem.Items.Clear();
            var hd=db.HOADONNHAPHANGs.ToList();
            foreach(var t in hd)
            {
                cb_timkiem.Items.Add(t.MAHDNH);
            }
            mahoadon = "HDNH";

        }

        private void btn_hdnhct_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            var list = db.CHITIETNHAPHANGs.ToList();
            dataGridView1.DataSource = list;
            cb_timkiem.Items.Clear();
            var hd = db.HOADONNHAPHANGs.ToList();
            foreach (var t in hd)
            {
                cb_timkiem.Items.Add(t.MAHDNH);
            }
            mahoadon = "CTHDNH";
        }

        private void btn_hdbh_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            var list = db.HOADONBANHANGs.Select(x => new { x.MAHDBH, x.MANV, x.MABAN, x.NGAYHD, x.TONGTIEN });
            dataGridView1.DataSource = list;
            cb_timkiem.Items.Clear();
            var hd = db.HOADONBANHANGs.ToList();
            foreach (var t in hd)
            {
                cb_timkiem.Items.Add(t.MAHDBH);
            }
            mahoadon = "HDBH";
        }

        private void btn_hdbhct_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db = new dbQLCFDataContext();
            var list = db.CHITIETBANHANGs.ToList();
            dataGridView1.DataSource = list;
            cb_timkiem.Items.Clear();
            var hd = db.HOADONBANHANGs.ToList();
            foreach (var t in hd)
            {
                cb_timkiem.Items.Add(t.MAHDBH);
            }
            mahoadon = "CTHDBH";

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            frm_main main = new frm_main(matk);
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db=new dbQLCFDataContext();
            if (mahoadon == "HDBH")
            {
                var list = db.HOADONBANHANGs.Where(x=>x.MAHDBH==cb_timkiem.Text.Trim()).Select(x => new { x.MAHDBH, x.MANV, x.MABAN, x.NGAYHD, x.TONGTIEN });
                dataGridView1.DataSource = list;

            }
            if(mahoadon == "CTHDBH")
            {
                var list = db.CHITIETBANHANGs.Where(x=>x.MAHDBH==cb_timkiem.Text.Trim());
                dataGridView1.DataSource = list;
            }
            if( mahoadon == "HDNH")
            {
                var list = db.HOADONNHAPHANGs.Where(x=>x.MAHDNH==cb_timkiem.Text.Trim()).Select(x => new { x.MAHDNH, x.MANV, x.NGAYHBNH });
                dataGridView1.DataSource = list;
            }
            if (mahoadon == "CTHDNH")
            {
                var list = db.CHITIETNHAPHANGs.Where(x => x.MAHDNH==cb_timkiem.Text.Trim());
                dataGridView1.DataSource = list;
            }
        }
    }
}
