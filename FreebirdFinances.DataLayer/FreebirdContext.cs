using FreebirdFinances.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreebirdFinances.DataLayer
{
    public class FreebirdContext : DbContext
    {
        public FreebirdContext() : base("DefaultConnection")
        {
        }

        public DbSet<Income> Incomes { get; set; }
        public DbSet<IncomeGroup> IncomeGroups { get; set; }
        public DbSet<IncomeTransaction> IncomeTransactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new IncomeConfiguration());
            modelBuilder.Configurations.Add(new IncomeGroupConfiguration());
            modelBuilder.Configurations.Add(new IncomeTransactionConfiguration());
        }
    }
}
