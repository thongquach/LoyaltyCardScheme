using LoyaltyCardScheme.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LoyaltyCardScheme.DAL
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
