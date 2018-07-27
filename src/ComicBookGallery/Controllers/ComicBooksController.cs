﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {

                return new RedirectResult("/");
            }


            return Content("Hello from the ComicBooksController!");
            
        }
    }
}