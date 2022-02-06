using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using registerModuleRPC.model;

namespace registerModuleRPC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly registerModuleRPC.Data.registerModuleRPCContext2 _context;

        //  [BindProperty]
        //  public string Username { get; set; }

        //[BindProperty]
        // public string Password { get; set; }
        [BindProperty]
        public User UserRPC { get; set; }

        public IndexModel(ILogger<IndexModel> logger, registerModuleRPC.Data.registerModuleRPCContext2 context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }

        
        public void OnPost()
        {
            //Username= Request.Form["username"];
         
           /*
            if (Username==null)
            {
                return Redirect("/Users/Create");
            }
            else
            {


                var dbUser = _context.User.FirstOrDefault(u => u.UserName == Username);
                if (dbUser == null)
                {
                    return Page();

                }
                else
                {
                    return Redirect("/Users/Index");

                }

            }
           */
            /*
            List<model.User> users = _context.User.ToList();
            Boolean exit = false;
          

            for (int i = 0; i < users.Count() && !exit; i++)
            {
                if (users.ElementAt(i).UserName.Equals(Username) && users.ElementAt(i).Password.Equals(Password))
                {
                    exit = true;
                    Response.Redirect("/Users/Index");

                }
            }
            */
        }
           


    }

}
        


        
