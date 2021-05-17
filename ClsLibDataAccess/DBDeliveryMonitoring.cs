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
    public class DBDeliveryMonitoring : ClsConfig
    {
        public static Boolean UpdateDeliveryStatus(IDeliveryMonitoring _dm)
        {
            SqlCommand cmd = new SqlCommand("UpdateDeliveryStatus");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PONo", _dm.PONo);

            cmd.Parameters.AddWithValue("@PartID", _dm.PartID);

            cmd.Parameters.AddWithValue("@DeliveryDate", _dm.DeliveryDate);

            cmd.Parameters.AddWithValue("@DeliveredQty", _dm.DeliveredQty);

            cmd.Parameters.AddWithValue("@TotalQtyDelivered", _dm.TotalQtyDelivered);

            cmd.Parameters.AddWithValue("@ActDelivery_Qty", _dm.ActDelivery_Qty);


            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }

        public static Boolean CopyDeliveryMonitoringData(IDeliveryMonitoring _dm)
        {
            SqlCommand cmd = new SqlCommand("CopyDeliveryMonitoringData");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PONo", _dm.PONo);

            cmd.Parameters.AddWithValue("@PartID", _dm.PartID);

            cmd.Parameters.AddWithValue("@DeliveryDate", _dm.DeliveryDate);

            cmd.Parameters.AddWithValue("@DeliveredQty", _dm.DeliveredQty);

            
            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }

        public static Boolean UpdateSIDR(IDeliveryMonitoring _dm)
        {
            SqlCommand cmd = new SqlCommand("UpdateSIDR");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PONo", _dm.PONo);

            cmd.Parameters.AddWithValue("@PartID", _dm.PartID);

            cmd.Parameters.AddWithValue("@DRNo", _dm.DeliveryDate);

            cmd.Parameters.AddWithValue("@SINo", _dm.DeliveredQty);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }



        public static DataSet GetDeliveryMonitoringByMonthandYear(string partid, int _month, int _year)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryMonitoringByMonthandYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            cmd.Parameters.AddWithValue("@month", _month);

            cmd.Parameters.AddWithValue("@year", _year);

            return SqlHelper.ExecuteDataSet(SqlConnectionString, cmd);
        }

        public static DataSet GetDeliveryMonitoringByYear(string partid ,int year)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryMonitoringByYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            cmd.Parameters.AddWithValue("@year", year);

            return SqlHelper.ExecuteDataSet(SqlConnectionString, cmd);
        }

        public static DataSet GetDeliveryMonitoringByPONo(string partid, string pono)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryMonitoringByPONo");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            cmd.Parameters.AddWithValue("@PONo", pono);

            return SqlHelper.ExecuteDataSet(SqlConnectionString, cmd);
        }

        public static DataSet GetDeliveryMonitoringByDeliveryDate(string partid, DateTime ddate)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryMonitoringByPONo");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            cmd.Parameters.AddWithValue("@DeliveryDate", ddate);

            return SqlHelper.ExecuteDataSet(SqlConnectionString, cmd);
        }

        public static DataSet GetDeliveryMonitoringThisYear(string partid)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryMonitoringThisYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            return SqlHelper.ExecuteDataSet(SqlConnectionString, cmd);
        }
    }
}
