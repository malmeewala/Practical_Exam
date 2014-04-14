using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Data_Access_Layer
{
    public class DAL
    {

        string strcon = @"user id  = sa ; password = 123;server =THARANGA-4E0B96\SQLEXPRESS;database =Interview";
        //string strcon = @"user id  = sa ; password = 123;server =EKRAIN;database =Attendace";        
        SqlCommand cmdinserted;
        SqlConnection con; 

        public DataTable getTable(string ssql)
        {
            createTableAndProc();
           
                SqlConnection con = new SqlConnection(strcon);
                string myCommand = ssql;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(myCommand, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
           
        }

        public void save_data(string Name, DateTime DOB, decimal GradePointAvg, bool Active)
        {
            cmdinserted = new SqlCommand();
            cmdinserted.CommandText = "[dbo].[Insert_Student]";
            cmdinserted.CommandTimeout = 0;
            cmdinserted.CommandType = CommandType.StoredProcedure;
            con = new SqlConnection(strcon);
            cmdinserted.Connection = con;
            cmdinserted.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            cmdinserted.Parameters.Add("@DOB ", SqlDbType.DateTime).Value = DOB;
            cmdinserted.Parameters.Add("@GradePointAvg", SqlDbType.Decimal).Value = GradePointAvg;
            cmdinserted.Parameters.Add("@Active ", SqlDbType.Bit).Value = Active;

            try
            {
                con.Open();
                cmdinserted.ExecuteNonQuery(); 
                con.Close();
            }
            catch (SqlException) 
            {
                throw;
            }
        }

        public void createTableAndProc()
        { 
        using (SqlConnection connection = new SqlConnection(strcon))
            {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            SqlTransaction transaction;

        // Start a local transaction.
            transaction = connection.BeginTransaction("SampleTransaction");

        // Must assign both transaction object and connection 
        // to Command object for a pending local transaction
            command.Connection = connection;
            command.Transaction = transaction;

                try
                {
                command.CommandText =" If not exists (select name from sysobjects where name = 'Registration') " +
" CREATE TABLE [dbo].[Registration](	[StudentId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,	[Name] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,	[DOB] [datetime] NULL,	[GradePointAvg] [numeric](18, 2) NULL,	[Active] [bit] NULL) ON [PRIMARY] ";
                command.ExecuteNonQuery();

                command.CommandText ="IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'Insert_Student') "+
" exec('create procedure Insert_Student (@Name varchar(max) ,@DOB datetime ,@GradePointAvg numeric(18, 2) ,@Active bit )as insert into Registration values(@Name,@DOB,@GradePointAvg,@Active)') ";
                command.ExecuteNonQuery();

                          
                transaction.Commit();
                Console.WriteLine("Complete");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error=", ex.Message.ToString());
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    System.Windows.Forms.MessageBox.Show("Error=", ex2.Message.ToString());
                }
        }
    }
        }

    }
}
