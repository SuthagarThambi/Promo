using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Business.Contracts.Models
{
    public class SKUDetails
    {
        public string SKU_Name { get; set; }
        public int SKU_PRICE { get; set; }
        public int SKU_PromoCnt { get; set; }
        public int SKU_PromoPrice { get; set; }
    }
}
