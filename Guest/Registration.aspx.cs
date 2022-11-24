using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.Guest
{
    public partial class Registration : System.Web.UI.Page
    {
        BAL.RegBAL objregbl = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            
            objregbl.Name = name.Text;
            objregbl.Email = email.Text;
            objregbl.PhoneNumber = PhoneNumber.Text;
            objregbl.UserName = user.Text;
            objregbl.Password = pwd.Text;
           
            int i = objregbl.insertUserRegister();

            if (i == 1)
            {
                Response.Write("Registration Successfull...");

            }
            else
            {
                Response.Write("Failed....");
            }
            name.Text = "";
            email.Text = "";
            PhoneNumber.Text = "";
            pwd.Text = "";
            user.Text = "";




        }
    }
}