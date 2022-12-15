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
    public partial class Form1 : Form
    {
        public MySqlConnection con = new MySqlConnection("Server=localhost;Database=obs;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtBoxUserName.Text;
            string pass = txtBoxPassword.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ogrenciler where id='" + txtBoxUserName.Text + "' AND password='" + txtBoxPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Student Login Succesful.");
                FormStudentInfo frmStudentInfo = new FormStudentInfo(txtBoxUserName.Text);
                frmStudentInfo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
            }
            con.Close();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxUserName.Clear();
            txtBoxPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTeacherLogin frmTeacherLogin = new FormTeacherLogin();
            frmTeacherLogin.Show();
            this.Hide();

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {
            this.ActiveControl = txtBoxUserName;
        }
    }
}
