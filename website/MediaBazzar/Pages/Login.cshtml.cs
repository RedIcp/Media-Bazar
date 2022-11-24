
using ClassLibraryProject;
using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MediaBazzar.Pages
{

    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        public string Username { get; set; }
        [BindProperty]
        [Required]
        public string Password { get; set; }


        public Employee Login { get; set; }

        private dbLoginManager dbLogin = new dbLoginManager();

        public void OnGet(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
        }

        public async Task<IActionResult> OnPost(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                var user = dbLogin.checkLogin(Username , Password);


                if (user != null)
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim("username", user.Username));
                    claims.Add(new Claim(ClaimTypes.Email, user.Email));
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.EmployeeID.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, user.Username));

                    if ((user is CEO) || (user is DepotManager) || (user is OfficeManager) || (user is ProductManager) || (user is SalesManager))
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "Manager"));
                    } else if ((user is Admin))
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                    }

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                   
                    return Redirect(returnUrl);
                }
            }

            TempData["Error"] = "Error: Incorrect Username or Password";
            return RedirectToPage("/Profile");
        }
    }
}
    