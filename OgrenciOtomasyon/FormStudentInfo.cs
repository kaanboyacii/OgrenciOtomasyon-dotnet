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
            ogrenciListele();
            ogrenciSınavlarınıListele();
            ogrenciSınavNotlarınıListele();
            lblStudentNumber.Text = StudentNum;
            string MyConnection3 = "server=localhost;user id=root;database=obs";
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
            string Query = "select * from ogrenciler where id='" + lblStudentNumber.Text + "';";
            MySqlCommand cmd = new MySqlCommand("select * from ogrenciler where id='" + lblStudentNumber.Text + "';", MyConn3);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MyConn3.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                txtBoxFirstName.Text = dr["ad"].ToString();
                txtBoxLastName.Text = dr["soyad"].ToString();
                txtBoxId.Text = dr["id"].ToString();
                txtBoxContact.Text = dr["iletisim"].ToString();
                txtBoxGender.Text = dr["cinsiyet"].ToString();
                txtBoxAddress.Text = dr["adres"].ToString();
                //listBox1.Items.Add(dr["ad"].ToString());
                //listBox2.Items.Add(dr["soyad"].ToString());
                //listBox3.Items.Add(dr["id"].ToString());
                //listBox4.Items.Add(dr["iletisim"].ToString());
                //listBox5.Items.Add(dr["adres"].ToString());
                //listBox6.Items.Add(dr["cinsiyet"].ToString());
            }
            MyConn3.Close();

        }

        private void ogrenciSınavlarınıListele()
        {
            try
            {
                string MyConnection = "server=localhost;user id=root;database=obs";
                string Query = "SELECT name FROM course WHERE course_id = (select course_id from ogrenciler where id = '" + lblStudentNumber.Text + "') ";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand1 = new MySqlCommand(Query, MyConn);
 
                MySqlDataAdapter da = new MySqlDataAdapter();
                MyConn.Open();
                da.SelectCommand = MyCommand1;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["name"].ToString());
                    listView1.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ogrenciSınavNotlarınıListele()
        {
            try
            {
                string MyConnection = "server=localhost;user id=root;database=obs";
                string Query = "select marks from exam_result where student_id='" + lblStudentNumber.Text + "' ";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand1 = new MySqlCommand(Query, MyConn);

                MySqlDataAdapter da = new MySqlDataAdapter();
                MyConn.Open();
                da.SelectCommand = MyCommand1;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["marks"].ToString());
                    listView2.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ogrenciListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //Display query
                string Query = "select * from ogrenciler where id='" + lblStudentNumber.Text + "';";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            MessageBox.Show("Page Refreshed");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            PasswordChange pass = new PasswordChange(StudentNum);
            pass.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
