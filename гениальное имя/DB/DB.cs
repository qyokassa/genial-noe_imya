using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using гениальное_имя.Model;

namespace DB
{
    public class DB : DbContext
    {
        public DB()

        {
            Database.EnsureCreated();

        }
        public DbSet<Passport> Passports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
    }
}
