namespace FreebirdFinances.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IncomeGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Total = c.Double(nullable: false),
                        IncomeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Incomes", t => t.IncomeId, cascadeDelete: true)
                .Index(t => t.IncomeId);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Period = c.String(maxLength: 20),
                        TotalIncome = c.Double(nullable: false),
                        TaxPercent = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IncomeTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        Gross = c.Double(nullable: false),
                        IsTaxable = c.Boolean(nullable: false),
                        IsEstimate = c.Boolean(nullable: false),
                        Tax = c.Double(nullable: false),
                        Net = c.Double(nullable: false),
                        IncomeGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IncomeGroups", t => t.IncomeGroupId, cascadeDelete: true)
                .Index(t => t.IncomeGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IncomeTransactions", "IncomeGroupId", "dbo.IncomeGroups");
            DropForeignKey("dbo.IncomeGroups", "IncomeId", "dbo.Incomes");
            DropIndex("dbo.IncomeTransactions", new[] { "IncomeGroupId" });
            DropIndex("dbo.IncomeGroups", new[] { "IncomeId" });
            DropTable("dbo.IncomeTransactions");
            DropTable("dbo.Incomes");
            DropTable("dbo.IncomeGroups");
        }
    }
}
