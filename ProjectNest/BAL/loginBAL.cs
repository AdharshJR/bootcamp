using ProjectNest.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNest.BAL
{
    public class loginBAL
    {
        
        DAL.loginDAL objlogDAL = new DAL.loginDAL();
        private string loginid;
        private string loginname;
        private string loginpwd;
        private string loginrole;
        private string loginstatus;
        public string LoginId
        {
            get
            {
                return loginid;
            }
            set
            {
                loginid = value;
            }
        }
        public string Loginname
        {
            get
            {
                return loginname;
            }
            set
            {
                loginname = value;
            }
        }
        public string Loginpwd
        {
            get
            {
                return loginpwd;
            }
            set
            {
                loginpwd = value;
            }
        }
        public string LoginRole
        {
            get
            {
                return loginrole;
            }
            set
            {
                loginrole = value;
            }
        }
        public string LoginStatus
        {
            get
            {
                return loginstatus;
            }
            set
            {
                loginstatus = value;
            }
        }
        public DataTable checklogin()
        {
            return objlogDAL.logincheck(this);
        }
        public int UserConfirmation()
        {
            return objlogDAL.UserConfirm(this);
        }
    }
}