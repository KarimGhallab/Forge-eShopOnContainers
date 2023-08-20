using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopOnContainers.WebMVC.Services;
using Microsoft.eShopOnContainers.WebMVC.ViewModels;
using System;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.WebMVC.Controllers
{
    [Authorize(AuthenticationSchemes = OpenIdConnectDefaults.AuthenticationScheme)]
    public class OrderController : Controller
    {
        
        
        private readonly IIdentityParser<ApplicationUser> _appUserParser;
        public OrderController(IIdentityParser<ApplicationUser> appUserParser)
        {
            _appUserParser = appUserParser;
            
            
        }

        public async Task<IActionResult> Create()
        {

            return null;
        }

        [HttpPost]
        public async Task<IActionResult> Checkout()
        {
            return null;
        }

        public async Task<IActionResult> Cancel(string orderId)
        {
            return null;
        }

        public async Task<IActionResult> Detail(string orderId)
        {
            return null;
        }

        public async Task<IActionResult> Index()
        {
            return null;
        }
    }
}