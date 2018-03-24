using System.Linq;
using GeekBurger.StoreCatalog.Core;
using GeekBurger.StoreCatalog.Core.Interfaces;
using GeekBurger.StoreCatalog.Infra.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeekBurger.StoreCatalog.Tests.IntegrationsTests
{
    [TestClass]
    public class ProductCoreTest
    {
        private IProductCore _productCore;

        public ProductCoreTest()
        {
            //_productCore = new ProductCore(new Products());
        }

        [TestMethod]
        public void Check_All_Products_Available()
        {
            //var result = _productCore.GetAllProductsAvaliables().ToList();

            //Assert.IsNotNull(result);
            //Assert.IsTrue(result.Count > 0);
        }
    }
}
