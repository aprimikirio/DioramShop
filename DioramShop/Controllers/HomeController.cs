using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DioramShop.Models;
using DioramShop.Util;

namespace DioramShop.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();

        public ActionResult Index()
        {
            IEnumerable<Product> products = db.Products;            
            ViewBag.Products = products;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }
        public string Square(int a = 10, int h = 3)
        {
            double s = a * h / 2.0;
            return "<h2>Площадь треугольника с основанием " + a +
                    " и высотой " + h + " равна " + s + "</h2>";
        }
        public ActionResult GetImage()
        {
            string path = "../Images/BongoCatBody.png";
            return new ImageResult(path);
        }
        public ViewResult SomeMethod()
        {
            ViewData["Head"] = "Some Method!";
            return View("SomeView");
        }
    }
}