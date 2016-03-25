using FreebirdFinances.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreebirdFinances.DataLayer
{
    public class IncomeConfiguration : EntityTypeConfiguration<Income>
    {
        public IncomeConfiguration()
        {
            Property(i => i.Period).HasMaxLength(20);
        }
    }
}
