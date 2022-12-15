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
    public partial class PasswordChange : Form
    {
        public PasswordChange(string StuNum)
        {
            InitializeComponent();
            this.StudentNum = StuNum;
        }
        public string StudentNum { get; set; }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            lblStudentNumber.Text = StudentNum;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "server=localhost;user id=root;database=obs";
            string Query = "update ogrenciler set password='" + this.txtBoxChangePassword.Text + "' where id='" + lblStudentNumber.Text + "';";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Password Changed");
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();//Connection closed here
            txtBoxChangePassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudentInfo frmstudenınf = new FormStudentInfo();
            frmstudenınf.Show();
            this.Hide();
        }
    }
}
