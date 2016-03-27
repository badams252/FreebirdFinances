using FreebirdFinances.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreebirdFinances.Web.ViewModels
{
    public class IncomeViewModel
    {
        public int Id { get; set; }

        public string Period { get; set; }
        public double TotalIncome { get; set; }
        public ICollection<IncomeGroup> IncomeGroups { get; set; }

        public string MessageToClient { get; set; }

    }
}