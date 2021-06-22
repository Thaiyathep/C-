using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OH_OH
{
    public partial class FormAM1 : Form
    {
        public FormAM1()
        {
            InitializeComponent();
        }

        //แก้ไขสินค้า
        private void button1_Click(object sender, EventArgs e)
        {
            FormAM2 A = new FormAM2();
            A.Show();
            this.Close();
        }
        //เช็คจำนวน
        private void button2_Click(object sender, EventArgs e)
        {
            FormAM3 A = new FormAM3();
            A.Show();
            this.Close();
        }
        //ประวัติการซื้้อ
        private void button3_Click(object sender, EventArgs e)
        {
            FormAM4 A = new FormAM4();
            A.Show();
            this.Close();
        }
        //ออกจากระบบ
        private void Exitbutton_Click(object sender, EventArgs e)
        {

            DialogResult del = MessageBox.Show("ต้องการออกจากระบบใช่หรือๆไม่?", "คำเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (del == DialogResult.Yes)
            {
                MessageBox.Show("ออกจากระบบเรียบร้อย");
                this.Close();
                Login l = new Login();
                l.Show();
            }
            else
            {
                MessageBox.Show("ยกเลิกเรียบร้อย");
            }
        }
    }
}
