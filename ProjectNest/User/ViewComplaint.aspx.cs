using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.User
{
    public partial class ViewComplaint : System.Web.UI.Page
    {
        BAL.comBAL complaintbal = new BAL.comBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                complaintbal.UserId = Convert.ToInt32(Session["user_id"]);
                GridView1.DataSource = complaintbal.ViewComplaint();
                GridView1.DataBind();
            }
        }
    }
}