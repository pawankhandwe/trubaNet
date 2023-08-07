using Identity_App.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Identity_App.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Model { get; set; }
        public SignInManager<IdentityUser> SignInManager { get; }

        public void OnGet()
        {
        }
        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.SignInManager = signInManager;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var Identifyresult = await SignInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if (Identifyresult.Succeeded)
                    {
                    if (returnUrl == null || returnUrl == "/")
                    {

                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }

                ModelState.AddModelError("", "username or password incorrect !");

            }
            return Page();
        }

    }
}