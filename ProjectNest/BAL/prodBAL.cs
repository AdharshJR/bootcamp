using ProjectNest.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNest.BAL
{
   
    public class prodBAL
    {
        DAL.prodDAL objprodDAL = new DAL.prodDAL();
       
        
        private int pid;
        private string pname;
        private string pprice;

        public int PId
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
            }
        }
        public string Pname
        {
            get
            {
                return pname;
            }
            set
            {
                pname = value;
            }
        }
        public string Pprice
        {
            get
            {
                return pprice;
            }
            set
            {
                pprice = value;
            }
        }

       

        public int InsertProd()
        {
            return objprodDAL.ProdInsert(this);
        }
        public DataTable ProductView()
        {
            return objprodDAL.ViewProduct();
        }
        
        public int UpdateProducts()
        {
            return objprodDAL.UpdateProductDetails(this);
        }
        public int DeleteProducts()
        {
            return objprodDAL.DeleteProductDetail(this);
        }
        public DataTable GetProduct()
        {
            return objprodDAL.GetProductDetails(this);
        }
    }
}