using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using School_Project_WebApplication.Models;

namespace School_Project_WebApplication.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManger;

        public AdminController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManger = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Create(Role role)
        {
            var roleExist = await roleManger.RoleExistsAsync(role.RoleName);
            if(!roleExist)
            {
                var result = await roleManger.CreateAsync(new IdentityRole(role.RoleName));
            }
            return View();
        }
    }
}
