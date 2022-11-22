using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.User
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL.RegBAL objregBal = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objregBal.RegName = uname.Text;
            objregBal.RegEmail = uemail.Text;
            objregBal.RegPhn = uphone.Text;
            objregBal.RegPwd= pwd.Text; 
            int i = objregBal.InsertUser();
            int j = objregBal.InsertLogin();
           
            if (i==1)
            {
                Response.Write("Success");
            }
        }
    }
}