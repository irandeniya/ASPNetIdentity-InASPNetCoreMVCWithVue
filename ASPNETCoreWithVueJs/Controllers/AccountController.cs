using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreWithVueJs.BindingModels;
using ASPNETCoreWithVueJs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWithVueJs.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private RoleManager<IdentityRole<Guid>> roleManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, RoleManager<IdentityRole<Guid>> roleManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;

            if (!roleManager.Roles.Any())
            {
                var result = roleManager.CreateAsync(new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Admin", }).Result;
                result = roleManager.CreateAsync(new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "User" }).Result;

                var user = new User { UserName = "admin@abc.asd", Email = "admin@abc.asd" };
                result = userManager.CreateAsync(user, "Admin@123").Result;
                result = userManager.AddToRoleAsync(user, "Admin").Result;

                user = new User { UserName = "user@abc.asd", Email = "user@abc.asd" };
                result = userManager.CreateAsync(user, "User@123").Result;
                result = userManager.AddToRoleAsync(user, "User").Result;
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLogin model)
        {
            User user;
            Microsoft.AspNetCore.Identity.SignInResult result;

            if (ModelState.IsValid && (user = await userManager.FindByEmailAsync(model.Username)) != null
                && (result = await signInManager.PasswordSignInAsync(user, model.Password, false, false)).Succeeded)
            {
                return RedirectToAction("Index", "Products");
            }

            return View();
        }

        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}