using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SweetTreats.Models;
using System.Threading.Tasks; // allows for async
using SweetTreats.ViewModels;

namespace SweetTreats.Controllers
{
  public class AccountController : Controller
  {
    private readonly SweetTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager; //UserManager = Identity Service - helps manage saving and updating account info
    private readonly SignInManager<ApplicationUser> _signInManager; // SignIn Manager = Identity Service - allows users to log-in

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SweetTreatsContext db) //Dependency Injection
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.Email };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}