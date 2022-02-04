﻿#nullable disable
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
    public class IndexModel : PageModel
    {
        private readonly registerModuleRPC.Data.registerModuleRPCContext _context;

        public IndexModel(registerModuleRPC.Data.registerModuleRPCContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}