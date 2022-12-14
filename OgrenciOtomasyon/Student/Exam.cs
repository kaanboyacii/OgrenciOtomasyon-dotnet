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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }
        public Exam(string TeaId)
        {
            InitializeComponent();
            this.TeacherId = TeaId;
        }
        public string TeacherId { get; set; }

        private void Exam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'obsDataSet7.exam' table. You can move, or remove it, as needed.
            this.examTableAdapter.Fill(this.obsDataSet7.exam);
            examListele();
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
                dataGridView1.DataSource = dTable;
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
                string Query = "insert into exam(exam_id,name,start_Date,classroom_id) values('" + this.txtBoxId.Text + "','" + this.txtBoxName.Text + "','" + this.dateStartDateTime.Text + "','" + this.txtBoxClassId.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Added Exam");
                //ortalamaHesap();
                while (MyReader2.Read())
                {
                }
                examListele();
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
                string Query = "update exam set exam_id='" + this.txtBoxId.Text + "',name='" + this.txtBoxName.Text + "',start_Date='" + this.dateStartDateTime.Text + "',classroom_id='" + this.txtBoxClassId.Text + "' where exam_id='" + this.txtBoxId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Exam Informations Updated");
                while (MyReader2.Read())
                {
                }
                examListele();
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxId.Clear();
            txtBoxName.Clear();
            txtBoxClassId.Clear();
            dateStartDateTime.CustomFormat = " ";
            txtBoxId.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "delete from exam where exam_id='" + this.txtBoxId.Text + "';";
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
            examListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateStartDateTime.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBoxClassId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
