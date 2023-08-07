using Azure.Identity;
using Identity_App.NewModel;
using Identity_App.Pages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Identity_App.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> SignInManager;

        [BindProperty]
        public Register Model{get;set; }
       

        public RegisterModel(UserManager<IdentityUser>userManager, SignInManager<IdentityUser>signInManager)
        {
            this.userManager=userManager;
            this.SignInManager=signInManager;
        }
        public void OnGet()

        {
        }

       

        public async Task<IActionResult> OnPostAsync()
        {
            if(ModelState.IsValid)
            { 
                var user = new IdentityUser()
                {
                    UserName=Model.Email,
                    Email = Model.Email

                };
                var result=await userManager.CreateAsync(user, this.Model.Password);
                if(result.Succeeded)
                {
                 await SignInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return Page();
        }
    }
}
