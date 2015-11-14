using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using PersonalWebsite.Models;
using PersonalWebsite.Models.Resume;

namespace PersonalWebsite.Controllers
{
    public class ResumeController : Controller
    {
        awrightBlogDb _db = new awrightBlogDb();
        public ActionResult Resume()
        {
            return View();
        }

        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Client, NoStore = true)]
        public PartialViewResult Certifications()
        {
            var model = _db.Certifications;

            return PartialView("_Certifications", model);
        }
        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Client, NoStore = true)]
        public PartialViewResult Skills()
        {
            var model = _db.Skills;

            return PartialView("_Skills", model);
        }
        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Client, NoStore = true)]
        public PartialViewResult Experience()
        {
            var model = _db.Experience;

            return PartialView("_Experience", model);
        }
        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Client, NoStore = true)]
        public PartialViewResult Interests()
        {
            var model = _db.Interests;

            return PartialView("_Interests", model);
        }
        protected override void Dispose(bool disposing)
        {
            _db?.Dispose();
            base.Dispose(disposing);
        }
    }
}