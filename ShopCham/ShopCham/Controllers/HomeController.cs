using ShopCham.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopCham.Controllers
{
    public class HomeController : Controller
    {
        ShopChamDbContext db = new ShopChamDbContext();
        public ActionResult Index()
        {
            var model = db.Categories
                .Where(c => c.Products.Count >= 4)
                .OrderBy(c => Guid.NewGuid()).ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Category()
        {
            var model = db.Categories;
            return PartialView("_Category", model);
        }

        public ActionResult SaleOff()
        {
            var model = db.Products.Where(p => p.Discount > 0).Take(5);
            return PartialView("_SaleOff", model);
        }

        public ActionResult BestSeller()
        {
            var model = db.Products.Where(p => p.Special).Take(3);
            return PartialView("_BestSeller", model);
        }
    }
}