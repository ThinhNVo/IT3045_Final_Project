using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Group4_IT3045_FinalProject.Models;

namespace Group4_IT3045_FinalProject.Data
{
    public class Group4_IT3045_FinalProjectContext : DbContext
    {
        public Group4_IT3045_FinalProjectContext (DbContextOptions<Group4_IT3045_FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Group4_IT3045_FinalProject.Models.Cat> Cat { get; set; } = default!;
    }
}
