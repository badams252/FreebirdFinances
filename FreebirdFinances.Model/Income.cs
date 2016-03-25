using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreebirdFinances.Model
{
    public class Income
    {
        public int Id { get; set; }

        public string Period { get; set; }
        public double TotalIncome { get; set; }
        //{
        //    get
        //    {
        //        double sum = 0;
        //        foreach (var ig in IncomeGroups)
        //        {
        //            if (ig.IncomeTransactions.Any())
        //                sum += ig.IncomeTransactions.Sum(x => x.Net);
        //            else
        //                sum += 0;
        //        }
        //        return sum;
        //    }
        //    private set { }
        //}
        public double TaxPercent { get; set; }
        public ICollection<IncomeGroup> IncomeGroups { get; set; }

    }
}