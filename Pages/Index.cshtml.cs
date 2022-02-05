using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace registerModuleRPC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly registerModuleRPC.Data.registerModuleRPCContext _context;

        public string Username { get; set; }
       
        public string Password { get; set; }

        public IndexModel(ILogger<IndexModel> logger, registerModuleRPC.Data.registerModuleRPCContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }

        public void OnPostSignIn()
        {
            //string un = Request.Form["username"];

            
                foreach (var u in _context.User)
                {
                    if (u.UserName == Username && u.Password == Password)
                    {
                        Response.Redirect("/Users/Index");
                    }
                }

            
            
           
        }

    }
        


        
}