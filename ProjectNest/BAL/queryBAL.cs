using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNest.BAL
{
    public class queryBAL
    {
        DAL.queryDAL querydal = new DAL.queryDAL();
        private int _queryId;
        private int _productId;
        private int _userId;
        private string _query;
        private string _queryReply;
        private string _queryDate;



        public int QueryId
        {
            get { return _queryId; }
            set { _queryId = value; }
        }
        public int QueryProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public int QueryUserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Query
        {
            get { return _query; }
            set
            {
                _query = value;
            }
        }

        public string QueryReply
        {
            get { return _queryReply; }
            set
            {
                _queryReply = value;
            }
        }

        public string QueryDate
        {
            get { return _queryDate; }
            set
            {
                _queryDate = value;
            }
        }

        public int InsertQuery()
        {
            return querydal.QueryInsert(this);
        }

        //view all queries

        public DataTable ViewAdminQuery()
        {
            return querydal.ViewQueryAdmin();
        }

        public DataTable ViewSpecificQuery()
        {
            return querydal.ViewSpecificQueryDetails(this);
        }

        public int GiveReply()
        {
            return querydal.GiveReplyDetails(this);
        }

        public DataTable GetSpecificUserQueryDetails()
        {
            DataTable result = querydal.GetSpecificUserQueryDetails(this);
            return result;
        }
    }
}
    
