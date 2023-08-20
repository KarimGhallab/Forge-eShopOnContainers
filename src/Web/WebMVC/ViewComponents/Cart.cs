using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopOnContainers.WebMVC.Services;
using Microsoft.eShopOnContainers.WebMVC.ViewModels;
using Microsoft.eShopOnContainers.WebMVC.ViewModels.CartViewModels;
using System.Threading.Tasks;

namespace Microsoft.eShopOnContainers.WebMVC.ViewComponents
{
    public class Cart : ViewComponent
    {
        

        

        public async Task<IViewComponentResult> InvokeAsync(ApplicationUser user)
        {
            return null;
        }
        
    }
}
