﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTracker.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [Authorize]
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
        }
    }
}