using PromotionEngine.Business.Contracts;
using PromotionEngine.Business.Contracts.Models;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>()
            //{
            //    new PurchaseDetails(){SKU_Name="A",SKU_Quantity=3},
            //    new PurchaseDetails(){SKU_Name="B",SKU_Quantity=6},
            //    new PurchaseDetails(){SKU_Name="C",SKU_Quantity=9},
            //    new PurchaseDetails(){SKU_Name="D",SKU_Quantity=10},
            //    new PurchaseDetails(){SKU_Name="A",SKU_Quantity=11},
            //    new PurchaseDetails(){SKU_Name="B",SKU_Quantity=12},
            //    new PurchaseDetails(){SKU_Name="C",SKU_Quantity=10},
            //    new PurchaseDetails(){SKU_Name="D",SKU_Quantity=2}
            //};

            //List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>()
            //{
            //    new PurchaseDetails(){SKU_Name="A",SKU_Quantity=3},
            //    new PurchaseDetails(){SKU_Name="B",SKU_Quantity=5},
            //    new PurchaseDetails(){SKU_Name="C",SKU_Quantity=1},
            //    new PurchaseDetails(){SKU_Name="D",SKU_Quantity=1},
            //};

            //List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>()
            //{
            //    new PurchaseDetails(){SKU_Name="A",SKU_Quantity=5},
            //    new PurchaseDetails(){SKU_Name="B",SKU_Quantity=5},
            //    new PurchaseDetails(){SKU_Name="C",SKU_Quantity=1},
            //    new PurchaseDetails(){SKU_Name="D",SKU_Quantity=0},
            //};

            List<PurchaseDetails> purchaseDetails = new List<PurchaseDetails>()
            {
                new PurchaseDetails(){SKU_Name="A",SKU_Quantity=1},
                new PurchaseDetails(){SKU_Name="B",SKU_Quantity=1},
                new PurchaseDetails(){SKU_Name="C",SKU_Quantity=1},
                new PurchaseDetails(){SKU_Name="D",SKU_Quantity=0},
            };
            IBusinessManager businessManager = new BusinessManager();
            businessManager.CheckOut(purchaseDetails);
        }
    }
}
