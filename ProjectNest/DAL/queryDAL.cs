using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNest.DAL
{
    public class queryDAL:RegDAL
    {
        public int QueryInsert(BAL.queryBAL querybal)
        {
            string qry = "INSERT INTO query values('" + querybal.QueryProductId + "','" + querybal.QueryUserId + "','" + querybal.Query + "',' ','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewQueryAdmin()
        {
            string qry = "SELECT l.username,p.*,q.* FROM query q INNER JOIN login l ON l.loginid= q.user_id INNER JOIN preg p ON p.pid = q.product_id";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        public DataTable ViewSpecificQueryDetails(BAL.queryBAL querybal)
        {
            string qry = "SELECT l.username,p.*,q.* FROM query q INNER JOIN login l ON l.loginid= q.user_id INNER JOIN preg p ON p.pid = q.product_id WHERE q.query_Id='" + querybal.QueryId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }

        public int GiveReplyDetails(BAL.queryBAL querybal)
        {
            string qry = "UPDATE  query SET reply = '" + querybal.QueryReply + "' where query_Id = '" + querybal.QueryId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable GetSpecificUserQueryDetails(BAL.queryBAL querybal)
        {
            string qry = "SELECT l.username,p.*,q.* FROM query q INNER JOIN login l ON l.loginid= q.user_id INNER JOIN preg p ON p.pid = q.product_id where q.user_id='" + querybal.QueryUserId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }


        /*public DataTable ViewQueryDetails(BAL.queryBAL querybal)
        {
            string qry = "SELECT p.*,q.* FROM query_table q INNER JOIN product_table p ON p.productid = q.productid AND userid = '" + complaintbal.UserId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }*/
    }
}
