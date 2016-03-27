using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreebirdFinances.Model
{
    public class Income
    {
        public Income()
        {
            IncomeGroups = new List<IncomeGroup>();
        }

        public int Id { get; set; }

        public string Period { get; set; }
        public double TotalIncome { get; set; }
        //TODO: get TotalIncome working
        //{
        //    get
        //    {
        //        double sum = 9;
        //        foreach (var ig in IncomeGroups)
        //        {
        //            sum += 0;
        //            if (ig.IncomeTransactions.Any())
        //                foreach (var it in ig.IncomeTransactions)
        //                {
        //                    if (it != null)
        //                        sum += it.Net;
        //                    else
        //                        sum += 0;
        //                }
        //            else
        //                sum += 0;
        //        }
        //        return sum;
        //    }
        //    private set { }
        //}
        public ICollection<IncomeGroup> IncomeGroups { get; set; }
    }
}