using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.User
{
    public partial class userviewreply : System.Web.UI.Page
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
                    TextBox1.Text = dt.Rows[0]["pname"].ToString();
                    TextBox2.Text = dt.Rows[0]["query"].ToString();
                    TextBox3.Text = dt.Rows[0]["reply"].ToString();

                }

            }
        }
    }
}