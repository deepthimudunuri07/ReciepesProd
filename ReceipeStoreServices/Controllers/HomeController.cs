using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Web.Mvc;

namespace ReceipeStoreServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        //public JsonResult Get()
        //{
        //    XDocument InputXml = XDocument.Load("InputFile.xml");
        //    var Result = InputXml.Descendants("ReceipeType");
        //    return Json(Result, JsonRequestBehavior.AllowGet);
        //}
    }
}
