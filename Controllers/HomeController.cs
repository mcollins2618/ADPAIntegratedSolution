﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ADAPIntegratedSolution.Models;
using System.Security.Claims;

namespace ADAPIntegratedSolution.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Newsfeed()
        {
            ViewData["Message"] = "Your application Newsfeed page.";

            return View();
        }

        public IActionResult BookRoom()
        {
            ViewData["Message"] = "Your forms page.";

            return View();
        }

        public IActionResult MeetingCapture()
        {
            ViewData["Message"] = "Your Meeting Capture page.";

            return View();
        }

        public IActionResult OutOfOffice()
        {
            ViewData["Message"] = "Your Out of Office page.";

            return View();
        }

        public IActionResult LogicApp()
        {
            ViewData["Message"] = "Your Logic App page.";

            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
