using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Identity_App.Pages
{
    public class LogoutModel : PageModel
    {
        public SignInManager<IdentityUser> SignInManager { get; }

        public void OnGet()
        {
        }
        public LogoutModel(SignInManager<IdentityUser> signInManager)
        {
           this.SignInManager = signInManager;
        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await SignInManager.SignOutAsync();
            return RedirectToPage("Login");
        }
        public IActionResult OnPostDontLogoutAsync()
        {
            return RedirectToPage("Index");
        }
    }
}
