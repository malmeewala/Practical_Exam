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
    public partial class New_Student : Form
    {
        public New_Student()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool Active = (chkStudStat.CheckState == 0 ? false : true);
            Business_Logic_Layer.BLL obj = new Business_Logic_Layer.BLL();
            bool bolpass = obj.check_rules(txtStudName.Text, dtpStudBirth.Value.Date, Convert.ToDecimal(txtStudGPA.Text), Active);
            if (bolpass = false)
            {
                MessageBox.Show("Error, Data not Saved");
                
            }
            else
            {
                Publicdata.PStudName = "";
                Publicdata.PStudBirth = DateTime.Now;
                Publicdata.PStudGPA = "";
                Publicdata.PStudStat = true;


                Publicdata.PStudName = txtStudName.Text;
                Publicdata.PStudBirth = dtpStudBirth.Value.Date;
                Publicdata.PStudGPA = txtStudGPA.Text;
                Publicdata.PStudStat = Active;
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Publicdata.PStudName = "";
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
