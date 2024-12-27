using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Data;

namespace ToDoList.Controllers
{
    public class TestController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public TestController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> AutoLogin()
        {
            // Replace "TestUserEmail" with the email of your test user
            var testUser = await _userManager.FindByEmailAsync("User@gmail.com");
            if (testUser != null)
            {
                await _signInManager.SignInAsync(testUser, isPersistent: false);
                return RedirectToAction("Index", "TaskItem");
            }

            return NotFound("Test user not found.");
        }
    }
}
