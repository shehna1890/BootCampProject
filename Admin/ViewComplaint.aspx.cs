using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.Admin
{
    public partial class ViewComplaint : System.Web.UI.Page
    {
        BAL.LgBAL objLgbl = new BAL.LgBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.DataSource = objLgbl.viewcomplaintAll();
            GridView2.DataBind();
            GridView3.DataSource = objLgbl.viewcomplaintAll();
            GridView3.DataBind();
            GridView1.DataSource = objLgbl.viewcomplaint();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView3.DataKeys[e.RowIndex].Value.ToString());
            objLgbl.ComplaintId = id.ToString();
            int i = objLgbl.closecomplaint();
            GridView3.EditIndex = -1;
            GridView3.DataSource = objLgbl.viewcomplaint();
            GridView3.DataBind();
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            objLgbl.Todate = TextBox2.Text;
            objLgbl.Fromdate = TextBox1.Text;
            GridView3.DataSource = objLgbl.inprocesscomplaint();
            GridView3.DataBind();
            GridView3.DataSource = objLgbl.inprocesscomplaint();
            GridView3.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objLgbl.Todate = TextBox2.Text;
            objLgbl.Fromdate = TextBox1.Text;
            GridView1.DataSource = objLgbl.viewcomplaint();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objLgbl.ComplaintId = id.ToString();
            int i = objLgbl.approvecomplaint();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objLgbl.viewcomplaint();
            GridView1.DataBind();
        }
    }
}