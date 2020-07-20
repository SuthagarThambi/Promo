using PromotionEngine.Business.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Data
{
    public class DataManager : IDataManager
    {
        public List<SKUDetails> GetSkuDetails()
        {
            return new List<SKUDetails>()
            {
                new SKUDetails(){SKU_Name="A",SKU_PRICE =50,SKU_PromoCnt=3,SKU_PromoPrice= 130},
                new SKUDetails(){SKU_Name="B",SKU_PRICE =30,SKU_PromoCnt=2,SKU_PromoPrice= 45 },
                new SKUDetails(){SKU_Name="C",SKU_PRICE =20,SKU_PromoCnt=1,SKU_PromoPrice= 30 },
                new SKUDetails(){SKU_Name="D",SKU_PRICE =15,SKU_PromoCnt=1,SKU_PromoPrice= 30},
            };
        }
    }
}
