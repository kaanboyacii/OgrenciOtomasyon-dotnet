using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyon.StudentPanel
{
    public partial class courseResult : Form
    {
        public courseResult()
        {
            InitializeComponent();
        }
        public courseResult(string StuNum)
        {
            InitializeComponent();
            this.StudentNum = StuNum;
        }
        public string StudentNum { get; set; }


        private void courseResult_Load(object sender, EventArgs e)
        {

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
    }
}
