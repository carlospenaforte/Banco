using Banco.Models;
using Microsoft.EntityFrameworkCore;

namespace Banco.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.AccountOrigin)
                .WithMany(a => a.TransactionOrigin)
                .HasForeignKey(t => t.AccountOriginId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Account>()
                .HasMany(t => t.TransactionDestination)
                .WithOne(a => a.AccountDestination)
                .HasForeignKey(t => t.AccountDestinationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
