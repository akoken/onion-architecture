using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
