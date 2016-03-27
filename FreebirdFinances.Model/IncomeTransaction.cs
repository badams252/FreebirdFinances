using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreebirdFinances.Model
{
    public class IncomeTransaction
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public double Gross { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsEstimate { get; set; }
        public double Tax
        {
            get
            {
                if (IsTaxable)
                    return Gross * IncomeGroup.TaxPercent; 
                else
                    return 0;
            }
            private set { }
        }
        public double Net
        {
            get
            {
                return Gross - Tax;
            }
            private set { }
        }
        public int IncomeGroupId { get; set; }
        public IncomeGroup IncomeGroup { get; set; }

    }
}