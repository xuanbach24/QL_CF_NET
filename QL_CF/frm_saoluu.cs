using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CF
{
    public partial class frm_saoluu : Form
    {
        public frm_saoluu()
        {
            InitializeComponent();
        }

        private void btn_macdinh_Click(object sender, EventArgs e)
        {
            string duongdan = "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.MSSQLSERVER\\MSSQL\\Backup";
            richTextBox1.Text= duongdan;
        }

        private void btn_xnsaoluu_Click(object sender, EventArgs e)
        {
            dbQLCFDataContext db=new dbQLCFDataContext();
            string path = richTextBox1.Text;
            if (Directory.Exists(path))
            {
                db.SAOLUU(path + "\\QL_CF.bak");
                MessageBox.Show("Sao Lưu Thành Công.");
            }
            else
            {
                MessageBox.Show("Thư mục không tồn tại.");
            }
        }
    }
}
