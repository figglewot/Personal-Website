using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Posts(string id)
        {
            return View(id);
        }

    }
}