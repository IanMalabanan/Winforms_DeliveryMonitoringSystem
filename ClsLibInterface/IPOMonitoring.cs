using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibInterface
{
    public interface IPOMonitoring
    {
        string PONo { get; set; }

        string POItemCode { get; set; }

        string PartID { get; set; }

        string POType { get; set; }

        string POStatus { get; set; }

        string RevNo { get; set; }
        
        Nullable<DateTime> OrderDate { get; set; }
        
        Nullable<DateTime> DateRequired { get; set; }
        
        Nullable<Int32> POQty { get; set; }
        
        Int32 TotalQtyDelivered { get; set; }
        
        Int32 BalanceQty { get; set; }


        Nullable<Int32> ScheduleDeliveryQty { get; set; }

        Nullable<Int32> DeliveredQty { get; set; }

        string DRNo { get; set; }

        string SINo { get; set; }

        Nullable<DateTime> DeliveryDate { get; set; }

        string NameOfMonth { get; set; }

        string NameOfDay { get; set; }

    }
}
