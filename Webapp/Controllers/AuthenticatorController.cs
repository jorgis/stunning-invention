using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Webapp.Helpers;
using WebApp.Helpers.BlockCypher;
using WebApp.Helpers.BlockCypher.Objects;

namespace Webapp.Controllers
{
	public class AuthenticatorController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Verify(string keyword)
		{
			Blockcypher api = new Blockcypher(Constants.apiUserToken, Endpoint.BtcTest3);

			//Sign keyword with private key of IDCoin

			return View("Index");
		}

		public IActionResult Success()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Scanner()
		{
			return View();
		}


		[HttpGet]
		public IActionResult Error()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Selector()
		{
			return View();
		}
	}
}
