using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}