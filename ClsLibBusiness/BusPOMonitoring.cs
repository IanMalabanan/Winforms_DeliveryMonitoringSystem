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
    public class BusPOMonitoring : IPOMonitoring
    {
        private string _PONo ;

        private string _POItemCode;

        private string _PartID;

        private string _POType;

        private string _POStatus;

        private string _RevNo;

        private Nullable<DateTime> _OrderDate;

        private Nullable<DateTime> _DateRequired;

        private Nullable<Int32> _POQty;

        private Int32 _TotalQtyDelivered;

        private Int32 _BalanceQty;




        private Nullable<Int32> _ScheduleDeliveryQty;

        private Nullable<Int32> _DeliveredQty;

        private string _DRNo;

        private string _SINo;

        private Nullable<DateTime> _DeliveryDate;

        private string _NameOfMonth;

        private string _NameOfDay;




        public Nullable<Int32> ScheduleDeliveryQty { get { return _ScheduleDeliveryQty; } set { _ScheduleDeliveryQty = value; } }

        public Nullable<Int32> DeliveredQty { get { return _DeliveredQty; } set { _DeliveredQty = value; } }

        public string DRNo { get { return _DRNo; } set { _DRNo = value; } }

        public string SINo { get { return _SINo; } set { _SINo = value; } }

        public Nullable<DateTime> DeliveryDate { get { return _DeliveryDate; } set { _DeliveryDate = value; } }

        public string NameOfMonth { get { return _NameOfMonth; } set { _NameOfMonth = value; } }

        public string NameOfDay { get { return _NameOfDay; } set { _NameOfDay = value; } }





        public string PONo { get { return _PONo; } set { _PONo = value; } }

        public string POItemCode { get { return _POItemCode; } set { _POItemCode = value; } }

        public string PartID { get { return _PartID; } set { _PartID = value; } }

        public string POType { get { return _POType; } set { _POType = value; } }

        public string POStatus { get { return _POStatus; } set { _POStatus = value; } }

        public string RevNo { get { return _RevNo; } set { _RevNo = value; } }

        public Nullable<DateTime> OrderDate { get { return _OrderDate; } set { _OrderDate = value; } }

        public Nullable<DateTime> DateRequired { get { return _DateRequired; } set { _DateRequired = value; } }

        public Nullable<Int32> POQty { get { return _POQty; } set { _POQty = value; } }

        public Int32 TotalQtyDelivered { get { return _TotalQtyDelivered; } set { _TotalQtyDelivered = value; } }

        public Int32 BalanceQty { get { return _BalanceQty; } set { _BalanceQty = value; } }




        public Boolean SavePOMonitoring()
        {
            return DBPOMonitoring.SavePOMonitoring(this);
        }



        public DataTable GetPOMonitoringByMonthandYearDT(string partcode ,int month , int year)
        {
            return DBPOMonitoring.GetPOMonitoringByMonthandYear(partcode ,month ,year).Tables[0];
        }

        public DataTable GetPOMonitoringByYearDT(string partcode ,int year)
        {
            return DBPOMonitoring.GetPOMonitoringByYear(partcode ,year).Tables[0];
        }
        
        public DataTable GetPOMonitoringByPONoDT(string partcode, string pono)
        {
            return DBPOMonitoring.GetPOMonitoringByPONo(partcode, pono).Tables[0];
        }

        public DataTable GetPOMonitoringByDateRequiredDT(string partcode, DateTime datereq)
        {
            return DBPOMonitoring.GetPOMonitoringByDateRequired(partcode, datereq).Tables[0];
        }
        
        public DataTable GetPOMonitoringThisYearDT(string partcode)
        {
            return DBPOMonitoring.GetPOMonitoringThisYear(partcode).Tables[0];
        }

        public DataTable GetAllCustomersDT()
        {
            return DBPOMonitoring.GetCustomers().Tables[0];
        }

        public DataTable GetPartsByCustomerDT(int _custid)
        {
            return DBPOMonitoring.GetPartsByCustomer(_custid).Tables[0];
        }

        public DataTable GetPartNameByPartIDDT(int _custid, string partid)
        {
            return DBPOMonitoring.GetPartNameByPartID(_custid, partid).Tables[0];
        }

    }
}
