using PromotionEngine.Business.Contracts;
using PromotionEngine.Business.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PromotionEngineUnitTest
{
   
    public class UnitTest1
    {
        private IBusinessManager _businessManager;
        public UnitTest1()
        {
            _businessManager = new BusinessManager();
        }
        [Fact]
        public void TestScenario1()
        {
            List<PurchaseDetails> purchaseDetails = MockData.GetScenario1();
            var response=  _businessManager.CheckOut(purchaseDetails);
            int Aval = response.Where(i => i.SKU_Name == "A").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Bval = response.Where(i => i.SKU_Name == "B").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Cval = response.Where(i => i.SKU_Name == "C").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Dval = response.Where(i => i.SKU_Name == "D").Select(i => i.SKU_PRICE).FirstOrDefault();
            Assert.Equal(130, Aval);
            Assert.Equal(120, Bval);
            Assert.Equal(0, Cval);
            Assert.Equal(30, Dval);
        }
        [Fact]
        public void TestScenario2()
        {
            List<PurchaseDetails> purchaseDetails = MockData.GetScenario2();
            var response = _businessManager.CheckOut(purchaseDetails);
            int Aval = response.Where(i => i.SKU_Name == "A").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Bval = response.Where(i => i.SKU_Name == "B").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Cval = response.Where(i => i.SKU_Name == "C").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Dval = response.Where(i => i.SKU_Name == "D").Select(i => i.SKU_PRICE).FirstOrDefault();
            Assert.Equal(230, Aval);
            Assert.Equal(120, Bval);
            Assert.Equal(20, Cval);
        }
        [Fact]
        public void TestScenario3()
        {
            List<PurchaseDetails> purchaseDetails = MockData.GetScenario3();
            var response = _businessManager.CheckOut(purchaseDetails);
            int Aval = response.Where(i => i.SKU_Name == "A").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Bval = response.Where(i => i.SKU_Name == "B").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Cval = response.Where(i => i.SKU_Name == "C").Select(i => i.SKU_PRICE).FirstOrDefault();
            var Dval = response.Where(i => i.SKU_Name == "D").Select(i => i.SKU_PRICE).FirstOrDefault();
            Assert.Equal(50, Aval);
            Assert.Equal(30, Bval);
            Assert.Equal(20, Cval);
        }
    }
}
