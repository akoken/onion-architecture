using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Core.DomainService.Services;

namespace OnionArchitecture.UI.Web.Api
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class StoreController : Controller
    {
        private readonly IProductService _productService;

        public StoreController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Produces(typeof(string[]))]
        public IActionResult Get()
        {
            var categories =_productService.GetCategories();
            return Ok(categories.ToArray());
        }
    }
}
