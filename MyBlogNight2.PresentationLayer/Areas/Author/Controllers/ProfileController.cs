﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight2.EntityLayer.Concrete;
using MyBlogNight2.PresentationLayer.Areas.Author.Models;

namespace MyBlogNight2.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> EditMyProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Surname = values.Surname;
            model.Name = values.Name;
            model.Username = values.UserName;
            model.Email = values.Email;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditMyProfile(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = model.Name;
            user.Email = model.Email;
            user.Surname = model.Surname;
            user.UserName = model.Username;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return Redirect("/Author/Article/Index");
            }

            return View();
        }
    }
}
