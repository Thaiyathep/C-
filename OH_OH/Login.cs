using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OH_OH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //ปุ่มเข้าสู่ระบบ
        private void enterbutton_Click(object sender, EventArgs e)
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=angpao;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();


            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM log_username  WHERE Username='" + UsernameTextBoxForm1.Text +
                "' AND Password ='" + PasswordTextBoxForm1.Text + "'", conn))
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                 

                    if (UsernameTextBoxForm1.Text == "admin") //เข้าสู่Admin
                    {
                        FormAM1 f = new FormAM1();
                        this.Hide();
                        f.Show();
                        MessageBox.Show("เข้าสู่ระบบ ADMIN สำเร็จ");
                    }
                    else
                    {
                        Product1 f = new Product1();
                        this.Hide();
                        f.Show();
                        MessageBox.Show("เข้าสู่ระบบ ร้าน อ. อั่งเปามินิมาร์ม ");
                        Program.userid = UsernameTextBoxForm1.Text; ///ใช้เก็บชื่อ
                    }

                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง!!!");
                }

            }
        }

        //สมัครสมาชิก
        private void applybutton_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
           this.Hide();
        }
    }
}
