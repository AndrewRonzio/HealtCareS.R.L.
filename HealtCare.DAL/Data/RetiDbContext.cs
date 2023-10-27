using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealtCare.DAL.Data
{
    public class RetiDbContext : IdentityDbContext<User>
    {

        public RetiDbContext() { }


        public RetiDbContext(DbContextOptions<RetiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<User> Users { get; set; }
    }
}
