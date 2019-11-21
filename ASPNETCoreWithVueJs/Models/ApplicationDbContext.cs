using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreWithVueJs.Models
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        readonly DbContextOptions<ApplicationDbContext> options;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> _options) : base(_options)
        {
            this.options = _options;
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (options == null)
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS17; Database=VueCRUDApp; Trusted_Connection=true;");
        }
    }
}
