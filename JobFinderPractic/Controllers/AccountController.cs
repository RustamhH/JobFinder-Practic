using Database.Entities.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace JobFinderPractic.Controllers;

public class AccountController : Controller
{
    // Login
    public readonly UserManager<AppUser> _appUserManager;
    public readonly UserManager<AppUser> _signInManager;
    public readonly RoleManager<IdentityRole> _roleManager;

    public AccountController(
        UserManager<AppUser> appUserManager,
        UserManager<AppUser> signInManager,
        RoleManager<IdentityRole> roleManager)
    {
        _appUserManager = appUserManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]

    public async Task<IActionResult> Register(RegisterVM registerVM)
    {
        if (!ModelState.IsValid)
        {
            return View(registerVM);
        }
        AppUser appUser = new AppUser()
        {
            FullName = registerVM.FullName,
            Email = registerVM.Email,
        };
        var result = await _appUserManager.CreateAsync(appUser, registerVM.Password);

        if (!result.Succeeded)
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View();
        }
        //await _appUserManager.AddToRoleAsync(appUser,"AppUser");
        return RedirectToAction("Login");
    }

}