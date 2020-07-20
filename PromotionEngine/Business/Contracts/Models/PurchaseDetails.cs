using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Business.Contracts.Models
{
    public class PurchaseDetails:SKUDetails
    {
        public int SKU_Quantity { get; set; }
        public int Total { get; set; }
    }
}
