using Microsoft.EntityFrameworkCore;
using Mindash.Countdown.Web.Data.DTOS;

namespace Mindash.Countdown.Web.Data
{
    public class CountDownDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(Environment.CurrentDirectory, "CountdownData.db");
            optionsBuilder.UseSqlite("Filename = " + dbPath);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<DTOS.CountdownEvent> CountdownEvents { get; set; }
    }
}
