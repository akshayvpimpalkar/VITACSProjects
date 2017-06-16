using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ADOsample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack) {
                string cs = ConfigurationManager.ConnectionStrings["akshay"].ConnectionString;
                using (SqlConnection sqlcon = new SqlConnection(cs))
                {
                    SqlDataAdapter sqldataadapt = new SqlDataAdapter("Select * from Employee", sqlcon);
                    ds = new DataSet();
                    sqldataadapt.Fill(ds);
                }
            }
            
            
        }

        protected void getdata_Click(object sender, EventArgs e)
        {
            gvEmp.DataSource = ds;
            gvEmp.DataBind();
        }
    }
}