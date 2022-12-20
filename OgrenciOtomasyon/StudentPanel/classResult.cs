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
    public partial class classResult : Form
    {
        public classResult()
        {
            InitializeComponent();
        }
        public classResult(string StuNum)
        {
            InitializeComponent();
            this.StudentNum = StuNum;
        }
        public string StudentNum { get; set; }


        private void classResult_Load(object sender, EventArgs e)
        {
            ResultListele();
        }
        private void ResultListele()
        {
            try
            {
                string MyConnection = "server=localhost;user id=root;database=obs";
                string Query = "select classroom_id,ROUND((sum(marks) / count(marks)), 2) as num  from exam_result where course_id in (select course_id from course where classroom_id in (select classroom_id from ogrenciler where id = '" + StudentNum + "') )  and student_id in (select id from ogrenciler where student_id = '" + StudentNum + "')";
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
                    ListViewItem listitem = new ListViewItem(dr["num"].ToString());
                    string durum;
                    if (float.Parse(dr["num"].ToString()) >= 50)
                        durum = "Passed";
                    else
                        durum = "Failed";
                    listitem.SubItems.Add(durum);
                    listView1.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormStudentInfo studentınf = new FormStudentInfo(StudentNum);
            studentınf.Show();
            this.Hide();
        }
    }
}
