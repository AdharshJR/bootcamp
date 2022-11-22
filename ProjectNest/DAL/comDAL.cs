using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ProjectNest.DAL
{
    public class comDAL:RegDAL
    {
       
        public int InsertComplaint(BAL.comBAL combal)
        {
            string qry = "insert into com values('" + combal.ProductId + "','" + combal.UserId + "','" + combal.Complaint + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','unseen')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable ComplaintView(BAL.comBAL combal)
        {
            string qry = "SELECT p.*,c.* FROM com c INNER JOIN preg p on p.pid = c.product_id AND user_id = '" + combal.UserId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable AdminViewComplaints(BAL.comBAL combal)
        {
            string qry = "SELECT l.username,p.*,c.* FROM com c INNER JOIN login l ON l.loginid= c.user_id INNER JOIN preg p ON p.pid = c.product_id";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }
        //view complaint in date range
        public DataTable ViewDateComplaint(BAL.comBAL combal)
        {
            string qry = "SELECT l.username,p.*,c.* FROM com c INNER JOIN login l ON l.loginid= c.user_id INNER JOIN preg p ON p.pid = c.product_id WHERE c.date BETWEEN '" + combal.FromDate + "'  AND '" + combal.ToDate + "' ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
        }
        public int ComplaintUpdate(BAL.comBAL combal)
        {
            string qry = "update com set status = '" + combal.ComplaintStatus + "' where complaint_id = '" + combal.ComplaintId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

    }
}