﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ReceipeStore.Controllers
{
  
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}
