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
        public Form2(string ders)
        {
            InitializeComponent();
            this.lesson = ders;
        }

        public string lesson { get; set; }

        private void ogrenciListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //Display query
                string Query = "select * from ogrenciler where ders='" + lblLesson.Text + "';";
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
        private void ortalamaHesap()
        {
            string MyConnection2 = "server=localhost;user id=root;database=obs";
            int vize = Convert.ToInt32(txtBoxMidtermExam.Text);
            int final = Convert.ToInt32(txtBoxFinalExam.Text);
            float ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            string durum;
            if (ort < 35 || final < 35)
                durum = "Kaldı";
            else
                durum = "Geçti";
            string Query = "update ogrenciler set ortalama='" + ort + "',durum='" + durum + "' where numara='" + this.txtboxNumber.Text + "';";
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            MyConn2.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblLesson.Text = lesson;
            ogrenciListele();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into ogrenciler(ders,ad,soyad,numara,Uyruk,vize,final) values('" + this.lblLesson.Text + "','" + this.txtBoxFirstName.Text + "','" + this.txtBoxLastName.Text + "','" + this.txtboxNumber.Text + "','" + this.txtBoxUyruk.Text + "','" + this.txtBoxMidtermExam.Text + "','" + this.txtBoxFinalExam.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Added Student");
                ortalamaHesap();
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
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update ogrenciler set ad='" + this.txtBoxFirstName.Text + "',soyad='" + this.txtBoxLastName.Text + "',numara='" + this.txtboxNumber.Text + "',Uyruk='" + this.txtBoxUyruk.Text  + "',vize='" + this.txtBoxMidtermExam.Text + "',final='" + this.txtBoxFinalExam.Text + "' where numara='" + this.txtboxNumber.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Student Informations Updated");
                ortalamaHesap();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtboxNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBoxUyruk.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtBoxMidtermExam.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBoxFinalExam.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "delete from ogrenciler where numara='" + this.txtboxNumber.Text + "';";
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
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtboxNumber.Clear();
            txtBoxUyruk.Clear();
            txtBoxMidtermExam.Clear();
            txtBoxFinalExam.Clear();
            txtBoxFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
