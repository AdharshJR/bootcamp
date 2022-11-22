using ProjectNest.BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectNest.DAL
{
    public class prodDAL:RegDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public prodDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int ProdInsert(BAL.prodBAL obj)
        {
            string s = "insert into preg values('" + obj.Pname + "','" + obj.Pprice + "')";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable ViewProduct()
        {
            string qry = "Select * from preg";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UpdateProductDetails(BAL.prodBAL obj)
        {
            string qry = "update preg set pname = '" + obj.Pname + "',pprice = '" + obj.Pprice + "' where pid = '" + obj.PId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public int DeleteProductDetail(BAL.prodBAL products_BAL)
        {
            string qry = "delete from preg where pid ='" + products_BAL.PId + "' ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable GetProductDetails(BAL.prodBAL products_BAL)
        {
            string qry = "select * from preg";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable ds = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(ds);
            return ds;
        }
    }
}