using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ADOdn
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cs;
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = ConfigurationManager.ConnectionStrings["akshay"].ConnectionString;
            using(conn = new SqlConnection(cs))
            {
            }
        }

        protected void getdatabtn_Click(object sender, EventArgs e)
        {

            SqlDataAdapter dataAdapt = new SqlDataAdapter("insert into Employee values(@id, @name, @salary)", conn);
            DataSet ds = new DataSet();
            gvEmp.DataSource = dataAdapt.Fill(ds);
        }
    }
}