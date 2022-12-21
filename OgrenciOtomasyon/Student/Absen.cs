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
    public partial class Absen : Form
    {
        public Absen()
        {
            InitializeComponent();
        }
        public Absen(string TeaId)
        {
            InitializeComponent();
            this.TeacherId = TeaId;
        }
        public string TeacherId { get; set; }

        private void Absen_Load(object sender, EventArgs e)
        {
            ogrenciListele();
        }
        private void ogrenciListele()
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=obs";
                string Query = "select id,absenteeism,ad,soyad,classroom_id from ogrenciler where classroom_id in (select classroom_id from classroom where teacher_id = '" + TeacherId + "') ";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxAbsen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxId.Clear();
            txtBoxAbsen.Clear();
        }
    }
}
