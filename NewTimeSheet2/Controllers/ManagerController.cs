using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using NewTimeSheet2.Models;

namespace NewTimeSheet2.Controllers
{
    public class ManagerController : Controller
    {
        public SignInManager<Employee> SignIn { get; }
        public UserManager<Employee> UserManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public ILogger Logger { get; }
        public IActionResult Index()
        {
            return View();
        }

        public ManagerController(SignInManager<Employee> signIn, UserManager<Employee> userManager, RoleManager<IdentityRole> roleManager, ILogger<ManagerController> logger)
        {
            SignIn = signIn;
            UserManager = userManager;
            RoleManager = roleManager;
            Logger = logger;
        }

        public IActionResult Phrase()
        {
            //Gives access to our User
            if (User.IsInRole("Super"))
            {
                Logger.LogDebug("User is in Super Role");
            }
            if (User.IsInRole("Smash"))
            {
                Logger.LogDebug("User is in Smash Role");
            }

            return View();
        }

        [Authorize(Roles = "Super")]
        public IActionResult Patriot()
        {
            return View();
        }
    }
}
   