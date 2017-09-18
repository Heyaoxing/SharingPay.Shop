using IBusiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharingShop.ShopApi.Controllers
{
    public class HomeController : Controller
    {
        private  static IAuthorityService _accountService;
        public HomeController(IAuthorityService accountService)
        {
            _accountService = accountService;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
