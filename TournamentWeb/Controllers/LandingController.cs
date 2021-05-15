﻿using TournamentWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TournamentWeb.Controllers
{
    public class LandingController : Controller
    {


        public IActionResult Landingpage()
        {

            if (User.Identity.IsAuthenticated)
            {
                return View("LoggedInLanding");
            }
            else
            {
                return View();
            }
        }

    }
}
