using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopOnContainers.WebMVC.Services;
using Microsoft.eShopOnContainers.WebMVC.ViewModels;
using System.Threading.Tasks;
using WebMVC.Services.ModelDTOs;

namespace WebMVC.Controllers
{
    [Authorize(AuthenticationSchemes = OpenIdConnectDefaults.AuthenticationScheme)]
    public class OrderManagementController : Controller
    {
        
        private readonly IIdentityParser<ApplicationUser> _appUserParser;
        public OrderManagementController(IIdentityParser<ApplicationUser> appUserParser)
        {
            _appUserParser = appUserParser;
            
        }

        public async Task<IActionResult> Index()
        {
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> OrderProcess(string orderId, string actionCode)
        {
            return null;
        }
    }
}
