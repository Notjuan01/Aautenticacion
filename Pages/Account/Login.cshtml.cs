using Autenticacion.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs;
using System.Security.Claims;

namespace Autenticacion.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            if (user.Email == "correo@gmail.com" && user.Password == "1234")
            {
                var clains = new List<Claim>
                {
                new Claim(ClaimTypes.Name, "admin"),
                new Claim(ClaimTypes.Email, user.Email),
                };
                var identity = new ClaimsIdentity(clains, "My coockieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MycookieAuth", claimsPrincipal);
                return RedirectToPage("/Index");
            }
            return Page();
            

        }
    }
}
