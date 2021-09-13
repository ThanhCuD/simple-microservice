using Microsoft.EntityFrameworkCore;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext  : DbContext
    {
        public DbSet<User> Users{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=WS-THANHDUC\MSSQLSERVER2017;initial catalog=user_microservice;Trusted_Connection=True;");
        }
    }
}
