using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjectNest.DAL
{
    public class loginDAL:RegDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public loginDAL()
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
        public DataTable logincheck(BAL.loginBAL obj)
        {
            string qry = "SELECT * FROM login WHERE username='" + obj.Loginname + "' AND pwd='" + obj.Loginpwd + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UserConfirm(BAL.loginBAL loginbal)
        {
            string qry = "update login set status = 'confirmed' where loginid='" + loginbal.LoginId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            int i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}