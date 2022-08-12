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

namespace NCKH_QLHH.form
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            txtLe.Text = temp;
                            break;
                        case 8:
                            txtDonGia.Text = temp;
                            break;
                        case 9:
                            txtEx.Text = temp;
                            break;
                        case 10:
                            txtGiaSi.Text = temp;
                            break;
                        case 11:
                            txtDoanhThu.Text = temp;
                            break;
                    }
                    i++;
                }
            }       
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
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
    }
}
