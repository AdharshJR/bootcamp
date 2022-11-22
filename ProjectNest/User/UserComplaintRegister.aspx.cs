using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.User
{
    public partial class UserRegister : System.Web.UI.Page
    {
        BAL.prodBAL prod = new BAL.prodBAL();
        BAL.comBAL com = new BAL.comBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dr = prod.GetProduct();
                DropDownList1.DataTextField = "pname";
                DropDownList1.DataValueField = "pid";
                DropDownList1.DataSource = dr;
                DropDownList1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            com.ProductId = Convert.ToInt32(DropDownList1.SelectedValue);
            com.UserId = Convert.ToInt32(Session["user_id"]);
            com.Complaint = TextBox1.Text;
            int i = com.InsertingComplaints();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Complaint Registered Successfully" + "');", true);

            }
        }
    }
}