namespace FreebirdFinances.DataLayer.Migrations
{
    using Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FreebirdFinances.DataLayer.FreebirdContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FreebirdFinances.DataLayer.FreebirdContext context)
        {
            context.Incomes.AddOrUpdate(
                i => i.Period,
                new Income
                {
                    Period = "March 2016",
                    IncomeGroups =
                    {
                            new IncomeGroup
                            {
                                Name = "APGE",
                                TaxPercent = 0,
                                IncomeTransactions =
                                {
                                    new IncomeTransaction { Description = "BCA 1", Gross = 3500, IsEstimate = true, IsTaxable = false },
                                    new IncomeTransaction { Description = "BCA 2", Gross = 3500, IsEstimate = true, IsTaxable = false }
                                }
                            },
                            new IncomeGroup
                            {
                                Name = "PPG",
                                TaxPercent = .2,
                                IncomeTransactions =
                                {
                                    new IncomeTransaction { Description = "RSS 1", Gross = 1200, IsEstimate = true, IsTaxable = true },
                                    new IncomeTransaction { Description = "RSS 2", Gross = 1200, IsEstimate = true, IsTaxable = true },
                                    new IncomeTransaction { Description = "BCA 1", Gross = 200, IsEstimate = true, IsTaxable = true }
                                }
                            },
                            new IncomeGroup
                            {
                                Name = "Contract Work",
                                TaxPercent = 0,
                                IncomeTransactions =
                                {
                                    new IncomeTransaction { Description = "Marice Zlotnik", Gross = 400, IsEstimate = true }
                                }
                            }
                    }
                },
                new Income
                {
                    Period = "February 2016",
                    IncomeGroups =
                    {
                            new IncomeGroup
                            {
                                Name = "PPG",
                                TaxPercent = .2,
                                IncomeTransactions =
                                {
                                    new IncomeTransaction { Description = "RSS 1", Gross = 1200, IsEstimate = true, IsTaxable = true },
                                    new IncomeTransaction { Description = "RSS 2", Gross = 1200, IsEstimate = true, IsTaxable = true },
                                    new IncomeTransaction { Description = "BCA 1", Gross = 200, IsEstimate = true, IsTaxable = true }
                                }
                            },
                            new IncomeGroup
                            {
                                Name = "Contract Work",
                                TaxPercent = 0,
                                IncomeTransactions =
                                {
                                    new IncomeTransaction { Description = "Marice Zlotnik", Gross = 400, IsEstimate = true }
                                }
                            }
                    }
                },
                new Income
                {
                    Period = "January 2016",
                    IncomeGroups =
                    {
                            new IncomeGroup
                            {
                                Name = "PPG",
                                TaxPercent = .2,
                                IncomeTransactions =
                                {
                                    new IncomeTransaction { Description = "RSS 1", Gross = 1200, IsEstimate = true, IsTaxable = true },
                                    new IncomeTransaction { Description = "RSS 2", Gross = 1200, IsEstimate = true, IsTaxable = true },
                                    new IncomeTransaction { Description = "BCA 1", Gross = 200, IsEstimate = true, IsTaxable = true }
                                }
                            },
                            new IncomeGroup
                            {
                                Name = "Contract Work",
                                TaxPercent = 0,
                                IncomeTransactions =
                                {
                                    new IncomeTransaction { Description = "Marice Zlotnik", Gross = 400, IsEstimate = true }
                                }
                            }
                    }
                },
                new Income
                {
                    Period = "December 2015",
                }
            );
        }
    }
}
