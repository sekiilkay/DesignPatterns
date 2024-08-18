using DesignPattern.ChainOfResponsibility.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ASUS\\SQLEXPRESS01;Initial Catalog=DbChainOfResponsibility;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
