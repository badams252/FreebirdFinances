﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreebirdFinances.Model
{
    public class IncomeGroup
    {
        public IncomeGroup()
        {
            IncomeTransactions = new List<IncomeTransaction>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public double TaxPercent { get; set; }
        public double Total
        {
            get
            {
                return IncomeTransactions.Sum(x => x.Net);
            }
            private set { }
        }
        public int IncomeId { get; set; }
        public Income Income { get; set; }
        public ICollection<IncomeTransaction> IncomeTransactions { get; set; }

    }
}