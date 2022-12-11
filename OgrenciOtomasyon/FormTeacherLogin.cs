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
    public partial class FormTeacherLogin : Form
    {
        public MySqlConnection con = new MySqlConnection("Server=localhost;Database=obs;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public FormTeacherLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtBoxUserName.Text;
            string pass = txtBoxPassword.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ogretmenler where username='" + txtBoxUserName.Text + "' AND password='" + txtBoxPassword.Text + "' AND lesson='" + txtBoxLesson.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Teaher Login Succesful.");
                Form2 frm2 = new Form2(txtBoxLesson.Text);
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
            }
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void FormTeacherLogin_Load(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
