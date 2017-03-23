using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapp.Helpers;
using WebApp.Helpers.BlockCypher;
using WebApp.Helpers.BlockCypher.Objects;

namespace Webapp.Controllers
{
    public class BankController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
                // var bv = new BarcodeWriter();
            TempData["qrData"] = "SomeValue";
            var model = new BankViewModel();
            model.QrValue = "SomeValue";
            return View(model);
        }

        [HttpGet]
        public IActionResult Status()
        {
            // check transaction
            var  api = new Blockcypher(Constants.apiUserToken, Endpoint.BtcTest3);
            var tr = api.GetTransactions(Constants.AddressSessionKey);
            var count = tr.Result.Length;

            return new JsonResult(count);
        }
    }
}