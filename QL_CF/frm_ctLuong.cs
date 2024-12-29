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
    public partial class frm_ctLuong : Form
    {
        string matk;
        public frm_ctLuong(string matk)
        {
            InitializeComponent();
            this.matk = matk;
        }

        private void frm_ctLuong_Load(object sender, EventArgs e)
        {
            dbQLCFDataContext db=new dbQLCFDataContext();
            loadGrid();
            loadcb();
        }

        public void loadcb()
        {
            try
            {
                dbQLCFDataContext db =  new dbQLCFDataContext();
                var clv = db.CALAMVIECs.ToList();
                var manv=db.NHANVIENs.ToList();
                foreach (var ma in clv)
                {
                    cb_maclv.Items.Add(ma.MACLV);
                }
                foreach (var ma in manv)
                {
                    cb_manv.Items.Add(ma.MANV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadGrid()
        {
            try
            {
                dbQLCFDataContext db = new dbQLCFDataContext();
                var list = db.CHITIETLUONGNHANVIENs.ToList();
                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_tinhluong_Click_1(object sender, EventArgs e)
        {
            try
            {
                dbQLCFDataContext db = new dbQLCFDataContext();
                db.TINHTONGLUONGNVTHEOCA();
                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            try
            {
                dbQLCFDataContext db = new dbQLCFDataContext();
                int soca = int.Parse(txt_soca.Text.Trim());
                db.THEMCHITIETLUONG(cb_maclv.Text.Trim(), cb_manv.Text.Trim(), soca);
                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbQLCFDataContext db = new dbQLCFDataContext();
                db.XOACHITIETLUONG(cb_maclv.Text.Trim(), cb_manv.Text.Trim());
                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            frm_main main = new frm_main(matk);
            main.Show();
            this.Hide();
        }
    }
}
