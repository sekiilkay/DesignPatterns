using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ASUS\\SQLEXPRESS01;Initial Catalog=DbDecorator;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notifier> Notifiers { get; set; }
    }
}
