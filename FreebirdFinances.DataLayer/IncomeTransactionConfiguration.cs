using FreebirdFinances.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreebirdFinances.DataLayer
{
    public class IncomeTransactionConfiguration : EntityTypeConfiguration<IncomeTransaction>
    {
        public IncomeTransactionConfiguration()
        {
            Property(it => it.Description).HasMaxLength(50).IsRequired();
            //Property(it => it.Gross).HasColumnType("numeric(16,2)");
        }
    }
}
