using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClsLibInterface;
using ClsLibConnection;
using ClsLibDataAccess;


namespace ClsLibBusiness
{
    public class BusUsers :IUsers
    {
        private string _upass;

        private string _uname;

        private string _empid;


        public string empid { get { return _empid; } set { _empid = value; } }

        public string uname { get { return _uname; } set { _uname = value; } }

        public string upass { get { return _upass; } set { _upass = value; } }


        public DataTable UserLoginDT(string uname, string upass)
        {
            return DBUsers.UserLogin(uname,upass).Tables[0];
        }

        public DataTable SKPI_GetAllEmployeesByEmpIDDT(string empid)
        {
            return DBUsers.SKPI_GetAllEmployeesByEmpID(empid).Tables[0];
        }
    }
}
