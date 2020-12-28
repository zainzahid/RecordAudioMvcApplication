using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecordAudioMvcApplication.Controllers
{
    public class FormationController : Controller
    {
        // GET: Formation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save()
        {
            // Here Request.Files will recieve blob that we can upload to S3
            return Content("Hello From Formation Controller");
        }
    }
}