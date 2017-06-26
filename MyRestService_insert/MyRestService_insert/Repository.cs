using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace MyRestService_insert
{
    public class Repository : IRepository
    {
        public List<Log> Display()
        {
            SqlConnection sqlconn = getConnection();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand("Select * from Log", sqlconn);
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            List<Log> lst = new List<Log>();
            while (sdr.Read())
            {
                Log l = new Log();
                l.UserId = Convert.ToInt32(sdr["UserId"]);
                l.Password = (sdr["Password"]).ToString();
                lst.Add(l);
            }
            return lst;
        }

        public SqlConnection getConnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            sqlconn.ConnectionString = cs;
            return sqlconn;
        }

        

        public bool InsertMyLog(int UserId, string Password)
        {
            SqlConnection sqlconn = getConnection();
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand("insert into Log(UserId, Password) values ('" + UserId + "', '" + Password + "')");
            int a = sqlcmd.ExecuteNonQuery();

            if (a != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}