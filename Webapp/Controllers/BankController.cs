using Microsoft.AspNetCore.Mvc;
//using com.google.zxing;
using ZXing;

namespace Webapp.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
                // var bv = new BarcodeWriter();
            TempData["QrCode"] = "";

            return View();
        }
    }
}