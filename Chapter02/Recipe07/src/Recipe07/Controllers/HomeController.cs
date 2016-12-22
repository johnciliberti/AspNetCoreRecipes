using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Recipe07.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OneHundred()
        {
            var model = new List<String>();
            var template = "{0} is an {1} number.";
            bool isHalfDone = false;
            for (var i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    if(isHalfDone)
                    {
                        displayHalfTimeShow();
                    }
                    model.Add(string.Format(template, i, "even"));
                    if (i == 50)
                    {
                        isHalfDone = true;
                        model.Add("We are half done.");
                    }
                }
                else
                {
                    model.Add(string.Format(template, i, "odd"));
                }
            }
            return View(model);
        }

        private void displayHalfTimeShow()
        {
            return;
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}