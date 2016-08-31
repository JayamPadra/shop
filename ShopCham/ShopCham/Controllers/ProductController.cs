using ShopCham.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopCham.Controllers
{
    public class ProductController : Controller
    {
        ShopChamDbContext db = new ShopChamDbContext();
        //
        // GET: /Product/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Category(int categoryID = 0)
        {
            if (categoryID != 0)
            {
                var model = db.Products.Where(p => p.CategoryId == categoryID);
                return View(model);
            }
            return View();
        }

        public ActionResult Detail(int id)
        {
            var model = db.Products.Find(id);
            return View(model);

        }
	}
}