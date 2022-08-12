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
using Microsoft.SqlServer;
using NCKH_QLHH.form;

namespace NCKH_QLHH
{
    public partial class Sua : Form
    {
        public Sua()
        {
            InitializeComponent();
        }

        private void Show_AllData()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                const string sql = "select * from QLHH_main";

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            this.DGV1.DataSource = dt;

                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void Show_DataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                const string sql = "select * from QLHH_Main";

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            this.DGV1.DataSource = dt;

                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        // Check ID button and fill into text box
     

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var hhBUS = new dao.HangHoaBUS();
            dt = hhBUS.CheckIDHH(txtID.Text);
            int i = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    string temp;
                    temp = item.ToString();
                    switch (i)
                    {
                        case 0:
                            break;
                        case 1:
                            txtName.Text = temp;
                            break;
                        case 2:
                            txtPrice.Text = temp;
                            break;
                        case 3:
                            txtEx.Text = temp;
                            break;

                    }
                    i++;
                }
            }
            Show_DataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa thông tin sản phẩm?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                var hhBUS = new dao.HangHoaBUS();
                hhBUS.SuaHangHoa(txtID.Text, txtName.Text, txtPrice.Text, txtEx.Text);
                txtName.Clear();
                txtPrice.Clear();
                txtEx.Clear();
                Show_DataTable();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void Sua_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void xuat_button_Click(object sender, EventArgs e)
        {
            Quanli2 f3 = new Quanli2();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void nhap_button_Click(object sender, EventArgs e)
        {
            QuanLi f3 = new QuanLi();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void them_button_Click(object sender, EventArgs e)
        {
            Them f3 = new Them();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void xoa_button_Click(object sender, EventArgs e)
        {
            Xoa f3 = new Xoa();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Show_AllData();
        }

        private void txtID_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void txtEx_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }
    }
    
}

