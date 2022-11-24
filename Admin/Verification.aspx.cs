using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.Admin
{
    public partial class Verification : System.Web.UI.Page
    {
        BAL.RegBAL objregbl = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objregbl.ViewTable();
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string s = GridView1.DataKeys[e.RowIndex].Value.ToString();
           // objregbl.UserId = s;
            GridView1.DataSource = objregbl.ViewTable();
            GridView1.DataBind();

            
        }
    }
}