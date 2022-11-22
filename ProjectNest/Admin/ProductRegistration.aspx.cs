using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNest.Admin
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        BAL.prodBAL objprodBal = new BAL.prodBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objprodBal.ProductView();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objprodBal.Pname = name.Text;
            objprodBal.Pprice = desc.Text;
            int i = objprodBal.InsertProd();
            

            GridView1.DataSource = objprodBal.ProductView();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objprodBal.ProductView();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox productName = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox productPrice = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];

            //string newProductPrice = productPrice.Text;

            objprodBal.PId = productId;
            objprodBal.Pname = productName.Text;
            objprodBal.Pprice = productPrice.Text;

            int i = objprodBal.UpdateProducts();


            GridView1.EditIndex = -1;
            GridView1.DataSource = objprodBal.ProductView();
            GridView1.DataBind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objprodBal.ProductView();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objprodBal.PId = productId;
            int i = objprodBal.DeleteProducts();
            GridView1.DataSource = objprodBal.ProductView();
            GridView1.DataBind();
        }

        
    }
}