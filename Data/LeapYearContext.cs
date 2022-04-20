using LeapYear.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LeapYear.Data{
    public class LeapYearContext : IdentityDbContext {
        public LeapYearContext(DbContextOptions options) : base(options) { }
        public DbSet<LeapYearComponent> Person { get; set; }
    }
}
