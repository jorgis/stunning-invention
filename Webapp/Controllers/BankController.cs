using Microsoft.AspNetCore.Mvc;
// using ZXing;

namespace Webapp.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
                // var bv = new BarcodeWriter();
            TempData["qrData"] = "SomeValue";

            return View();
        }

        public IActionResult Status()
        {

            return
        }
    }


}