using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNest.DAL
{
    public class RegDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public RegDAL()
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
        public int LoginInsert(BAL.RegBAL obj)
        {
            string s = "insert into login values('" + obj.RegName + "','" + obj.RegPwd + "','user','not confirmed');select @@IDENTITY";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public int UserInsert(BAL.RegBAL obj)
        {
            string qry = "insert into reguser values('" + obj.RegName + "','" + obj.RegEmail + "','" + obj.RegPhn + "','" + obj.RegPwd + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable registerationView()
        {
            string qry = "select r.*,l.* from reguser r inner join login l on r.id = l.loginid where l.role='user' and status='not confirmed'";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;

        }
    }
}