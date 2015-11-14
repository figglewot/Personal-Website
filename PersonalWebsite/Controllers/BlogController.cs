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
        awrightBlogDb _db = new awrightBlogDb();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Posts(string id)
        {
            var model = _db.BlogPosts
                    .Where(blogPost => blogPost.PostUrl == id);
            
            return View(id, model);
        }

        protected override void Dispose(bool disposing)
        {
            _db?.Dispose();
            base.Dispose(disposing);
        }

    }
}