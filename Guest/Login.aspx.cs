using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.LgBAL objLgbl = new BAL.LgBAL();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objLgbl.UserName = Txtuser.Text;
            objLgbl.Password = Txtpwd.Text;
            DataTable dt = objLgbl.LoginCheck();
            
            if (dt.Rows.Count > 0)
            {
                Session["uname"] = dt.Rows[0]["UserName"].ToString();
                Session["logId"] = dt.Rows[0]["Id"].ToString();

                if (dt.Rows[0][3].ToString() == "Admin")
                {
                    Response.Redirect("/Admin/Default.aspx");

                }
              
                else if (dt.Rows[0][3].ToString() == "User" )
                {
                    Response.Redirect("/User/Default.aspx");

                }
                else
                {
                    Response.Write("<script>Incorrect User name or Password");
                }

            }
        }
    }
}