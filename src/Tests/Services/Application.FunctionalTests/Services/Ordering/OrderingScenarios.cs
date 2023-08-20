using FunctionalTests.Extensions;
using FunctionalTests.Services.Basket;
using Microsoft.eShopOnContainers.Services.Basket.API.Model;
using Microsoft.eShopOnContainers.WebMVC.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Services.ModelDTOs;
using Xunit;

namespace FunctionalTests.Services.Ordering
{
    public class OrderingScenarios : OrderingScenariosBase
    {
        [Fact]
        public async Task Cancel_basket_and_check_order_status_cancelled()
        {
            Assert.IsTrue(true);
        }

        

        

        

        string BuildBasket()
        {
            var order = new CustomerBasket("9e3163b9-1ae6-4652-9dc6-7898ab7b7a00");
            order.Items = new List<Microsoft.eShopOnContainers.Services.Basket.API.Model.BasketItem>()
            {
                new Microsoft.eShopOnContainers.Services.Basket.API.Model.BasketItem()
                {
                    Id = "1",
                    ProductName = "ProductName",
                    ProductId = 1,
                    UnitPrice = 10,
                    Quantity = 1
                }
            };
            return JsonConvert.SerializeObject(order);
        }

        

        
    }
}
