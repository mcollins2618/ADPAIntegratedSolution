using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ADAPIntegratedSolution.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Net;

namespace ADAPIntegratedSolution.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewBag.User = User.Identity.Name;

            //use https://jwt.io/ to visualize them
            string accessToken = await HttpContext.GetTokenAsync("access_token");
            string idToken = await HttpContext.GetTokenAsync("id_token");
            ViewBag.AccessToken = accessToken;
            ViewBag.IdToken = idToken;
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {accessToken}");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error accessing APi layer " + ex.Message;
            }
            return View();
        }

        public IActionResult Attachments()
        {
            ViewData["Message"] = "Your application Attachments page.";

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
