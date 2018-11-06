using BankAccount.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankAccount.Models
{
    public class BanckAccountContext : DbContext
    {
        public BanckAccountContext(DbContextOptions<BanckAccountContext> options)
                : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
    }
}