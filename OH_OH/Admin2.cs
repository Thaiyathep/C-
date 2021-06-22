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
using System.IO;

namespace OH_OH
{
    public partial class FormAM2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=angpao;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }



        public FormAM2()
        {
            InitializeComponent();
        }
        
        private void FormAM2_Load(object sender, EventArgs e)
        {
            showStock();
            showType();
        }
                
        private void showStock()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stock";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();

            dataAM.DataSource = ds.Tables[0].DefaultView; //เเสดงตารางในdata1
        }
        
        public string type;
        private void showType()
        {
            if(radioButton6.Checked)
            {
                showStock();
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

                dataAM.DataSource = ds.Tables[0].DefaultView; //เเสดงตารางในdata1
            }
            
        }
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


        private void dataAM_CellClick(object sender, DataGridViewCellEventArgs e)
        {             
               dataAM.CurrentRow.Selected = true; 
            try
            {
                FiletextBox.Clear(); 
                NameProductAM2.Text = dataAM.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                NumberAM2.Text = dataAM.Rows[e.RowIndex].Cells["Number"].FormattedValue.ToString();
                PriceAM2.Text = dataAM.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                TypeAM2.Text= dataAM.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();

                dataAM.CurrentRow.Selected = true;
                int selectedRow = dataAM.CurrentCell.RowIndex;  // CurrentCell.RowIndex คลิกที่ไหน selectedRow เปลี่ยนไปตามที่คลิก
                                      
                string addname = Convert.ToString(dataAM.Rows[selectedRow].Cells["name"].Value);
                //.Cells["Product"].Value คือ รับค่าจาก cellที่มีหัวคอลัม ชื่อ name แถวที่ [selectedRow] แปรงเป็น string เเล้วนำไปใส่ใน addname
                MySqlConnection con = databaseConnection();
                MySqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "SELECT Image FROM stock WHERE name = '" + addname + "'  ";


                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //แปลงข้อมูลเพื่อไปแสดงหน้าโปรแกรม
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);  ///เรียกใช้ข้อมูลจาก dataset บรรทัด 47 ใช้ตารางช่อง 0 เเถว0 หัวคอลัมชื่อ Image นำไปใส่ตัวแปรที่ชื่อ ms 
                    pictureBox1.Image = new Bitmap(ms); //จากนั้นเเสดงลงใน pictureBox1
                }

            }
            catch
            {

            }
        }

       
        //ลบสินค้าสต็อก
        private void Delbutton_Click(object sender, EventArgs e)
        {
            int selectedRow = dataAM.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataAM.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            string sql = "DELETE  FROM stock Where Id = '" + editId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบสินค้าเสร็จสิ้น");
                showStock();
                NameProductAM2.Clear();
                NumberAM2.Clear();
                PriceAM2.Clear();                  
            }
        }
        //แก้ไขสินค้าสต็อก
        private void Chbutton_Click(object sender, EventArgs e)
        {

            if (FiletextBox.Text == "")
            {
                int selectedRow = dataAM.CurrentCell.RowIndex;
                int editId = Convert.ToInt32(dataAM.Rows[selectedRow].Cells["id"].Value);

                MySqlConnection conn = databaseConnection();
                string sql = "UPDATE stock set name = '" + NameProductAM2.Text +"',Number='" + NumberAM2.Text + "',Price='" + PriceAM2.Text + "',Type='"+TypeAM2.Text+"' Where id = '" + editId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                    showStock();
                    NameProductAM2.Clear();
                    NumberAM2.Clear();
                    PriceAM2.Clear();
                }
            }
            else
            {
                int selectedRow = dataAM.CurrentCell.RowIndex;
                int editId = Convert.ToInt32(dataAM.Rows[selectedRow].Cells["id"].Value);

                MySqlConnection conn = databaseConnection();
                byte[] image = null;
                string filepath = FiletextBox.Text;
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
                string sql = "UPDATE stock set name = '" + NameProductAM2.Text +
                    "',Number='" + NumberAM2.Text + "',Price='" + PriceAM2.Text + "',Image=      @Imgg Where id = '" + editId + "'";
                       
             
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Open();
                    MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                    cmd2.Parameters.Add(new MySqlParameter("@Imgg", image));
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    showStock();
                    NameProductAM2.Clear();
                    NumberAM2.Clear();
                    PriceAM2.Clear();
                    TypeAM2.Text = ""; //ไม่มีไร เหมือนกัน
                }
                

            }
            
        }
        //เพิ่มสินค้า
        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = databaseConnection();
                byte[] image = null;
                /// File
                string filepath = FiletextBox.Text;
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);
                string sql2 = $" INSERT INTO stock (name,Number,Price,Type,Image) VALUES('" + NameProductAM2.Text + "','" + NumberAM2.Text + "','" + PriceAM2.Text + "','" + TypeAM2.Text + "',@Imgg)";
                if (con.State != ConnectionState.Open)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                    cmd2.Parameters.Add(new MySqlParameter("@Imgg", image));
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    showStock();
                    NameProductAM2.Clear();
                    NumberAM2.Clear();
                    PriceAM2.Clear();
                    TypeAM2.Text = ""; //ไม่มีไร เหมือนกัน
                }
            }
            catch
            {
                MessageBox.Show("รายการสินค้ามีอยู่เเล้ว!");
            }
           
        }
        // image filters
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)| *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                FiletextBox.Text = open.FileName;
            }
        }
        //ย้อนกลับ
        private void Backbutton_Click(object sender, EventArgs e)
        {
            FormAM1 A = new FormAM1();
            A.Show();
            this.Close();

        }

    }
}
