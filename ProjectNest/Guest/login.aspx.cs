using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.Admin
{
    public partial class login : System.Web.UI.Page
    {
        BAL.loginBAL objloginBal = new BAL.loginBAL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objloginBal.Loginname = name.Text;
            objloginBal.Loginpwd = pwd.Text;
            DataTable dt = objloginBal.checklogin();
            if (objloginBal.Loginname == "Admin" && objloginBal.Loginpwd == "Admin")
            {
                Response.Redirect("../Admin/AdminHome.aspx");
            }
            else if (dt.Rows.Count > 0)
            {
                
         
                if (dt.Rows[0][3].ToString()=="user" && dt.Rows[0][4].ToString()=="confirmed")
                {
                    Response.Redirect("../User/UserHome.aspx");
                }
                else if (dt.Rows[0][3].ToString() == "user" && dt.Rows[0][4].ToString() != "confirmed")
                {
                    Response.Write("User Not Approved");
                }
            }
            else
            {
                Response.Write("Invalid Username/Password");
            }

        }
    }
}