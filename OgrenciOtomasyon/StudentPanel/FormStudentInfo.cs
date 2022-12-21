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
                textBox1.Text = dr["classroom_id"].ToString();
                txtBoxContact.Text = dr["iletisim"].ToString();
                txtBoxGender.Text = dr["cinsiyet"].ToString();
                txtBoxAddress.Text = dr["adres"].ToString();
                txtBoxAbsen.Text = dr["absenteeism"].ToString();
                //listBox1.Items.Add(dr["ad"].ToString());
            }
            MyConn3.Close();

        }

        private void ogrenciSınavlarınıListele()
        {
            try
            {
                string MyConnection = "server=localhost;user id=root;database=obs";
                string Query = "SELECT name FROM exam WHERE classroom_id in (select classroom_id from ogrenciler where id = '" + lblStudentNumber.Text + "') and exam_id in (select exam_id from exam_result where student_id = '" + lblStudentNumber.Text + "') ";
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
                string Query = "select marks from exam_result where student_id in (select id from ogrenciler where classroom_id in (select classroom_id from exam where classroom_id in (select classroom_id from ogrenciler where id = '" + lblStudentNumber.Text + "') ) ) and student_id in (select id from ogrenciler where student_id = '" + lblStudentNumber.Text + "')";
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

        private void btnExamCalender_Click(object sender, EventArgs e)
        {
            examCalender exmcl = new examCalender(StudentNum);
            exmcl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentPanel.courseList cour = new StudentPanel.courseList(StudentNum);
            cour.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentPanel.courseResult courseR = new StudentPanel.courseResult(StudentNum);
            courseR.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentPanel.classResult courseR = new StudentPanel.classResult(StudentNum);
            courseR.Show();
            this.Hide();
        }
    }
}
