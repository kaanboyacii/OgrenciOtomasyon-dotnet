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
    public partial class courseList : Form
    {
        public courseList()
        {
            InitializeComponent();
        }
        public courseList(string StuNum)
        {
            InitializeComponent();
            this.StudentNum = StuNum;
        }
        public string StudentNum { get; set; }

        private void courseList_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    string MyConnection2 = "server=localhost;user id=root;database=obs";
                    string Query = "select name, time, course_id, description, classroom_id from course where classroom_id in (select classroom_id from ogrenciler where id = '" + StudentNum + "') ";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand2;
                    DataTable dTable = new DataTable();
                    MyAdapter.Fill(dTable);
                    dataGridView1.DataSource = dTable;
                    DataGridViewColumn column = dataGridView1.Columns[1];
                    column.Width = 170;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
