using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchemaFirst1
{
    public partial class WebForm1SchemaFirst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleEntitiesContext sc = new SampleEntitiesContext();

            var x = from reg in sc.Products select reg;

            foreach(var r in x)
            {
                Response.Write(r.Id);
                Response.Write(r.name);
                Response.Write(r.price);
            }
        }
    }
}