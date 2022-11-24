using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazzar.Pages
{
    public class UserHomeModel : PageModel
    {
        private readonly ILogger<UserHomeModel> _logger;

        public UserHomeModel(ILogger<UserHomeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            HttpContext.Session.Clear();

            return new RedirectToPageResult("Index");
        }

    }
}
