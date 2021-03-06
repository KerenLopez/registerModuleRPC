#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using registerModuleRPC.Data;
using registerModuleRPC.model;

namespace registerModuleRPC.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly registerModuleRPC.Data.registerModuleRPCContext2 _context;

        public CreateModel(registerModuleRPC.Data.registerModuleRPCContext2 context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return Redirect("/../Index");
        }

    }
}
