using NCKH_QLHH.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_QLHH
{
    public partial class Them : Form
    {
        int soluong;
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        public Them()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboBox2.Items.AddRange(BaudRate);

        }
        private void Show_DataTable()
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

                            this.dataGridView1.DataSource = dt;

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


       
        










        private void btn_sua_Click(object sender, EventArgs e)
        {
            Sua f2 = new Sua();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Show_DataTable();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Xoa f2 = new Xoa();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var hhBUS = new dao.HangHoaBUS();
            hhBUS.ThemHangHoa(txt_id.Text, txt_product.Text, txt_ex.Text, txt_price.Text, 0, 0);
            txt_id.Clear();
            txt_product.Clear();
            txt_ex.Clear();
            txt_price.Clear();
            Show_DataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void Them_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
            comboBox2.SelectedIndex = 3;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void txt_product_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void txt_price_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void txt_ex_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.Open();
                label5.Text = ("Đã kết nối");
                label5.ForeColor = Color.Green;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            label5.Text = ("Chưa kết nối");
            label5.ForeColor = Color.Red;
        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadExisting();
            if (InputData != String.Empty)
            {
                SetText(InputData);
            }

        }

        String chuoi = "";
        long ID;
        private void SetText(string text)
        {
            if (this.txt_id.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                chuoi = InputData;
                ID = Convert.ToInt64(chuoi);
                this.txt_id.Text += text;
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {

                label10.Text = ("Chưa kết nối");
                label10.ForeColor = Color.Red;
            }
            else if (serialPort1.IsOpen)
            {

                label10.Text = ("Đã kết nối");
                label10.ForeColor = Color.Green;

            }
        }
    }
}
