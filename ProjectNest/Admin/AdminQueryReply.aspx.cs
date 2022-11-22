using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.Admin
{
    public partial class AdminQueryReply : System.Web.UI.Page
    {
        BAL.queryBAL Query_BAL = new BAL.queryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int qid = Convert.ToInt32(Request.QueryString["qid"]);
                Session["query_Id"] = qid;
                Query_BAL.QueryId = qid;
                DataTable dt = Query_BAL.ViewSpecificQuery();
                if (dt != null)
                {
                    PRoductTextBox1.Text = dt.Rows[0]["pname"].ToString();
                    QuestionTextBox.Text = dt.Rows[0]["query"].ToString();

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Query_BAL.QueryReply = ReplyTextBox.Text;
            int queryid = Convert.ToInt32(Session["query_Id"]);
            Query_BAL.QueryId = queryid;
            int i = Query_BAL.GiveReply();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Replyed Successfully" + "');", true);
                Response.Redirect("../Admin/AdminQuery.aspx");

            }
        }
    }
   
}