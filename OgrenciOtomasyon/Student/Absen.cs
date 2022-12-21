using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
