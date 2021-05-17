using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClsLibConnection;
using ClsLibInterface;
using System.Data;
using System.Data.SqlClient;


namespace ClsLibDataAccess
{ 
    public class DBUsers : ClsConfig
    {
        public static DataSet UserLogin(string uname, string upass)
        {
            SqlCommand cmd = new SqlCommand("UserLogin");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@uname", uname);

            cmd.Parameters.AddWithValue("@upass",upass);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet SKPI_GetAllEmployeesByEmpID(string empid)
        {
            SqlCommand cmd = new SqlCommand("SKPI_GetAllEmployeesByEmpID");

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@empid", empid);

            return SqlHelper.ExecuteDataSet(ClsConfig.PISConnectionString, cmd);
        }
    }
}
