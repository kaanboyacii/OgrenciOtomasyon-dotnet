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
    public partial class classResult : Form
    {
        public classResult()
        {
            InitializeComponent();
        }
        public classResult(string StuNum)
        {
            InitializeComponent();
            this.StudentNum = StuNum;
        }
        public string StudentNum { get; set; }


        private void classResult_Load(object sender, EventArgs e)
        {

        }
    }
}
