using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers
{
    public class IssuerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}