using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using System.Web;

namespace ComplaintRegistration.BAL
{
    public class LgBAL
    {
        DAL.RegDAL OBJregdl = new DAL.RegDAL();

        private string _UserName;
        private string _Password;
        private string _Name;
        private string _Product_Name;
        private string _Product_Price;
        private int _Product_Id;
        private string _Complaint;
        private int _User_Id;
        private string _Querry;
        private string _Reply;
        private string _Querry_Id;
        private string _Complaint_Id;
        private string _todate;
        private string _fromdate;


        public String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        public String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        public int Login()
        {
            return OBJregdl.LoginUser(this);
        }
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public String ProductName
        {
            get
            {
                return _Product_Name;
            }
            set
            {
                _Product_Name = value;
            }
        }
        public String ProductPrice
        {
            get
            {
                return _Product_Price;
            }
            set
            {
                _Product_Price = value;
            }
        }
        public string Todate
        {
            get
            {
                return _todate;
            }
            set
            {
                _todate = value;
            }
        }
        public string Fromdate
        {
            get
            {
                return _fromdate;
            }
            set
            {
                _fromdate = value;
            }
        }




        public int insertProductDetails()
        {
            return OBJregdl.ProductDetailsInsert(this);
        }



        public DataTable LoginCheck()
        {
            return OBJregdl.CheckLogin(this);

        }

        public DataTable ViewProductDetails()
        {
            return OBJregdl.ProductDetailsView(this);
        }
        public int ProductId
        {
            get
            {
                return _Product_Id;
            }
            set
            {
                _Product_Id = value;
            }
        }
        public String ComplaintBox
        {
            get
            {
                return _Complaint;
            }
            set
            {
                _Complaint = value;
            }
        }
        public int insertComplaint()
        {
            return OBJregdl.Complaintinsert(this);
        }

        public int UserId
        {
            get
            {
                return _User_Id;
            }
            set
            {
                _User_Id = value;
            }
        }
        public String ComplaintId 
        {
            get
            {
                return _Complaint_Id;
            }
            set
            {
                _Complaint_Id = value;
            }
        }
        public DataTable GetProduct()
        {
            return OBJregdl.GetProdetails(this);
        }
        public int insertQuerry()
        {
            return OBJregdl.Querryinsert(this);
        }
        public String QuerryBox
        {
            get
            {
                return _Querry;
            }
            set
            {
                _Querry = value;
            }
        }
        public DataTable ViewQuerryDetails()
        {
            return OBJregdl.QuerryDetailsView(this);
        }
        public DataTable StatusView()
        {
            return OBJregdl.UpdateQuerryTable(this);
        }

        public String Reply
        {
            get
            {
                return _Reply;
            }
            set
            {
                _Reply = value;
            }
        }
        public String QuerryId
        {
            get
            {
                return _Querry_Id;
            }
            set
            {
                _Querry_Id = value;
            }
        }
        public DataTable ViewSpecificQuerry()
        {
            return OBJregdl.ViewSpecificQueryDetails(this);

        }
        public int GiveReply()
        {
            return OBJregdl.GiveReplyDetails(this);
        }



        public DataTable viewcomplaintAll()
        {
            return OBJregdl.Allcomplaintview(this);
        }
        public DataTable viewcomplaint()
        {
            return OBJregdl.complaintview(this);
        }
        public int closecomplaint()
        {
            return OBJregdl.complaintclose(this);
        }
        public DataTable inprocesscomplaint()
        {
            return OBJregdl.complaintinprocess(this);
        }
        public int approvecomplaint()
        {
            return OBJregdl.complaintApprove(this);
        }









    }
}