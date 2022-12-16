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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }
        public Course(string TeaId)
        {
            InitializeComponent();
            this.TeacherId = TeaId;
        }
        public string TeacherId { get; set; }


        private void Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'obsDataSet9.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter2.Fill(this.obsDataSet9.course);
            // TODO: This line of code loads data into the 'obsDataSet8.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.obsDataSet8.course);
            courseListele();

        }
        private void courseListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "select * from course where classroom_id in (select classroom_id from classroom where teacher_id = '" + TeacherId + "') ";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs"; 
                string Query = "insert into course(course_id,name,classroom_id,description) values('" + this.txtBoxId.Text + "','" + this.txtBoxName.Text + "','" + this.txtboxClassId.Text + "','" + this.txtBoxDesc.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Added Course");
                //ortalamaHesap();
                while (MyReader2.Read())
                {
                }
                courseListele();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtboxClassId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBoxDesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "update course set course_id='" + this.txtBoxId.Text + "',name='" + this.txtBoxName.Text + "',grade_id='" + this.txtboxClassId.Text + "',description='" + this.txtBoxDesc.Text + "' where course_id='" + this.txtBoxId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Course Informations Updated");
                while (MyReader2.Read())
                {
                }
                courseListele();
                MyConn2.Close();//Connection closed here
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxId.Clear();
            txtBoxName.Clear();
            txtboxClassId.Clear();
            txtBoxDesc.Clear();
            txtBoxId.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "delete from course where course_id='" + this.txtBoxId.Text + "';";
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
            courseListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumara_Click(object sender, EventArgs e)
        {

        }

        private void txtboxGradeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
