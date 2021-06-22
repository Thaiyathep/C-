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
    public partial class FormAM3 : Form
    {
        List<Bill> showbillstock = new List<Bill>();

        private MySqlConnection databaseConnection()
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=angpao;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public FormAM3()
        {
            InitializeComponent();
        }

        private void FormAM3_Load(object sender, EventArgs e)
        {
            checktype();
            showType();

        }

        public string type;
        private void showType()
        {

            if (radioButton6.Checked)
            {
                checktype();
                showProductAM();
            }
            else
            {
                checktype(); //เช็ค
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM stock WHERE Type = '" + type + "'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                conn.Close();

                dataProductAM.DataSource = ds.Tables[0].DefaultView; //เเสดงตารางในdata1
            }

        }
        //คลิกปุ่ม radioBtton
        private void checktype()
        {
            if (radioButton1.Checked)
            {
                type = "สุขภัณฑ์ครัวเรือน";
            }
            if (radioButton2.Checked)
            {
                type = "เครื่องปรุง";
            }
            if (radioButton3.Checked)
            {
                type = "อาหารสำเร็จรูป";
            }
            if (radioButton4.Checked)
            {
                type = "เครื่องดื่ม";
            }
            if (radioButton5.Checked)
            {
                type = "อาหารว่าง";
            }
            if (radioButton6.Checked)
            {
                type = "สินค้าทั้งหมด";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }


        private void showProductAM()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stock ";
            printstock = "SELECT * FROM stock "; 
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();

            dataProductAM.DataSource = ds.Tables[0].DefaultView;
        }

        

        //ค้นหา
        public int sum;
        public string printstock;
        private void searchbutton_Click(object sender, EventArgs e)
        {
            showbillstock.Clear();
            if (searchbutton.Text == "")
            {
                showProductAM();
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                if (type == "สินค้าทั้งหมด")
                {
                    cmd.CommandText = $"SELECT * FROM stock WHERE name like \"%{searchAM3.Text}%\"";
                    printstock = $"SELECT * FROM stock WHERE name like \"%{searchAM3.Text}%\"";
                }
                else
                {
                    cmd.CommandText = $"SELECT * FROM stock WHERE name like \"%{searchAM3.Text}%\" and Type like \"%{type}%\" ";
                    printstock = $"SELECT * FROM stock WHERE name like \"%{searchAM3.Text}%\" and Type like \"%{type}%\" ";
                }


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                MySqlDataReader read = cmd.ExecuteReader();
                sum = 0;
                while (read.Read())
                {
                    sum = sum + int.Parse(read.GetString(3));
                    
                }
                numbertextBox.Text = $"{sum}";                          
                conn.Close();
                dataProductAM.DataSource = ds.Tables[0].DefaultView;
                billstock();
            }

        }
        private void billstock()
        {

            MySqlConnection conn = databaseConnection();
            MySqlCommand bnn = new MySqlCommand(printstock, conn); //printhistory ปริ้นให้เหมือนกับ ค้นหา        
            conn.Open();

            MySqlDataReader adapter = bnn.ExecuteReader();
            while (adapter.Read())
            {

                Program.name = adapter.GetString("Name").ToString();
                Program.Nuber = adapter.GetString("Number").ToString();


                Bill item = new Bill()
                {
                    name = Program.name,
                    Nuber = Program.Nuber,

                };
                showbillstock.Add(item);

            }
            conn.Close();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("สรุปยอดขายสินค้า", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("A. ANGPON MINIMARY", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(255, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(450, 150));


            if (searchAM3.Text == "")
            {
                e.Graphics.DrawString("ชื่อ " + "รายการสินค้า", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            }
            else
            {
                e.Graphics.DrawString("ชื่อ " + searchAM3.Text, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            }

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ          ชื่อสินค้า                                                            จำนวน (ชิ้น)", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int number = 1;
            int y = 345;

            foreach (var i in showbillstock)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(190, y));
                e.Graphics.DrawString("   " + i.Nuber, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(650, y));
                
                number = number + 1;
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));

            e.Graphics.DrawString("จำนวนสินค้าที่เหลือ         " + numbertextBox.Text + " ชิ้น", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(500, ((y + 30) + 45) + 45));
           

        
     
        }               
        
        //ปุ่มปริ้น
       private void Printstockbutton_Click(object sender, EventArgs e)
       {
            printPreviewDialog1.Document = printDocument1; //ปริ้น
            printPreviewDialog1.ShowDialog();
            searchAM3.Clear();
       }
        //รีเฟส
        private void button_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true; //กลับไปเช็คทั้งหมด
            checktype();
            showProductAM();
            
        }
        //ปุ่มกลับ
        private void Backbutton_Click(object sender, EventArgs e)
        {
            FormAM1 A = new FormAM1();
            A.Show();
            this.Close();
        }

        
    }

    
}
