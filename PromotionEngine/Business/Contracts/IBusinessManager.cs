using PromotionEngine.Business.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Business.Contracts
{
    public interface IBusinessManager
    {
        List<PurchaseDetails> CheckOut(List<PurchaseDetails> purchaseDetails);
    }
}
