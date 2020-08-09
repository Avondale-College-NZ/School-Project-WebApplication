using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Project_WebApplication.Controllers
{
    public class AdmininstrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;


        public AdmininstrationController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
      
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
    }

}