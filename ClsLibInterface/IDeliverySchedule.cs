using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibInterface
{
    public interface IDeliverySchedule
    {
        string PartID { get; set; }

        int CusID { get; set; }
        
        Nullable<DateTime> DeliveryDate { get; set; }
        
        Nullable<Int32> DeliverySched_Qty { get; set; }

        Nullable<Int32> DeliverySched_Acc { get; set; }

        Nullable<Int32> ActDelivery_Qty { get; set; }

        Nullable<Int32> ActDelivery_Acc { get; set; }

        Nullable<Int32> DeliveryBal { get; set; }
        
        string NameOfMonth { get; set; }
        
        string NameOfDay { get; set; }

        Nullable<Int32> DateMonth { get; set; }

        Nullable<Int32> DateYear { get; set; }
    }
}
