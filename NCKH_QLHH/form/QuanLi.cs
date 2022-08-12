using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.IO.Ports;
using System.Xml;
using NCKH_QLHH.form;

namespace NCKH_QLHH
{
    public partial class QuanLi : Form
    {
        int soluong;
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        public QuanLi()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboBox2.Items.AddRange(BaudRate);
        }      
        
        private void GetAllProduct()
        {
            DataSet data = new DataSet();
            
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                const string sql = "select * from QLHH_main where id = @id";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            this.GV1.DataSource = dt;

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
        

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            label5.Text = ("Chưa kết nối");
            label5.ForeColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void QuanLi_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
            comboBox2.SelectedIndex = 3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {

                label5.Text = ("Chưa kết nối");
                label5.ForeColor = Color.Red;
            }
            else if (serialPort1.IsOpen)
            {

                label5.Text = ("Đã kết nối");
                label5.ForeColor = Color.Green;

            }
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
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                chuoi = InputData;
                ID = Convert.ToInt64(chuoi);
                this.textBox1.Text += text;   
            }
            
        }

             
        string sl1, sl2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetAllProduct();
            DataTable dt = new DataTable();
            var hhBUS = new dao.HangHoaBUS();
            dt = hhBUS.CheckIDHH(chuoi);
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
                            
                            break;
                        case 2:
                            sl1 = temp;
                            soluong = Convert.ToInt32(sl1) + 1;
                            
                            break;
                        case 3:
                            break;

                    }
                    i++;
                    sl2 = Convert.ToString(soluong);
                }
            }
            hhBUS.XuatNhapThung(chuoi, sl2);
            GetAllProduct();
        }


        private void xuat_button_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Quanli2 f3 = new Quanli2();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void them_button_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Them f3 = new Them();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void sua_button_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Sua f3 = new Sua();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void xoa_button_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Xoa f3 = new Xoa();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
