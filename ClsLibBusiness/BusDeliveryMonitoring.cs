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
    public class BusDeliveryMonitoring : IDeliveryMonitoring
    {
        private string _PONo;

        private string _POItemCode;

        private Nullable<Int32> _ScheduleDeliveryQty;

        private Nullable<Int32> _DeliveredQty;

        private string _DRNo;

        private string _SINo;

        private Nullable<DateTime> _DeliveryDate;

        private string _NameOfMonth;

        private string _NameOfDay;

        private string _PartID;

        private Nullable<Int32> _ActDelivery_Qty;

        private Nullable<Int32> _TotalQtyDelivered;



        public string PartID { get { return _PartID; } set { _PartID = value; } }

        public string PONo { get { return _PONo; } set { _PONo = value; } }

        public string POItemCode { get { return _POItemCode; } set { _POItemCode = value; } }

        public Nullable<Int32> ScheduleDeliveryQty { get { return _ScheduleDeliveryQty; } set { _ScheduleDeliveryQty = value; } }

        public Nullable<Int32> DeliveredQty { get { return _DeliveredQty; } set { _DeliveredQty = value; } }

        public string DRNo { get { return _DRNo; } set { _DRNo = value; } }

        public string SINo { get { return _SINo; } set { _SINo = value; } }

        public Nullable<DateTime> DeliveryDate { get { return _DeliveryDate; } set { _DeliveryDate = value; } }

        public string NameOfMonth { get { return _NameOfMonth; } set { _NameOfMonth = value; } }

        public string NameOfDay { get { return _NameOfDay; } set { _NameOfDay = value; } }

        public Nullable<Int32> ActDelivery_Qty { get { return _ActDelivery_Qty; } set { _ActDelivery_Qty = value; } }

        public Nullable<Int32> TotalQtyDelivered { get { return _TotalQtyDelivered; } set { _TotalQtyDelivered = value; } }



        public Boolean UpdateDeliveryStatus()
        {
            return DBDeliveryMonitoring.UpdateDeliveryStatus(this);
        }

        public Boolean CopyDeliveryMonitoringData()
        {
            return DBDeliveryMonitoring.CopyDeliveryMonitoringData(this);
        }

        public Boolean UpdateSIDR()
        {
            return DBDeliveryMonitoring.UpdateSIDR(this);
        }




        public DataTable GetDeliveryMonitoringByPONoDT(string partid, string pono)
        {
            return DBDeliveryMonitoring.GetDeliveryMonitoringByPONo(partid, pono).Tables[0];
        }

        public DataTable GetDeliveryMonitoringByDeliveryDateDT(string partid, DateTime ddate)
        {
            return DBDeliveryMonitoring.GetDeliveryMonitoringByDeliveryDate(partid, ddate).Tables[0];
        }

        public DataTable GetDeliveryMonitoringByYearDT(string partid ,int year)
        {
            return DBDeliveryMonitoring.GetDeliveryMonitoringByYear(partid ,year).Tables[0];
        }

        public DataTable GetDeliveryMonitoringThisYearDT(string partid)
        {
            return DBDeliveryMonitoring.GetDeliveryMonitoringThisYear(partid).Tables[0];
        }
        
        public DataTable GetDeliveryMonitoringByMonthandYearDT(string partid, int month, int year)
        {
            return DBDeliveryMonitoring.GetDeliveryMonitoringByMonthandYear(partid,month,year).Tables[0];
        }
    }
}
