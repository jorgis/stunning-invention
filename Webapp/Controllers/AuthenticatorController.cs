using System;
using Microsoft.AspNetCore.Mvc;

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
		public IActionResult Verify()
		{
			return View("Index");
		}
	}
}
