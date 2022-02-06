using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using registerModuleRPC.model;

namespace registerModuleRPC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly registerModuleRPC.Data.registerModuleRPCContext2 _context;
        public Boolean UserFounded;
       
        [BindProperty]
        public User UserRPC { get; set; }

        public IndexModel(ILogger<IndexModel> logger, registerModuleRPC.Data.registerModuleRPCContext2 context)
        {
            _logger = logger;
            _context = context;
            UserFounded = true;
        }

        public void OnGet()
        {

        }

        
        public void OnPost()
        {
            
            var dbUser = _context.User.FirstOrDefault(u => u.UserName == UserRPC.UserName && u.Password == UserRPC.Password);
            if (dbUser == null)
            {
                UserFounded = false;
                Page();
                

            }
            else
            {
                UserFounded = true;
                Response.Redirect("/Users/Index");

            }
        }
    }
           


 }


        


        
