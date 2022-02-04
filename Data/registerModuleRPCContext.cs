#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using registerModuleRPC.model;

namespace registerModuleRPC.Data
{
    public class registerModuleRPCContext : DbContext
    {
        public registerModuleRPCContext (DbContextOptions<registerModuleRPCContext> options)
            : base(options)
        {
        }

        public DbSet<registerModuleRPC.model.User> User { get; set; }
    }
}
