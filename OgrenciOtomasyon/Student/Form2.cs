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
                string Query = "select * from ogrenciler where classroom_id = (select classroom_id from classroom where teacher_id = '" + TeacherId + "') ";
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

        private void Form2_Load(object sender, EventArgs e)
        {
            ogrenciListele();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String gender = "";
                if (radioButtonMale.Checked == true)  //
                    gender = "Male";                  //Cinsiyeti kontrol ediyor gender değişkenine atıyor.
                if (radioButtonFemale.Checked == true)//
                    gender = "Female";
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into ogrenciler(id,ad,soyad,classroom_id,iletisim,cinsiyet,adres) values('" + this.txtBoxId.Text + "','" + this.txtBoxFirstName.Text + "','" + this.txtBoxLastName.Text + "','" + "','" + this.txtBoxClass.Text + "','" + this.txtboxNumber.Text + "','" + gender + "','" + this.txtBoxAdres.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
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
                if (radioButtonMale.Checked == true)  //
                    gender = "Male";                  //Cinsiyeti kontrol ediyor gender değişkenine atıyor.
                if (radioButtonFemale.Checked == true)//
                    gender = "Female";
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update ogrenciler set id='" + this.txtBoxId.Text + "',ad='" + this.txtBoxFirstName.Text + "',soyad='" + this.txtBoxLastName.Text + "',iletisim='" + this.txtboxNumber.Text + "',cinsiyet='" + gender + "',adres='" + this.txtBoxAdres.Text + "' where id='" + this.txtBoxId.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
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
                MyConn2.Close();//Connection closed here
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
            Student.Course course = new Student.Course();
            course.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student.Exam exam = new Student.Exam();
            exam.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student.ExamResult examre = new Student.ExamResult();
            examre.Show();
            this.Hide();
        }
    }
}
