using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.Admin
{
    public partial class Querry : System.Web.UI.Page
    {
        BAL.LgBAL objLgbl = new BAL.LgBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GridView1.DataSource = objLgbl.ViewQuerryDetails();
                GridView1.DataBind();

            }
           


        }

       
    }
}