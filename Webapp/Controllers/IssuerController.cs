using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapp.Helpers;
using WebApp.Helpers.BlockCypher;
using WebApp.Helpers.BlockCypher.Objects;

namespace Webapp.Controllers
{
    public class IssuerController : Controller
    {
        public IActionResult Index()
        {
            do_api_stuff();


            return View();
        }

        public async void do_api_stuff()
        {
            Blockcypher api = new Blockcypher(Constants.apiUserToken, Endpoint.BtcTest3);

            AddressInfo address = await api.GenerateAddress();

            Console.WriteLine($"Address: {address.Address}");

            
            HttpContext.Session.SetString(Constants.PrivateKeySessionKey, address.Private);
        }
    }
}