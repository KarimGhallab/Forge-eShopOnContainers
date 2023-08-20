using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator.Models;
using Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator.Services;
using System.Net;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.Web.Shopping.HttpAggregator.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IBasketService _basketService;
        
        public OrderController(IBasketService basketService)
        {
            _basketService = basketService;
            
        }

        [Route("draft/{basketId}")]
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(OrderData), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<OrderData>> GetOrderDraftAsync(string basketId)
        {
            return this.Redirect("~/");
        }
    }
}
