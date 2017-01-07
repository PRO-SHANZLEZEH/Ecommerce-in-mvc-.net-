using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clothes.Repository;

namespace Clothes.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private ICategoryRepository iCategoryRepository = new CategoryRepository();
        private IProductRepository iProductRepository = new ProductRepository();
        public ActionResult Category(int id)
        {
            var category = iCategoryRepository.find(id);
            ViewBag.category = category;
            ViewBag.products = category.Products.ToList();
            return View("Category");
        }
        //public ActionResult Specials()
        //{
        //    return View("Specials");
        //}
        public ActionResult Details(int id)
        {
            ViewBag.product = iProductRepository.find(id);
            ViewBag.relatedProducts = iProductRepository.RelatedProducts(iProductRepository.find(id), 6);
            return View("Details");
        }
    }
}