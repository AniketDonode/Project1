namespace BankAppProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Balance = c.Double(nullable: false),
                        Passsword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BankTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustName = c.String(),
                        Amount = c.Double(nullable: false),
                        Type = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        BankMaster_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BankMasters", t => t.BankMaster_Id)
                .Index(t => t.BankMaster_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BankTransactions", "BankMaster_Id", "dbo.BankMasters");
            DropIndex("dbo.BankTransactions", new[] { "BankMaster_Id" });
            DropTable("dbo.BankTransactions");
            DropTable("dbo.BankMasters");
        }
    }
}
