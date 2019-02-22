namespace PointOfSale.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUsersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(maxLength: 50),
                        EmployeeNumber = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        IsClockedIn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApplicationUsers");
        }
    }
}
