using FreebirdFinances.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreebirdFinances.DataLayer
{
    public class IncomeGroupConfiguration : EntityTypeConfiguration<IncomeGroup>
    {
        public IncomeGroupConfiguration()
        {
            Property(ig => ig.Name).HasMaxLength(50);
            //Property(ig => ig.Total).HasColumnType("numeric(16,2)");
        }
    }
}
