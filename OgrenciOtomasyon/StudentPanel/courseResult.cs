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


namespace OgrenciOtomasyon.StudentPanel
{
    public partial class courseResult : Form
    {
        public courseResult()
        {
            InitializeComponent();
        }
        public courseResult(string StuNum)
        {
            InitializeComponent();
            this.StudentNum = StuNum;
        }
        public string StudentNum { get; set; }


        private void courseResult_Load(object sender, EventArgs e)
        {
            courseListele();
            courseResultListele();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormStudentInfo studentınf = new FormStudentInfo(StudentNum);
            studentınf.Show();
            this.Hide();
        }
        public void courseListele()
        {
            {
                try { 
                    string MyConnection2 = "server=localhost;user id=root;database=obs";
                    string Query = "select name,course_id from course where classroom_id in (select classroom_id from ogrenciler where id = '" + StudentNum + "') ";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    MyConn2.Open();
                    da.SelectCommand = MyCommand2;
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["course_id"].ToString());
                        listitem.SubItems.Add(dr["name"].ToString());
                        listView1.Items.Add(listitem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void courseResultListele()
        {
            try
            {
                string MyConnection = "server=localhost;user id=root;database=obs";
                string Query = "select course_id,ROUND((sum(marks) / count(marks)), 2) as num  from exam_result where course_id in (select course_id from course where classroom_id in (select classroom_id from ogrenciler where id = '" + StudentNum + "') )  and student_id in (select id from ogrenciler where student_id = '" + StudentNum + "') group by course_id";
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
                    ListViewItem listitem = new ListViewItem(dr["course_id"].ToString());
                    listitem.SubItems.Add(dr["num"].ToString());
                    string durum;
                    if (float.Parse(dr["num"].ToString()) >= 50)
                        durum = "Passed";
                    else
                        durum = "Failed";
                    listitem.SubItems.Add(durum);
                    listView2.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //private void ortalamaHesap()
        //{
        //    string MyConnection2 = "server=localhost;user id=root;database=obs";
        //    int sınav1 = Convert.ToInt32(txtBoxMidtermExam.Text);
        //    int sınav2 = Convert.ToInt32(txtBoxFinalExam.Text);
        //    float ort = Convert.ToInt32(sınav1 *  sınav2 / 2);
        //    string durum;
        //    if (ort < 50 || sınav2 < 50)
        //        durum = "Kaldı";
        //    else
        //        durum = "Geçti";
        //    string Query = "update ogrenciler set ortalama='" + ort + "',durum='" + durum + "' where id='" + this.txtboxNumber.Text + "';";
        //    //This is  MySqlConnection here i have created the object and pass my connection string.
        //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
        //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //    MySqlDataReader MyReader2;
        //    MyConn2.Open();
        //    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
        //    MyConn2.Close();
        //}
    }
}
