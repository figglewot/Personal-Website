using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite.Models;
using PagedList;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        awrightBlogDb _db = new awrightBlogDb();
        public ActionResult Index(int page = 1)
        {
            var model =
                _db.BlogPosts
                    .OrderByDescending(blogPost => blogPost.Id).ToPagedList(page, 2);

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            _db?.Dispose();
            base.Dispose(disposing);
        }
    }
}