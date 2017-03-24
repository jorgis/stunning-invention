using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapp.Helpers;
using Webapp.Models;
using WebApp.Helpers.BlockCypher;
using WebApp.Helpers.BlockCypher.Objects;

namespace Webapp.Controllers
{
    public class IssuerController : Controller
    {
        public IActionResult Index()
        {
            // Folkeregister master info:

            // Address: C7x3Qk4Ap5nvAnxtCEnczmgH34nvfeGRBA
            // PrivKey: 5236251e976fa32500640dd025d2848222defa18e6a7ed95f7837495fc75aeed
            // PubKey: 03fc31bb287b1a0b7856f6eeaeeee21b3eeecd6797c1e94529e7214a9225d1ebea
            // Balance: 10000 satoshi


            return View();
        }

        [HttpPost]
        public IActionResult Index(BirthCertificateInputModel viewmodel)
        {
            if (ModelState.IsValid)
            {

                return View("BirthCertificate", viewmodel);
            }

            return View();
        }

        public string init_folkeregister()
        {
            string output = "";

            Blockcypher api = new Blockcypher(Constants.apiUserToken, Endpoint.BcyTest);

            AddressInfo address = api.GenerateAddress().Result;

            output += $"<br>Address: {address.Address}";
            output += $"<br>PrivKey: {address.Private}";
            output += $"<br>PubKey: {address.Public}";

            Faucet f = api.Faucet(address.Address, new Satoshi(100)).Result;

            output += $"<br>Transferring 100 satoshi to account";

            Thread.Sleep(1000);
            // TODO Find out how to add some data to the transactions?
            // TODO Make a viewmodel, create the form to specify data etc.

            AddressBalance bal = api.GetBalanceForAddress(address.Address).Result;
            
            output += $"<br>Balance: {bal.Balance.Value} satoshi";
            output += $"<br>Unconfirmed balance: {bal.UnconfirmedBalance} satoshi";

            // HttpContext.Session.SetString(Constants.PrivateKeySessionKey, address.Private);
            // HttpContext.Session.SetString(Constants.AddressSessionKey, address.Address);

            return output;
        }
    }
}