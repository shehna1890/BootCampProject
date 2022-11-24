using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.Admin
{
    public partial class QuerryReply : System.Web.UI.Page
    {
        BAL.LgBAL objLgbl = new BAL.LgBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int qid = Convert.ToInt32(Request.QueryString["Querry_Id"]);
                Session["Querry_Id"] = qid;
                objLgbl.QuerryId = qid.ToString();
                DataTable dt = objLgbl.ViewSpecificQuerry();
                if(dt!=null)
                {
                    PrTextBox1.Text = dt.Rows[0]["productname"].ToString();
                    QrTextBox2.Text = dt.Rows[0]["Querry"].ToString();

                }
               

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objLgbl.Reply = RpTextBox3.Text;
            int Querry_Id = Convert.ToInt32(Session["Querry_Id"]);
            objLgbl.QuerryId  = Querry_Id.ToString() ;
            int i = objLgbl.GiveReply();
            if(i==1)
            {
                Response.Write("<script>alert('Replyed Successfully');</script>");
                ClientScript.RegisterStartupScript(this.GetType(),"alert" ,"alert('"+ "Replyed Successfully" + "');", true);
                Response.Redirect("/Admin/Querry.aspx");

            }

        }
    }
}