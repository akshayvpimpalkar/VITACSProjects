using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace WebApplication2_getdata
{
    public class BussinessLayer
    {

        //public DataSet disaplayData()
        //{
        //    DataSet dataset= new DataSet();
        //    // string constr = ConfigurationManager.ConnectionStrings["demo"].ConnectionString;
        //     //using (SqlConnection con = new SqlConnection(constr))
        //    using (SqlConnection con = getConnection()) 
        //    {
        //         SqlDataAdapter datadapter = new SqlDataAdapter("getdata", con);
        //         datadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        //         datadapter.Fill(dataset);
        //     }
        //    return dataset;
        //}
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            string str = ConfigurationManager.ConnectionStrings["akshay"].ConnectionString;
            con.ConnectionString = str;
            return con;
        }
        public int InsertData(Employee e)
        {
            int rosafct=0;
            SqlConnection sqlconn=null;
            SqlCommand cmd;
            try
            {
                sqlconn = getConnection();
                sqlconn.Open();
                cmd = new SqlCommand("store",sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Eid", SqlDbType.Int).Value = e.Id;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = e.Name;
                cmd.Parameters.AddWithValue("@Salary", SqlDbType.Decimal).Value = e.Salary;

                rosafct = cmd.ExecuteNonQuery();

            }
            catch (SqlException se)
            { Console.WriteLine(se); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }
            return rosafct;
        }
    }
}