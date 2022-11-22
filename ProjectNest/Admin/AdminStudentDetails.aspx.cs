using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.Admin
{
    public partial class AdminStudentDetails : System.Web.UI.Page
    {
        BAL.RegBAL reg = new BAL.RegBAL();
        BAL.loginBAL log = new BAL.loginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                GridView1.DataSource = reg.viewRegisteration();
                 GridView1.DataBind();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            log.LoginId = userId.ToString();
            int i = log.UserConfirmation();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Confirmed Successfully" + "');", true);

            }
            GridView1.DataSource = reg.viewRegisteration();
            GridView1.DataBind();
        }
    }
}