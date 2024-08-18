using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ASUS\\SQLEXPRESS01;Initial Catalog=DbCQRS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Product> Products { get; set; }
    }
}
