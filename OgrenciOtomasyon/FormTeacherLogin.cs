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
        public void ogretmenIdGetir()
        {
            string user = txtBoxUserName.Text;
            string pass = txtBoxPassword.Text;
            string MyConnection3 = "server=localhost;user id=root;database=obs";
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
            string Query = "SELECT * FROM ogretmenler where username='" + txtBoxUserName.Text + "' AND password='" + txtBoxPassword.Text + "'";
            MySqlCommand cmd = new MySqlCommand(Query, MyConn3);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MyConn3.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                lblTeacherId.Text = dr["id"].ToString();
            }
            MyConn3.Close();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtBoxUserName.Text;
            string pass = txtBoxPassword.Text;
            string MyConnection3 = "server=localhost;user id=root;database=obs";
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
            string Query = "SELECT * FROM ogretmenler where username='" + txtBoxUserName.Text + "' AND password='" + txtBoxPassword.Text + "'";
            MySqlCommand cmd = new MySqlCommand(Query, MyConn3);
            MySqlDataAdapter da = new MySqlDataAdapter();
            MyConn3.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                lblTeacherId.Text = dr["id"].ToString();
            }
            MyConn3.Close();
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ogretmenler where username='" + txtBoxUserName.Text + "' AND password='" + txtBoxPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Teaher Login Succesful.");
                Form2 frm2 = new Form2(lblTeacherId.Text);
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
            ogretmenIdGetir();
            this.ActiveControl = txtBoxUserName;
            txtBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
