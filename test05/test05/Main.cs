using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test05
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainManu_Reg_Click(object sender, EventArgs e)
        {
            Student_Details Student_Details = new Student_Details();
            Student_Details.ShowDialog();
        }

        private void MainManu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManuMain_Click(object sender, EventArgs e)
        {

        }
    }
}
