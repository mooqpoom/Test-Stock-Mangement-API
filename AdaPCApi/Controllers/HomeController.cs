﻿using System;
using System.Collections.Generic;
using System.Configuration; 
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AdaPCApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


    }
}
