using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNest.BAL
{
    public class comBAL
    {
        DAL.comDAL comdal = new DAL.comDAL();
        private int _complaintId;
        private int _productId;
        private int _userId;
        private string _complaint;
        private string _complaintDate;
        private string _complaintStatus;
        private string _fromDate;
        private string _toDate;

        public int ComplaintId
        {
            get
            { 
                return _complaintId; 
            }
            set 
            { 
                _complaintId = value; 
            }
        }
        public int ProductId
        {
            set 
            {
                _productId = value;
            }
            get
            { 
                return _productId;
            }
        }
        public int UserId
        {
            get
            {
                return _userId; 
            }
            set
            {
                _userId = value;
            }
        }

        public string Complaint
        {
            get 
            { 
                return _complaint; 
            }
            set 
            {
                _complaint = value; 
            }
        }

        public string ComplaintDate
        {
            get
            { 
                return _complaintDate;
            }
            set
            {
                _complaintDate = value;
            }
        }
        public string ComplaintStatus
        {
            get 
            {
                return _complaintStatus; 
            }
            set
            {
                _complaintStatus = value;
            }
        }
        public string FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        public string ToDate
        {
            get { return _toDate; }
            set { _toDate = value; }
        }

        //insert into complaint
        public int InsertingComplaints()
        {
            return comdal.InsertComplaint(this);
        }
        //Get complaints of specific user
        public DataTable ViewComplaint()
        {
            return comdal.ComplaintView(this);
        }
        //Get all complaints in admin

        public DataTable ViewAdminComplaints()
        {
            return comdal.AdminViewComplaints(this);
        }
        //Get complaint of date
        public DataTable ViewDateComplaints()
        {
            return comdal.ViewDateComplaint(this);
        }
        //Update complaint
        public int UpdateComplaint()
        {
            return comdal.ComplaintUpdate(this);
        }
    }
}