using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ComplaintRegistration.BAL
{
    public class RegBAL
    {
        DAL.RegDAL OBJregdl = new DAL.RegDAL();
        private String _Name;
        private string _Email;
        private string _PhoneNumber;
        private string _Password;
        private string _UserName;
        private int _User_Id;


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
        public String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }
        public String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = value;
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
        public int insertUserRegister()
        {
            return OBJregdl.UserRegisterInsert(this);
        }
        public DataTable ViewTable()
        {
            return OBJregdl.ViewTable(this);


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
        
    }

}