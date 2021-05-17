using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClsLibInterface;
using ClsLibConnection;
using System.Data;
using System.Data.SqlClient;


namespace ClsLibDataAccess
{
    public class DBPOMonitoring : ClsConfig
    {
        public static Boolean SavePOMonitoring(IPOMonitoring _pomonitoring)
        {
            SqlCommand cmd = new SqlCommand("SavePOMonitoring");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PONo", _pomonitoring.PONo);

            cmd.Parameters.AddWithValue("@POItemCode", _pomonitoring.POItemCode);

            cmd.Parameters.AddWithValue("@PartID", _pomonitoring.PartID);

            cmd.Parameters.AddWithValue("@RevNo", _pomonitoring.RevNo);

            cmd.Parameters.AddWithValue("@OrderDate", _pomonitoring.OrderDate);

            cmd.Parameters.AddWithValue("@DateRequired", _pomonitoring.DateRequired);

            cmd.Parameters.AddWithValue("@POQty", _pomonitoring.POQty);

            cmd.Parameters.AddWithValue("@TotalQtyDelivered", _pomonitoring.TotalQtyDelivered);

            cmd.Parameters.AddWithValue("@BalanceQty", _pomonitoring.BalanceQty);

            cmd.Parameters.AddWithValue("@DeliveryDate", _pomonitoring.DeliveryDate);

            cmd.Parameters.AddWithValue("@ScheduleDeliveryQty", _pomonitoring.ScheduleDeliveryQty);

            cmd.Parameters.AddWithValue("@DeliveredQty", _pomonitoring.DeliveredQty);

            cmd.Parameters.AddWithValue("@DRNo", _pomonitoring.DRNo);

            cmd.Parameters.AddWithValue("@SINo", _pomonitoring.SINo);

            cmd.Parameters.AddWithValue("@DeliverySched_Qty", _pomonitoring.ScheduleDeliveryQty);
                        
            
            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }




        public static DataSet GetPOMonitoringByMonthandYear(string partcode, int month ,int year)
        {
            SqlCommand cmd = new SqlCommand("GetPOMonitoringByMonthandYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partcode);

            cmd.Parameters.AddWithValue("@month", month);

            cmd.Parameters.AddWithValue("@year", year);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }


        public static DataSet GetPOMonitoringByYear(string partcode ,int year)
        {
            SqlCommand cmd = new SqlCommand("GetPOMonitoringByYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partcode);

            cmd.Parameters.AddWithValue("@year", year);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet GetPOMonitoringByPONo(string partcode, string pono)
        {
            SqlCommand cmd = new SqlCommand("GetPOMonitoringByPONo");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partcode);

            cmd.Parameters.AddWithValue("@PONo", pono);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet GetPOMonitoringByDateRequired(string partcode, DateTime daterequired)
        {
            SqlCommand cmd = new SqlCommand("GetPOMonitoringByDateRequired");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partcode);

            cmd.Parameters.AddWithValue("@DateRequired", daterequired);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet GetPOMonitoringThisYear(string partcode)
        {
            SqlCommand cmd = new SqlCommand("GetPOMonitoringThisYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partcode);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet GetCustomers()
        {
            SqlCommand cmd = new SqlCommand("GetAllCustomers");

            cmd.CommandType = CommandType.StoredProcedure;

            return SqlHelper.ExecuteDataSet(ClsConfig.SOMSConnectionString, cmd);
        }

        public static DataSet GetPartsByCustomer(int cust_id)
        {
            SqlCommand cmd = new SqlCommand("GetPartsByCustomer");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cust", cust_id);

            return SqlHelper.ExecuteDataSet(ClsConfig.SOMSConnectionString, cmd);
        }

        public static DataSet GetPartNameByPartID(int cust_id, string _partid)
        {
            SqlCommand cmd = new SqlCommand("GetPartNameByPartID");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cust_ID", cust_id);

            cmd.Parameters.AddWithValue("@Part_ID", _partid);

            return SqlHelper.ExecuteDataSet(ClsConfig.SOMSConnectionString, cmd);
        }


    }
}
