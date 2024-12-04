using Backend_sr15.DAL;
using Backend_sr15.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Backend_sr15.Controllers
{
	public class HomeController : Controller
	{
		ShopContext db;

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger,
ShopContext db)
		{
			_logger = logger;
			this.db = db;
		}

		public IActionResult Index()
		{
			var produkty = db.Products.ToList();

			ViewBag.Produkty = produkty;

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}