#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using registerModuleRPC.Data;
using registerModuleRPC.model;

namespace registerModuleRPC.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly registerModuleRPC.Data.registerModuleRPCContext _context;

        public DetailsModel(registerModuleRPC.Data.registerModuleRPCContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.ID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
