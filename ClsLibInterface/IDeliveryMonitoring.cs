using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibInterface
{
    public interface IDeliveryMonitoring
    {
        string PONo { get; set; }
        
        string POItemCode { get; set; }
        
        Nullable<Int32> ScheduleDeliveryQty { get; set; }

        Nullable<Int32> TotalQtyDelivered { get; set; }

        Nullable<Int32> ActDelivery_Qty { get; set; }
        
        Nullable<Int32> DeliveredQty { get; set; }
        
        string DRNo { get; set; }

        string PartID { get; set; }
        
        string SINo { get; set; }
        
        Nullable<DateTime> DeliveryDate { get; set; }
        
        string NameOfMonth { get; set; }
        
        string NameOfDay { get; set; }
    }
}
