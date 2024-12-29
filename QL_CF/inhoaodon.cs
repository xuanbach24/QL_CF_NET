using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QL_CF
{
    public partial class inhoaodon : Form
    {
        public string mahd = "";
        public inhoaodon(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }
        private void inhoaodon_Load(object sender, EventArgs e)
        {

                dbQLCFDataContext db=new dbQLCFDataContext();   
                // Truy vấn dữ liệu từ View INHOADON
                var data = db.INHOADONs.Where(x => x.MAHDBH == mahd).ToList();

                // Kiểm tra nếu có dữ liệu
                if (data !=null)
                {
                    var reportDataSource = new ReportDataSource("data_inhoadon", data);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            this.reportViewer1.RefreshReport();
        }
    }
}
