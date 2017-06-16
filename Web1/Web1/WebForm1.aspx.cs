using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Web1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["akshay"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs)) {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee", con);
                DataSet ds = new DataSet();
            }
        }
    }
}