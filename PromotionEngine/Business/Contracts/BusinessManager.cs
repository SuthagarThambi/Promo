using PromotionEngine.Business.Contracts.Models;
using PromotionEngine.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Business.Contracts
{
    public class BusinessManager : IBusinessManager
    {
        private readonly IDataManager _dataManager;
        public BusinessManager()
        {
            _dataManager=new DataManager();

        }
        public List<PurchaseDetails> CheckOut(List<PurchaseDetails> purchaseDetails)
        {
            List<PurchaseDetails> CheckOutDetails = new List<PurchaseDetails>();
            PurchaseDetails CheckOutDetail;
            var purchaseItemDetails = purchaseDetails?
                                    .GroupBy(i => i.SKU_Name)
                                    .Select  (x => new
                                                {
                                                     SKU_Name=x.Key,
                                                    SKU_Quantity = x.Sum(y=>y.SKU_Quantity),
                                                }).ToList();
            var countofC = purchaseItemDetails.Where(i => i.SKU_Name == "C").Select(i => i.SKU_Quantity).FirstOrDefault();
            var countofD = purchaseItemDetails.Where(i => i.SKU_Name == "D").Select(i => i.SKU_Quantity).FirstOrDefault();
                   


            List < SKUDetails> SkuDetails = _dataManager.GetSkuDetails();
            foreach (var item in purchaseItemDetails)
            {
                SKUDetails SKUConfigDetails = SkuDetails.Where(i => i.SKU_Name == item.SKU_Name).First();
               CheckOutDetail =new PurchaseDetails();
                CheckOutDetail.SKU_Name = item.SKU_Name;
                CheckOutDetail.SKU_Quantity = item.SKU_Quantity;

                if (item.SKU_Name == "C" && countofC == 0)
                {
                    CheckOutDetail.SKU_PRICE = 0;
                }
                else if(item.SKU_Name == "C" && countofC > countofD)
                {
                    CheckOutDetail.SKU_PRICE = (countofC-countofD) * SKUConfigDetails.SKU_PRICE;
                }
                else if(item.SKU_Name == "C" && countofD > countofC)
                {
                    CheckOutDetail.SKU_PRICE = 0;
                }
                else if (item.SKU_Name == "D" && countofD == countofC)
                {
                    CheckOutDetail.SKU_PRICE = countofD * SKUConfigDetails.SKU_PromoPrice;

                }
                else if (item.SKU_Name == "D" && countofD > countofC)
                {
                    CheckOutDetail.SKU_PRICE = countofD -(countofD - countofC) * SKUConfigDetails.SKU_PromoCnt + (countofD - countofC) * SKUConfigDetails.SKU_PRICE;

                }
                else if (item.SKU_Name == "D" && countofD < countofC && countofD !=0)
                {
                    CheckOutDetail.SKU_PRICE = countofD * SKUConfigDetails.SKU_PromoPrice;

                }
                else if (item.SKU_Name == "D" && countofD < countofC && countofD == 0)
                {
                    CheckOutDetail.SKU_PRICE = 0;

                }
                if (item.SKU_Name != "D" && item.SKU_Name != "C")
                {
                    if (item.SKU_Quantity == 1)
                    {
                        CheckOutDetail.SKU_PRICE = item.SKU_Quantity * SKUConfigDetails.SKU_PRICE;

                    }
                    else
                    {
                        CheckOutDetail.SKU_PRICE = (item.SKU_Quantity / SKUConfigDetails.SKU_PromoCnt) * SKUConfigDetails.SKU_PromoPrice + (item.SKU_Quantity % SKUConfigDetails.SKU_PromoCnt) * SKUConfigDetails.SKU_PRICE;
                    }
                }

                CheckOutDetails.Add(CheckOutDetail);

            }

            return CheckOutDetails;


        }
    }
}
