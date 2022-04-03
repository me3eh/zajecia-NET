using LeapYear.Models;
using Microsoft.EntityFrameworkCore;

namespace LeapYear.Data{
    public class LeapYearContext : DbContext {
        public LeapYearContext(DbContextOptions options) : base(options) { }
        public DbSet<LeapYearComponent> Person { get; set; }
    }
}
