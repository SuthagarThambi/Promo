using PromotionEngine.Business.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PromotionEngineUnitTest
{
    public static class MockData
    {
        public static List<PurchaseDetails> GetScenario1()
        {
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>()
            {
                new PurchaseDetails(){SKU_Name="A",SKU_Quantity=3},
                new PurchaseDetails(){SKU_Name="B",SKU_Quantity=5},
                new PurchaseDetails(){SKU_Name="C",SKU_Quantity=1},
                new PurchaseDetails(){SKU_Name="D",SKU_Quantity=1},
            };
            return purchaseDetails;
        }
        public static List<PurchaseDetails> GetScenario2()
        {
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>()
            {
                new PurchaseDetails(){SKU_Name="A",SKU_Quantity=5},
                new PurchaseDetails(){SKU_Name="B",SKU_Quantity=5},
                new PurchaseDetails(){SKU_Name="C",SKU_Quantity=1},
            };
            return purchaseDetails;
        }
        public static List<PurchaseDetails> GetScenario3()
        {
            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>()
            {
                new PurchaseDetails(){SKU_Name="A",SKU_Quantity=1},
                new PurchaseDetails(){SKU_Name="B",SKU_Quantity=1},
                new PurchaseDetails(){SKU_Name="C",SKU_Quantity=1},
            };
            return purchaseDetails;
        }
    }
}
