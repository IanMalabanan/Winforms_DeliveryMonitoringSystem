using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsLibDataAccess;
using ClsLibInterface;
using System.Data;

namespace ClsLibBusiness
{
    public class BusDeliverySchedule : IDeliverySchedule
    {
        private string _PartID;

        private int _CusID;

        private Nullable<DateTime> _DeliveryDate;

        private Nullable<Int32> _DeliverySched_Qty;

        private Nullable<Int32> _DeliverySched_Acc;

        private Nullable<Int32> _ActDelivery_Qty;

        private Nullable<Int32> _ActDelivery_Acc;

        private Nullable<Int32> _DeliveryBal;

        private string _NameOfMonth;

        private string _NameOfDay;


        private Nullable<Int32> _DateMonth;

        private Nullable<Int32> _DateYear;

        


        public string PartID { get { return _PartID; } set { _PartID = value; } }

        public int CusID { get { return _CusID; } set { _CusID = value; } }

        public Nullable<DateTime> DeliveryDate { get { return _DeliveryDate; } set { _DeliveryDate = value; } }

        public Nullable<Int32> DeliverySched_Qty { get { return _DeliverySched_Qty; } set { _DeliverySched_Qty = value; } }

        public Nullable<Int32> DeliverySched_Acc { get { return _DeliverySched_Acc; } set { _DeliverySched_Acc = value; } }

        public Nullable<Int32> ActDelivery_Qty { get { return _ActDelivery_Qty; } set { _ActDelivery_Qty = value; } }

        public Nullable<Int32> ActDelivery_Acc { get { return _ActDelivery_Acc; } set { _ActDelivery_Acc = value; } }

        public Nullable<Int32> DeliveryBal { get { return _DeliveryBal; } set { _DeliveryBal = value; } }

        public string NameOfMonth { get { return _NameOfMonth; } set { _NameOfMonth = value; } }

        public string NameOfDay { get { return _NameOfDay; } set { _NameOfDay = value; } }

        public Nullable<Int32> DateMonth { get { return _DateMonth; } set { _DateMonth = value; } }

        public Nullable<Int32> DateYear { get { return _DateYear; } set { _DateYear = value; } }




        public Boolean CreateDeliverySchedule()
        {
            return DBDeliverySchedule.CreateDeliverySchedule(this);
        }

        public Boolean UpdateDeliveryData()
        {
            return DBDeliverySchedule.UpdateDeliveryData(this);
        }

        public Boolean RefreshedDeliverySchedule()
        {
            return DBDeliverySchedule.RefreshedDeliverySchedule(this);
        }

        public Boolean RefreshedDeliveryScheduleThisYear()
        {
            return DBDeliverySchedule.RefreshedDeliveryScheduleThisYear(this);
        }

        public Boolean RefreshedDeliveryScheduleByYear()
        {
            return DBDeliverySchedule.RefreshedDeliveryScheduleByYear(this);
        }

        public Boolean SOMS_UpdateDeliverySchedule()
        {
            return DBDeliverySchedule.SOMS_UpdateDeliverySchedule(this);
        }

        public Boolean SOMS_UpdateQtyRequired()
        {
            return DBDeliverySchedule.SOMS_UpdateQtyRequired(this);
        }

        public Boolean SOMS_CreateSchedule()
        {
            return DBDeliverySchedule.SOMS_CreateSchedule(this);
        }

        public Boolean SOMS_RefreshedDeliverySchedule()
        {
            return DBDeliverySchedule.SOMS_RefreshedDeliverySchedule(this);
        }

        
        




        public DataTable SOMS_DeliveryMonitoring_GetMinimumYearDT(string partid)
        {
            return DBDeliverySchedule.SOMS_DeliveryMonitoring_GetMinimumYear(partid).Tables[0];
        }

        public DataTable SOMS_DeliveryMonitoring_GetQtyRequiredDT(string partid)
        {
            return DBDeliverySchedule.SOMS_DeliveryMonitoring_GetQtyRequired(partid).Tables[0];
        }

        public DataTable SOMS_DeliveryMonitoring_GetTotalDeliveredDT(string partid)
        {
            return DBDeliverySchedule.SOMS_DeliveryMonitoring_GetTotalDelivered(partid).Tables[0];
        }



        public DataTable GenerateMonthDT()
        {
            return DBDeliverySchedule.GenerateMonth().Tables[0];
        }

        public DataTable GetDeliveryScheduleByMonthandYearDT(string partid, int year, int month)
        {
            return DBDeliverySchedule.GetDeliveryScheduleByMonthandYear(partid,year,month).Tables[0];
        }
        
        public DataTable GetDeliveryScheduleByYearDT(string partid, int year)
        {
            return DBDeliverySchedule.GetDeliveryScheduleByYear(partid ,year).Tables[0];
        }

        public DataTable GetDeliveryScheduleByThisYearDT(string partid)
        {
            return DBDeliverySchedule.GetDeliveryScheduleByThisYear(partid).Tables[0];
        }

        public DataTable GetDeliveryScheduleIntervalDT(string partid, DateTime _date)
        {
            return DBDeliverySchedule.GetDeliveryScheduleInterval(partid, _date).Tables[0];
        }

    }
}
