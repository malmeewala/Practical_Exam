using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> dogs = new List<string>();
                dogs.Add("Aigi");
                dogs.Add("Spitz");
                dogs.Add("AMastiff");
                dogs.Add("Finnish Spitz");
                dogs.Add("Briard");

                Sort(dogs, 'A');
                listBox.DataSource = Sort(dogs, 'A');
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error-" + ex.ToString());
            }
        }

        public List<string> Sort(List<string> theList, char theChar)
        {
            List<string> dogsbau = new List<string>();
            List<string> dogs = theList; // Create new list of strings



            //Console.WriteLine(dogs);
            foreach (string item in dogs)
            {
                string d = item.Substring(0, 1);
                if (Convert.ToChar(d) == theChar)
                {
                    Console.WriteLine(item);
                    dogsbau.Add(item);
                }
                //Console.WriteLine(item);
            }
            return dogsbau;
        }
    }
}
