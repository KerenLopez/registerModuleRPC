#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using registerModuleRPC.model;

namespace registerModuleRPC.Data
{
    public class registerModuleRPCContext2 : DbContext
    {
        public registerModuleRPCContext2 (DbContextOptions<registerModuleRPCContext2> options)
            : base(options)
        {
        }

        public DbSet<registerModuleRPC.model.User> User { get; set; }
    }
}
