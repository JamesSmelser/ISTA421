﻿using Microsoft.AspNetCore.Mvc;
using EFPartyInvites.Models;
using System.Linq;

namespace EFPartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext ctx) => context = ctx;
        public IActionResult Index() => View();
        public IActionResult Respond() => View();
        [HttpPost]
        public IActionResult Respond(GuestResponse response)
        {
            context.Responses.Add(response);
            context.SaveChanges();
            return RedirectToAction(nameof(Thanks),
            new { Name = response.Name, WillAttend = response.WillAttend });
        }
        public IActionResult Thanks(GuestResponse response)
        {
            return View(response);
        }
        public IActionResult ListResponses()
        {
            return View(context.Responses.OrderByDescending(r => r.WillAttend));
        }
    }
}