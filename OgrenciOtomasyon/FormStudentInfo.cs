using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OgrenciOtomasyon
{
    public partial class FormStudentInfo : Form
    {
        Form1 ownerForm = null;
        public FormStudentInfo()
        {
            InitializeComponent();
        }
        public FormStudentInfo(string StuNum)
        {
            InitializeComponent();
            this.StudentNum = StuNum;
        }

        public string StudentNum { get; set; }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {
            lblStudentNumber.Text = StudentNum;
            ogrenciListele();

            string MyConnection3 = "server=localhost;user id=root;database=obs";
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
            string Query = "select * from ogrenciler where numara='" + lblStudentNumber.Text + "';";
            MySqlCommand cmd = new MySqlCommand("select * from ogrenciler where numara='" + lblStudentNumber.Text + "';", MyConn3);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MyConn3.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["ad"].ToString());
                listBox2.Items.Add(dr["soyad"].ToString());
                listBox3.Items.Add(dr["numara"].ToString());
                listBox4.Items.Add(dr["ders"].ToString());
                listBox5.Items.Add(dr["uyruk"].ToString());
                listBox6.Items.Add(dr["vize"].ToString());
                listBox7.Items.Add(dr["final"].ToString());
                listBox8.Items.Add(dr["ortalama"].ToString());
                listBox9.Items.Add(dr["durum"].ToString());

            }
            MyConn3.Close();

        }
        

        private void ogrenciListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //Display query
                string Query = "select * from ogrenciler where numara='" + lblStudentNumber.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                                                   // MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //This is my connection string i have assigned the database file address path
            string MyConnection2 = "server=localhost;user id=root;database=obs";
            //This is my update query in which i am taking input from the user through windows forms and update the record.
            string Query = "update ogrenciler set password='" + this.txtBoxChangePassword.Text + "' where numara='" + lblStudentNumber.Text + "';";
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Password Changed");
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();//Connection closed here
            txtBoxChangePassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
