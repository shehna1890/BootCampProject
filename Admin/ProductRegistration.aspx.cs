using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.Admin
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        BAL.LgBAL objLgbl = new BAL.LgBAL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objLgbl.ProductName = name.Text;
            objLgbl.ProductPrice = price.Text;
            int i = objLgbl.insertProductDetails();

            if (i == 1)
            {
                Response.Write("Successfully Registererd...");

            }
            else
            {
                Response.Write("Failed....");
            }


        }
    }
}