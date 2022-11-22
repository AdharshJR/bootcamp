using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.User
{
    public partial class QueryRegister : System.Web.UI.Page
    {
        BAL.prodBAL productsBAL = new BAL.prodBAL();
        BAL.queryBAL queryBal = new BAL.queryBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dr = productsBAL.GetProduct();
                DropDownList1.DataTextField = "pname";
                DropDownList1.DataValueField = "pid";
                DropDownList1.DataSource = dr;
                DropDownList1.DataBind();

                int userid = Convert.ToInt32(Session["user_id"]);
                queryBal.QueryUserId = userid;

                GridView1.DataSource = queryBal.GetSpecificUserQueryDetails();
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            queryBal.QueryProductId = Convert.ToInt32(DropDownList1.SelectedValue);
            queryBal.QueryUserId = Convert.ToInt32(Session["user_id"]);
            queryBal.Query = TextBox1.Text;

            int i = queryBal.InsertQuery();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Question Posted Successfully" + "');", true);
                TextBox1.Text = string.Empty;

            }

            int userid = Convert.ToInt32(Session["user_id"]);
            queryBal.QueryUserId = userid;

            GridView1.DataSource = queryBal.GetSpecificUserQueryDetails();
            GridView1.DataBind();
        }
    }
}