using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Drawing;
using System.ComponentModel;



namespace Business_Logic_Layer
{
    public class BLL
    {
       
        public Boolean check_rules(string Name, DateTime DOB, decimal GradePointAvg, bool Active)
        { 
            Boolean bolres = true;
            if (Name == "") 
            {
                bolres = false;  
            }
            if (DOB.Date >= DateTime.Now.Date)
            {
                bolres = false;
            }

            if (GradePointAvg == 0)
            {
                bolres = false;
            }
            return bolres;
        }


        public DataTable getTable()
        {
            DataTable dt = new DataTable();
            Data_Access_Layer.DAL obj = new Data_Access_Layer.DAL();
            dt = obj.getTable("SELECT [StudentId] as 'Student ID',[Name],[DOB] as 'Date od Birth',[GradePointAvg] as 'GPA',case [Active] when 'true' then 'Active' else 'InActive' end  as 'Status' FROM [dbo].[Registration] ");
                        
            if (dt == null || dt.HasErrors == true)
            {
                System.Windows.Forms.MessageBox.Show("Datable has Errors or is Null");               
            }

            return dt;
           
        }



        public bool save_client(string Name, DateTime DOB, decimal GradePointAvg, bool Active)
        {
            Data_Access_Layer.DAL obj = new Data_Access_Layer.DAL();
            try
            {
                obj.save_data(Name, DOB, GradePointAvg, Active);                
            }
            catch (SqlException)
            {
                throw;
            }

            return true;
        }

    }
}
