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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string TeaId)
        {
            InitializeComponent();
            this.TeacherId = TeaId;
        }
        public string TeacherId { get; set; }

        private void ogrenciListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //Display query
                string Query = "select * from ogrenciler where classroom_id in (select classroom_id from classroom where teacher_id = '" + TeacherId + "') ";
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
      
        private void Form2_Load(object sender, EventArgs e)
        {
            ogrenciListele();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String gender = "";
                if (radioButtonMale.Checked == true)  
                    gender = "Male";                  
                if (radioButtonFemale.Checked == true)
                    gender = "Female";
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "insert into ogrenciler(id,ad,soyad,classroom_id,iletisim,cinsiyet,adres) values('" + this.txtBoxId.Text + "','" + this.txtBoxFirstName.Text + "','" + this.txtBoxLastName.Text + "','" + this.txtBoxClass.Text + "','" + this.txtboxNumber.Text + "','" + gender + "','" + this.txtBoxAdres.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();  
                MessageBox.Show("Added Student");
                //ortalamaHesap();
                while (MyReader2.Read())
                {
                }
                ogrenciListele();
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
                String gender = "";
                if (radioButtonMale.Checked == true)  
                    gender = "Male";                  
                if (radioButtonFemale.Checked == true)
                    gender = "Female";
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "update ogrenciler set id='" + this.txtBoxId.Text + "',ad='" + this.txtBoxFirstName.Text + "',soyad='" + this.txtBoxLastName.Text + "',classroom_id='" + this.txtBoxClass.Text + "',iletisim='" + this.txtboxNumber.Text + "',cinsiyet='" + gender + "',adres='" + this.txtBoxAdres.Text + "' where id='" + this.txtBoxId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Student Informations Updated");
                while (MyReader2.Read())
                {
                }
                ogrenciListele();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "delete from ogrenciler where id='" + this.txtBoxId.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Student Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ogrenciListele();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxId.Clear();
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxClass.Clear();
            txtboxNumber.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtBoxAdres.Clear();
            txtBoxId.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBoxClass.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtboxNumber.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            String gender = "";
            if (radioButtonMale.Text == dataGridView1.CurrentRow.Cells[5].Value.ToString())
                radioButtonMale.Select();
                gender = "Male";                  
            if (radioButtonFemale.Text == dataGridView1.CurrentRow.Cells[5].Value.ToString())
                radioButtonFemale.Select();
                gender = "Female";
            txtBoxAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student.Course course = new Student.Course(TeacherId);
            course.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student.Exam exam = new Student.Exam(TeacherId);
            exam.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student.ExamResult examre = new Student.ExamResult(TeacherId);
            examre.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student.Absen abs = new Student.Absen(TeacherId);
            abs.Show();
            this.Hide();
        }
    }
}
