using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClsLibInterface;
using ClsLibConnection;

namespace ClsLibDataAccess
{
    public class DBDeliverySchedule : ClsConfig
    {
        public static Boolean CreateDeliverySchedule(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("CreateSchedule");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);
            
            return true;
        }

        public static Boolean UpdateDeliveryData(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("UpdateDeliveryData");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            cmd.Parameters.AddWithValue("@date", _schedule.DeliveryDate);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }


        public static Boolean RefreshedDeliverySchedule(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("RefreshedDeliverySchedule");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            cmd.Parameters.AddWithValue("@month", _schedule.DateMonth);

            cmd.Parameters.AddWithValue("@year", _schedule.DateYear);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }


        public static Boolean RefreshedDeliveryScheduleThisYear(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("RefreshedDeliveryScheduleThisYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            //cmd.Parameters.AddWithValue("@month", _schedule.DateMonth);

            //cmd.Parameters.AddWithValue("@year", _schedule.DateYear);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }


        public static Boolean RefreshedDeliveryScheduleByYear(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("RefreshedDeliveryScheduleByYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            //cmd.Parameters.AddWithValue("@month", _schedule.DateMonth);

            cmd.Parameters.AddWithValue("@year", _schedule.DateYear);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }


        public static Boolean SOMS_UpdateDeliverySchedule(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("SOMS_UpdateDeliverySchedule");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            cmd.Parameters.AddWithValue("@DeliveryDate", _schedule.DeliveryDate);

            cmd.Parameters.AddWithValue("@ActDelivery_Qty", _schedule.ActDelivery_Qty);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }

        public static Boolean SOMS_UpdateQtyRequired(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("SOMS_UpdateQtyRequired");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            cmd.Parameters.AddWithValue("@DeliveryDate", _schedule.DeliveryDate);

            cmd.Parameters.AddWithValue("@DeliverySched_Qty", _schedule.DeliverySched_Qty);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }

        public static Boolean SOMS_CreateSchedule(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("SOMS_CreateSchedule");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            cmd.Parameters.AddWithValue("@Cus_ID", _schedule.CusID);

            cmd.Parameters.AddWithValue("@YearStart", _schedule.DateYear);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }

        public static Boolean SOMS_RefreshedDeliverySchedule(IDeliverySchedule _schedule)
        {
            SqlCommand cmd = new SqlCommand("SOMS_RefreshedDeliverySchedule");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", _schedule.PartID);

            SqlHelper.ExecuteNonQuery(ClsConfig.SqlConnectionString, cmd);

            return true;
        }
        










        public static DataSet SOMS_DeliveryMonitoring_GetMinimumYear(string partid)
        {
            SqlCommand cmd = new SqlCommand("SOMS_DeliveryMonitoring_GetMinimumYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            return SqlHelper.ExecuteDataSet(ClsConfig.SOMSConnectionString, cmd);
        }

        public static DataSet SOMS_DeliveryMonitoring_GetQtyRequired(string partid)
        {
            SqlCommand cmd = new SqlCommand("SOMS_DeliveryMonitoring_GetQtyRequired");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            return SqlHelper.ExecuteDataSet(ClsConfig.SOMSConnectionString, cmd);
        }

        public static DataSet SOMS_DeliveryMonitoring_GetTotalDelivered(string partid)
        {
            SqlCommand cmd = new SqlCommand("SOMS_DeliveryMonitoring_GetTotalDelivered");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            return SqlHelper.ExecuteDataSet(ClsConfig.SOMSConnectionString, cmd);
        }

        public static DataSet GenerateMonth()
        {
            SqlCommand cmd = new SqlCommand("GenerateMonth");

            cmd.CommandType = CommandType.StoredProcedure;
            
            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet GetDeliveryScheduleByMonthandYear(string partid ,int month ,int year)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryScheduleByMonthandYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            cmd.Parameters.AddWithValue("@month", month);

            cmd.Parameters.AddWithValue("@year", year);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet GetDeliveryScheduleByYear(string partid ,int year)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryScheduleByYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            cmd.Parameters.AddWithValue("@year", year);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet GetDeliveryScheduleByThisYear(string partid)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryScheduleByThisYear");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }

        public static DataSet GetDeliveryScheduleInterval(string partid, DateTime _date)
        {
            SqlCommand cmd = new SqlCommand("GetDeliveryScheduleInterval");

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PartID", partid);

            cmd.Parameters.AddWithValue("@date", _date);

            return SqlHelper.ExecuteDataSet(ClsConfig.SqlConnectionString, cmd);
        }
    }
}
