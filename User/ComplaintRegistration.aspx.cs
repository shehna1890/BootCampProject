using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.User
{
    public partial class ComplaintRegistration : System.Web.UI.Page
    {
        BAL.LgBAL objLgbl = new BAL.LgBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(! IsPostBack)
            {
                DropDownList1.DataSource = objLgbl.GetProduct();
                DropDownList1.DataTextField = "Product_Name";
                DropDownList1.DataValueField = "Product_Id";
                DropDownList1.DataBind();



            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            objLgbl.ProductId =Convert.ToInt32(DropDownList1.SelectedValue);
            objLgbl.UserId = Convert.ToInt16(Session["logId"]);
            objLgbl.ComplaintBox = TextBox1.Text;
            int i = objLgbl.insertComplaint();
            if(i==1)
            {
                Response.Write("Complaint Recieved");
            }

        }
    }
}