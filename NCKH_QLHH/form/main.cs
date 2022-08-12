using NCKH_QLHH.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_QLHH
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_quanli_Click(object sender, EventArgs e)
        {
            QuanLi f3 = new QuanLi();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            Them f3 = new Them();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quanli2 f3 = new Quanli2();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AboutUs f3 = new AboutUs();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory f3 = new Inventory();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
        string TK, MK, Ten;

        private void textBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            var hhBUS = new dao.HangHoaBUS();
            dt = hhBUS.CheckTKNV(textBox1.Text);
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
                            TK = temp;
                            break;
                        case 1:
                            MK = temp;
                            break;
                        case 2:
                            Ten = temp;
                            break;
                    }
                    i++;
                }
            }

            if ((TK == textBox1.Text) && (MK == textBox2.Text)) 
            {
                btn_quanli.Enabled = true;
                btn_chinhsua.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                label2.Text = (Ten + " đã đăng nhập thành công");
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = ("Sai tài khoản hoặc mật khẩu");
                label2.ForeColor = Color.Red;
                btn_quanli.Enabled = false;
                btn_chinhsua.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
    }
}
