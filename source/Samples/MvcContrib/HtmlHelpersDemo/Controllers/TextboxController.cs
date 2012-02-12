﻿using System.Web.Mvc;
using HtmlHelpersDemo.Models;

namespace HtmlHelpersDemo.Controllers
{
    public class TextboxController : Controller
    {
        //
        // GET: /Textbox/

        public ActionResult Index()
        {
            var model = new User
                            {
                                Age = 10,
                                LastName = "Arne"
                            };
            return View(model);
        }
    }
}