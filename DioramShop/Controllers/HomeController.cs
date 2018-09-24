using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DioramShop.Models;

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
    }
}