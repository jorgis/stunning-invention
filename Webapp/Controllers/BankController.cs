using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapp.Helpers;
using WebApp.Helpers.BlockCypher;
using WebApp.Helpers.BlockCypher.Objects;

using WebApp.Helpers;

namespace Webapp.Controllers
{
    public class BankController : Controller
    {
        Session _session;
        public BankController()
        {
            _session = new Session(HttpContext);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new BankViewModel();
            model.QrValue = OneTimePassword.Phrase();
            HttpContext.Session.SetString("Phrase", model.QrValue);
            return View(model);
        }

        [HttpGet]
        public IActionResult Secure()
        {
            return View();
        }

        [HttpPost]
        public string Authenticated(string phrase)
        {   
            OneTimePassword.Keys.Add(phrase);
            return phrase;
        }

        [HttpGet]
        public IActionResult Status()
        {   
            // check transaction
            var  api = new Blockcypher(Constants.apiUserToken, Endpoint.BtcTest3);
            var tr = api.GetTransactions(_session.GetDemoAddress());
            var count = tr.Result.Length;

            var phrase = HttpContext.Session.GetString("Phrase");

            // var success = OneTimePassword.Keys.Exists(a => a == phrase);
            var success = OneTimePassword.Keys.Count > 0;
            if(success)
            {
                OneTimePassword.Keys.Remove(phrase);
                return new JsonResult(true);
            }
            else
            {
                return new JsonResult(false);
            }
        }
    }
}