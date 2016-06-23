using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YYLB.Models;
namespace YYLB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //直接在对应的视图页面写死的html
        public ActionResult ListAllTheProducts()
        {
            return View();
        }

        public ActionResult ShowAllTheProducts()
        {
            //手动提供一些集合数据
            List<Product> products = new List<Product> {
                new Product { ProductName="Apple",Price="10"},
                new Product { ProductName="IPhone",Price="4000"},
                new Product { ProductName="Dell",Price="500"}
            };
            return View(products);  //将products集合传递给视图，让视图去展现

        }

    }
}