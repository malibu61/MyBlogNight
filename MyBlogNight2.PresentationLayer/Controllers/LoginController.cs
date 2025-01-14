﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.EntityLayer.Concrete;
using MyBlogNight2.PresentationLayer.Models;

namespace MyBlogNight2.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
            if (result.Succeeded)
            {
                return Redirect("/Author/Article/Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            return Redirect("/Login/Index");
        }
    }
}
