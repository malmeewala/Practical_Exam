using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace test05
{
    public partial class Student_Details : Form
    {
        public Student_Details()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                New_Student formDig1 = new New_Student();
                formDig1.ShowDialog();
                if (Publicdata.PStudName != "")
                {
                    dataGridView1.AllowUserToAddRows = true;
                    string stat = "";
                    if (Publicdata.PStudStat == true)
                    {
                        stat = "Active";
                    }
                    else
                    {
                        stat = "InActive";
                    }
                    dt.Rows.Add(0, Publicdata.PStudName, Publicdata.PStudBirth, Publicdata.PStudGPA, stat);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool chkSave = true;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value) == 0)
                {
                    Business_Logic_Layer.BLL obj = new Business_Logic_Layer.BLL();
                    try
                    {
                        chkSave = obj.save_client(dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToDateTime(dataGridView1.Rows[i].Cells[2].Value),
                            Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value), (dataGridView1.Rows[i].Cells[4].Value == "Active" ? true : false));
                    }
                    catch (SqlException ex)
                    {
                        chkSave = false;
                        MessageBox.Show("Error" + ex.Message.ToString());
                    }
                }
            }
            if (chkSave = true)
            {
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Data not Saved");
            }
        }

        private void Student_Details_Load(object sender, EventArgs e)
        {
            FillData(sender, e);
        }

        DataTable dt = new DataTable();
        public void FillData(object sender, EventArgs e)
        {
            Business_Logic_Layer.BLL bo = new Business_Logic_Layer.BLL();

            dt = bo.getTable();
            dataGridView1.DataSource = dt;
            return;

        }
    }
}
