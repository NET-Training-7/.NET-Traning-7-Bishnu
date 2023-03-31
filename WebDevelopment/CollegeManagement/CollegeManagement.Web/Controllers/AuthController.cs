using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Web.Controllers;
public class AuthController : Controller
{
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly UserManager<IdentityUser> userManager;

    public AuthController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
    {
        this.roleManager = roleManager;
        this.userManager = userManager;
    }

    public IActionResult Roles()
    {
        var roles = roleManager.Roles.ToList();

        return View(roles);
    }

    public IActionResult AddRole()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddRole(IdentityRole identityRole)
    {
        await roleManager.CreateAsync(identityRole);
        return RedirectToAction("Roles");
    }

    public IActionResult Users()
    {
        var users = userManager.Users.ToList();

        return View(users);
    }

    public async Task<IActionResult> AssignRole(string userId)
    {
        var user = await userManager.FindByIdAsync(userId);
        var roles = roleManager.Roles.ToList();

        return View((user, roles));
    }
}
