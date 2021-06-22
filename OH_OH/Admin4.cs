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
    public partial class FormAM4 : Form
    {
        List<Bill> showbillHistory = new List<Bill>();
        private MySqlConnection databaseConnection()
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=angpao;Allow User Variables = True";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public FormAM4()
        {
            InitializeComponent();
        }

       

      
        private void showHistoryAM()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM history";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataHistoryAM.DataSource = ds.Tables[0].DefaultView;
            sum = 0; //ตัวแปรจำนวนยอดเงิน
            total = 0; //ตัวแปรยอดรวมจำนวนสินค้า
            conn.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                sum = sum + int.Parse(read.GetString(3));
                total = total + int.Parse(read.GetString(4));
            }
            TotalnumbertextBox.Text = $"{sum}";
            TotalcosttextBox.Text = $"{total}";
            conn.Close();
        }

        private void FormAM4_Load(object sender, EventArgs e)
        {
            showHistoryAM();
            

        }


        public string printhistory;
        int total;
        int sum;
        //ปุ่มค้นหา
        private void searchButton_Click(object sender, EventArgs e)
        {
            showbillHistory.Clear();
            if (searchBox.Text != "")
            {
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                if(Typehistory.Text == "สินค้าทั้งหมด")
                {
                    cmd.CommandText = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND (Nameuser like \"%{searchBox.Text}%\" or Name like \"%{searchBox.Text}%\")";
                    printhistory = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND (Nameuser like \"%{searchBox.Text}%\" or Name like \"%{searchBox.Text}%\")";//ปริ้น
                }
                else
                {
                    cmd.CommandText = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND Type like \"%{Typehistory.Text}%\"  AND (Nameuser like \"%{searchBox.Text}%\" or Name like \"%{searchBox.Text}%\") ";
                    printhistory = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND Type like \"%{Typehistory.Text}%\"  AND (Nameuser like \"%{searchBox.Text}%\" or Name like \"%{searchBox.Text}%\") "; //ปริ้น
                }
                
               
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTime1.Value.ToString("yyyy-MM-dd")); //เอาค่าจาก dateTimePicker ไปเก็บที่ parameters @date1
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTime2.Value.ToString("yyyy-MM-dd"));
                da.SelectCommand.Parameters.AddWithValue("@data", searchBox.Text);
                da.SelectCommand.Parameters.AddWithValue("@data2", Typehistory.Text);
                da.Fill(ds);
                conn.Close();
                dataHistoryAM.DataSource = ds.Tables[0].DefaultView;
                sum = 0; //ตัวแปรจำนวนเงิน
                total = 0; //ตัวแปรยอดรวมจำนวนสินค้า
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    sum = sum + int.Parse(read.GetString(3));
                    total = total + int.Parse(read.GetString(4));
                }
                TotalnumbertextBox.Text = $"{sum}";
                TotalcosttextBox.Text = $"{total}";
                conn.Close();
                billHistory();
            }
            else
            {
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                if (Typehistory.Text == "สินค้าทั้งหมด")
                {
                    cmd.CommandText = $"SELECT * FROM history WHERE Date between @date1 and @date2 ";
                    printhistory = $"SELECT * FROM history WHERE Date between @date1 and @date2 "; //ปริ้น
                }
                else //ไม่ได้ใส่การค้นหา
                {
                    cmd.CommandText = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND Type like \"%{Typehistory.Text}%\" ";
                    printhistory = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND Type like \"%{Typehistory.Text}%\""; //ปริ้น

                }
                    

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTime1.Value.ToString("yyyy-MM-dd"));
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTime2.Value.ToString("yyyy-MM-dd"));
                da.Fill(ds);
                conn.Close();
                dataHistoryAM.DataSource = ds.Tables[0].DefaultView;
                sum = 0; //ตัวแปรจำนวนยอดเงิน
                total = 0; //ตัวแปรยอดรวมจำนวนสินค้า
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    sum = sum + int.Parse(read.GetString(3));
                    total = total + int.Parse(read.GetString(4));
                }
                TotalnumbertextBox.Text = $"{sum}";
                TotalcosttextBox.Text = $"{total}";
                conn.Close();
                billHistory();
            }
        }



            private void billHistory()
            {

                MySqlConnection conn = databaseConnection();
                DataSet ds =  new DataSet();
                MySqlCommand bnn = new MySqlCommand(printhistory, conn); //printhistory ปริ้นให้เหมือนกับ ค้นหา
                MySqlDataAdapter da = new MySqlDataAdapter(bnn);
                conn.Open();
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTime1.Value.ToString("yyyy-MM-dd")); //จากปุ่มค้นหา
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTime2.Value.ToString("yyyy-MM-dd")); //จากปุ่มค้นหา
                da.SelectCommand.Parameters.AddWithValue("@data", searchBox.Text); //ปุ่มค้นหา
                da.Fill(ds);
            
                MySqlDataReader adapter = bnn.ExecuteReader();
                while (adapter.Read())
                {

                    Program.name = adapter.GetString("Name").ToString();
                    Program.cost = adapter.GetString("Price").ToString();
                    Program.Nuber = adapter.GetString("Number").ToString();
                

                    Bill item = new Bill()
                    {
                    name = Program.name,
                    cost = Program.cost,
                    Nuber = Program.Nuber,
                    
                    };
                    showbillHistory.Add(item);

                }
                conn.Close();
            }

 

        //ปริ้น
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("สรุปยอดขายสินค้า", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("A. ANGPON MINIMARY", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(255, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
            if (dateTime1.Text == dateTime2.Text)
            {
                e.Graphics.DrawString("วันที่ " + dateTime1.Text, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 240));
            }
            else
            {
                e.Graphics.DrawString("ตั้งแต่ " + dateTime1.Text + "  สิ้นสุด " + dateTime2.Text, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 240));
            }

            if (searchBox.Text == "")
            {
                e.Graphics.DrawString("ชื่อ " + "รายการที่ขายได้", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            }
            else
            {
                e.Graphics.DrawString("ชื่อ " + searchBox.Text, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            }

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ          ชื่อสินค้า                                 จำนวน                      ราคา (บาท)", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int number = 1;
            int y = 345;

            foreach (var i in showbillHistory)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(190, y));
                e.Graphics.DrawString("   " + i.Nuber, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(500, y));
                e.Graphics.DrawString("   " + i.cost, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(720, y));
                number = number + 1;
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
           
            e.Graphics.DrawString("จำนวนที่ขายได้         " + TotalnumbertextBox.Text + " ชิ้น", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(500, ((y + 30) + 45) + 45));
            e.Graphics.DrawString("จำนวนเงินที่ได้รับ       " + TotalcosttextBox.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(500, (((y + 30) + 45) + 45) + 45));

        }

        //ปริ้น
        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1; //ปริ้น
            printPreviewDialog1.ShowDialog();
        }
        //ย้อนกลับ
        private void Backbutton_Click(object sender, EventArgs e)
        {
            FormAM1 A = new FormAM1();
            A.Show();
            this.Close();
        }
        
        //รีเฟส
        private void button_Click_1(object sender, EventArgs e)
        {
            searchBox.Clear();
            Typehistory.Text = "สินค้าทั้งหมด";
            TotalnumbertextBox.Clear();
            TotalcosttextBox.Clear();
            showHistoryAM();
        }
    }
     
}
