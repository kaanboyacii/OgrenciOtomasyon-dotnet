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
    public partial class examCalender : Form
    {
        public examCalender(string StuNum)
        {
            InitializeComponent();
            this.StudentNum = StuNum;
        }
        public string StudentNum { get; set; }

        private void examCalender_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "server=localhost;user id=root;database=obs";
                string Query = "SELECT name,start_Date FROM exam WHERE classroom_id = (select classroom_id from ogrenciler where id = '" + StudentNum + "') ";
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand1 = new MySqlCommand(Query, MyConn);

                MySqlDataAdapter da = new MySqlDataAdapter();
                MyConn.Open();
                da.SelectCommand = MyCommand1;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["name"].ToString());
                    listitem.SubItems.Add(dr["start_Date"].ToString());
                    listView3.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormStudentInfo studentınf = new FormStudentInfo(StudentNum);
            studentınf.Show();
            this.Hide();
        }
    }
}
