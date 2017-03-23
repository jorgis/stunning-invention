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
        public IActionResult Index()
        {
                // var bv = new BarcodeWriter();
            TempData["qrData"] = "SomeValue";

            return View();
        }

        public IActionResult Status()
        {
            // check transaction
            var  api = new Blockcypher(Constants.apiUserToken, Endpoint.BtcTest3);
            api.GetTransactions(Constants.AddressSessionKey);
            

            return View();
        }
    }


}