
namespace NCKH_QLHH
{
    partial class QuanLi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.GV1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xoa_button = new System.Windows.Forms.Button();
            this.sua_button = new System.Windows.Forms.Button();
            this.them_button = new System.Windows.Forms.Button();
            this.xuat_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(737, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHẬP HÀNG HÓA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GV1
            // 
            this.GV1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV1.Location = new System.Drawing.Point(288, 492);
            this.GV1.Name = "GV1";
            this.GV1.RowHeadersWidth = 51;
            this.GV1.RowTemplate.Height = 24;
            this.GV1.Size = new System.Drawing.Size(1533, 200);
            this.GV1.TabIndex = 1;
            this.GV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(878, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(878, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hủy kết nối";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(33, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 67);
            this.button4.TabIndex = 14;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(674, 379);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(677, 429);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 24);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1176, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chưa kết nối";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1072, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(288, 726);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1533, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 374);
            this.label3.TabIndex = 39;
            this.label3.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // xoa_button
            // 
            this.xoa_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xoa_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoa_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_button.Location = new System.Drawing.Point(33, 686);
            this.xoa_button.Name = "xoa_button";
            this.xoa_button.Size = new System.Drawing.Size(162, 67);
            this.xoa_button.TabIndex = 38;
            this.xoa_button.Text = "Xóa";
            this.xoa_button.UseVisualStyleBackColor = true;
            this.xoa_button.Click += new System.EventHandler(this.xoa_button_Click);
            // 
            // sua_button
            // 
            this.sua_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sua_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sua_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_button.Location = new System.Drawing.Point(33, 593);
            this.sua_button.Name = "sua_button";
            this.sua_button.Size = new System.Drawing.Size(162, 67);
            this.sua_button.TabIndex = 37;
            this.sua_button.Text = "Sửa";
            this.sua_button.UseVisualStyleBackColor = true;
            this.sua_button.Click += new System.EventHandler(this.sua_button_Click);
            // 
            // them_button
            // 
            this.them_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.them_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.them_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_button.Location = new System.Drawing.Point(33, 492);
            this.them_button.Name = "them_button";
            this.them_button.Size = new System.Drawing.Size(162, 67);
            this.them_button.TabIndex = 36;
            this.them_button.Text = "Thêm";
            this.them_button.UseVisualStyleBackColor = true;
            this.them_button.Click += new System.EventHandler(this.them_button_Click);
            // 
            // xuat_button
            // 
            this.xuat_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xuat_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuat_button.Location = new System.Drawing.Point(33, 379);
            this.xuat_button.Name = "xuat_button";
            this.xuat_button.Size = new System.Drawing.Size(162, 67);
            this.xuat_button.TabIndex = 35;
            this.xuat_button.Text = "Xuất hàng";
            this.xuat_button.UseVisualStyleBackColor = true;
            this.xuat_button.Click += new System.EventHandler(this.xuat_button_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(1511, 1007);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Phầm mềm phát triển bởi Lập trình viên Nguyễn Thành Đạt";
            // 
            // QuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xoa_button);
            this.Controls.Add(this.sua_button);
            this.Controls.Add(this.them_button);
            this.Controls.Add(this.xuat_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GV1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GV1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button xoa_button;
        private System.Windows.Forms.Button sua_button;
        private System.Windows.Forms.Button them_button;
        private System.Windows.Forms.Button xuat_button;
        private System.Windows.Forms.Label label4;
    }
}