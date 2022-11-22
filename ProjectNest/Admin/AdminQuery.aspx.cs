using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.Admin
{
    public partial class AdminQuery : System.Web.UI.Page
    {
        BAL.queryBAL querybal = new BAL.queryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = querybal.ViewAdminQuery();
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("../Admin/AdminQueryReply.aspx");
        }
    }
}