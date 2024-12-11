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

		[HttpGet]
		public IActionResult Index()
		{
			var produkty = db.Products.ToList();

			ViewBag.Produkty = produkty;

			return View();
		}

		[HttpPost]
		public IActionResult Index(Product product) 
		{
			if(product.Id == 0)
			{
				db.Products.Add(product);
			}
			else
			{
				db.Products.Update(product);
			}

			db.SaveChanges();

			var produkty = db.Products.ToList();

			ViewBag.Produkty = produkty;

			return View();
		}

		public IActionResult Edit(int id)
		{
			var produkt = new Product();

			if(id > 0)
			{
				produkt = db.Products.Find(id);
			}

			return View(produkt);
		}

		public IActionResult Delete(int id)
		{
			var produkt = db.Products.Find(id);

			if(produkt != null)
			{
				db.Products.Remove(produkt);
			}

			db.SaveChanges();

			var produkty = db.Products.ToList();

			ViewBag.Produkty = produkty;

			return View("Index");
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