using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CF
{
    public partial class frm_thongtin : Form
    {

        string connectionString = "Data Source=.;Initial Catalog=QL_QUANCAFE;Integrated Security=True";
        string matk;
        public frm_thongtin(string matk)
        {
            InitializeComponent();
            this.matk = matk;
        }

        private void frm_thongtin_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

        }

        private void btn_ttkh_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("XUATTHONGTINKHCR", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Lắng nghe các thông báo từ SQL Server
                conn.InfoMessage += Conn_InfoMessage;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            groupBox1.Visible = false;
            


        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            
        }

        private void Conn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // Hiển thị các thông báo trong RichTextBox
            foreach (var message in e.Message.Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    richTextBox1.AppendText(message + Environment.NewLine+('\n'));
                }
            }

        }

        private void btn_slbanra_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            groupBox1.Visible = true;
            
        }

        private void btn_tongtien_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("TTDONHANG", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Lắng nghe các thông báo từ SQL Server
                    conn.InfoMessage += Conn_InfoMessage;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            groupBox1.Visible = false;

        }

        private void btn_capnhatLnv_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CAPNHATTHONGTINLUONG", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Lắng nghe các thông báo từ SQL Server
                    conn.InfoMessage += Conn_InfoMessage;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            groupBox1.Visible = false;

        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            int thang = dateTimePicker1.Value.Month;
            int nam = dateTimePicker1.Value.Year;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("XUATSOLGBANRA", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Thang", thang);  
                    cmd.Parameters.AddWithValue("@Nam", nam);     

                    conn.InfoMessage += Conn_InfoMessage;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
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
