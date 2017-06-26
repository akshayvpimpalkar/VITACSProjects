using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication2_getdata
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Employee e1 = new Employee();
                e1.Id = Convert.ToInt32(id.Text);
                e1.Name = name.Text;
                e1.Salary = Convert.ToDecimal(salary.Text);

                BussinessLayer b = new BussinessLayer();
                int x = b.InsertData(e1);
                Response.Write("Number of Rows Affected : " + x);
            }
            else
            {
                Response.Write("Fields required!");
            }
             
        }
//        CREATE PROCEDURE[dbo].[store]
//        @Eid int,
//	@Name nvarchar(MAX),
//	@Salary decimal (18,0)
//AS
//BEGIN

//    Insert into Employee(Id, Name, Salary)

//    Values(@Eid, @Name, @Salary)
//END

    }
}