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


namespace OgrenciOtomasyon.Student
{
    public partial class ExamResult : Form
    {
        public ExamResult()
        {
            InitializeComponent();
        }
        public ExamResult(string TeaId)
        {
            InitializeComponent();
            this.TeacherId = TeaId;
        }
        public string TeacherId { get; set; }


        private void ExamResult_Load(object sender, EventArgs e)
        {
            courseListele();
            examListele();
            examResultListele();
        }
        private void examResultListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
               
                string Query = "select * from exam_result where student_id in (select id from ogrenciler where classroom_id in (select classroom_id from classroom  where teacher_id = '" + TeacherId + "'))";                  
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
        private void courseListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "select * from course where classroom_id in (select classroom_id from classroom where teacher_id = '" + TeacherId + "') ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void examListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "select * from exam where classroom_id in (select classroom_id from classroom where teacher_id = '" + TeacherId + "') ";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView3.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(TeacherId);
            frm2.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into exam_result(exam_id,student_id,course_id,marks,classroom_id) values('" + this.txtBoxExamId.Text + "','" + this.txtBoxStudentId.Text + "','" + this.txtboxCourseId.Text + "','" + this.txtBoxMark.Text + "','" + this.txtBoxClassId.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Added Exam Result");
                //ortalamaHesap();
                while (MyReader2.Read())
                {
                }
                examResultListele();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "update exam_result set exam_id='" + this.txtBoxExamId.Text + "',student_id='" + this.txtBoxStudentId.Text + "',course_id='" + this.txtboxCourseId.Text + "',marks='" + this.txtBoxMark.Text + "',classroom_id='" + this.txtBoxClassId.Text + "' where exam_id='" + this.txtBoxExamId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Exam Result Informations Updated");
                while (MyReader2.Read())
                {
                }
                examResultListele();
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxExamId.Clear();
            txtBoxStudentId.Clear();
            txtboxCourseId.Clear();
            txtBoxClassId.Clear();
            txtBoxMark.Clear();
            txtBoxExamId.Focus(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "delete from exam_Result where exam_id='" + this.txtBoxExamId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            examResultListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxExamId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxStudentId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBoxClassId.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtboxCourseId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBoxMark.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
