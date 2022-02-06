using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using registerModuleRPC.model;

namespace registerModuleRPC.Pages.Account
{
    public class LoginModel : PageModel
    {
    
        [BindProperty]
        public User UserRPC{ get; set; }

        private readonly registerModuleRPC.Data.registerModuleRPCContext2 _context;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger, registerModuleRPC.Data.registerModuleRPCContext2 context)
        {
            _logger = logger;
            _context = context;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {

            var dbUser = _context.User.FirstOrDefault(u => u.UserName == UserRPC.UserName && u.Password==UserRPC.Password);
            if (dbUser == null)
            {
                Page();

            }
            else
            {
                Response.Redirect("/Users/Index");

            }
        }



    }
}
