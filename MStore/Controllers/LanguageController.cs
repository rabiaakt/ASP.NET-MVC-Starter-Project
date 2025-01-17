﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MStore.Controllers
{
    public class LanguageController : Controller
    {
        //static string defaultLanguage = "tr";

        public ActionResult ChangeLanguage(string language)
        {
            if (language != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            }
            HttpCookie cookie = new HttpCookie("language")
            {
                Value = language
            };

            Response.Cookies.Add(cookie);
            //defaultLanguage = cookie.Value;
            return RedirectToAction("Index", "Home");
        }

    }
}