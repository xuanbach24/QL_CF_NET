using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using System.Collections.Specialized;
using System.Data.SqlClient;
namespace QL_CF
{
    public partial class frm_DangNhap : Form
    {
        dbQLCFDataContext db = new dbQLCFDataContext();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string matk = "";
            string user= txt_user.Text.Trim();
            string pass= txt_pass.Text.Trim();
            var check = db.NHANVIENs.FirstOrDefault(x => x.SDT == user && x.MATKHAU == pass);
                if (check != null)
                {
                    matk = check.MANV.ToString();
                    frm_main frm = new frm_main(matk.Trim());
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin");
                }
        }


    }
}
