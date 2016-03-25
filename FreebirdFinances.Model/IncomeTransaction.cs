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
        public double Tax { get; set; }
        //{
        //    get
        //    {
        //        // TODO: Must figure out how to reference parent to get tax percent.
        //        if (IsTaxable)
        //            return Gross * .20; // this will turn from .20 to tax percent
        //        else
        //            return 0;
        //    }
        //}
        public double Net { get; set; }
        //{
        //    get
        //    {
        //        return Gross - Tax;
        //    }
        //}
        public int IncomeGroupId { get; set; }
        public IncomeGroup IncomeGroup { get; set; }

    }
}