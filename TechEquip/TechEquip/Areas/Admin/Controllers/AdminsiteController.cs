using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechEquip.Areas.Admin.Controllers
{
    public class AdminsiteController : Controller
    {
        // GET: Admin/Adminsite
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Store()
        {
            return View();
        }
    }
}