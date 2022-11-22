using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNest.BAL
{
    public class RegBAL
    {
        DAL.RegDAL objregDAL = new DAL.RegDAL();
        private string regid;
        private string regname;
        private string regemail;
        private string regphn;
        private string regpwd;
        
        public string RegId       
        {
            get
            {
                return regid;
            }
            set
            {
                regid = value;
            }
        }
        public string RegName
        {
            get
            {
                return regname;
            }
            set
            {
                regname = value;
            }
        }
        public string RegEmail
        {
            get
            {
                return regemail;
            }
            set
            {
                regemail = value;
            }
        }
        public string RegPhn
        {
            get
            {
                return regphn;
            }
            set
            {
                regphn = value;
            }
        }
        public string RegPwd
        {
            get
            {
                return regpwd;
            }
            set
            {
                regpwd = value;
            }
        }
       
        public int InsertUser()
        {
            return objregDAL.UserInsert(this);
        }
        public int InsertLogin()
        {
            return objregDAL.LoginInsert(this);
        }
        public DataTable viewRegisteration()
        {
            return objregDAL.registerationView();
        }
    }
}