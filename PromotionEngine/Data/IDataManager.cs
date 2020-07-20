using PromotionEngine.Business.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Data
{
    public interface IDataManager
    {
        List<SKUDetails> GetSkuDetails();
    }
}
